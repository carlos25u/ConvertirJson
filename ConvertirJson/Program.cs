using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using ConvertirJson;
using OfficeOpenXml;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        string rutaExcel = @"C:\\Users\\Carlo\\OneDrive\\Escritorio\\ProcesoCert.xlsx";
        var lista = Utils.CargarDatosDesdeExcel(rutaExcel);

        string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

        try
        {
            // Convertir JSON en un objeto JArray
            JArray jsonArray = JArray.Parse(json);

            int contador = 1;
            foreach (var item in jsonArray)
            {
                // Filtrar los valores "#e" y eliminar "Detalle"
                var filteredItem = FilterJson(item);
                if (filteredItem.IsNullOrEmpty()) continue;

                // Crear objeto raíz por cada encabezado
                JObject root = new JObject { ["Encabezado"] = filteredItem };

                // Convertir a XML
                XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(root.ToString(), "ECF");

                // Formatear XML con indentación
                using (var stringWriter = new StringWriter())
                using (var xmlTextWriter = new XmlTextWriter(stringWriter))
                {
                    xmlTextWriter.Formatting = System.Xml.Formatting.Indented;
                    xmlDoc.WriteTo(xmlTextWriter);
                    string formattedXml = stringWriter.ToString();

                    string xmlFilePath = $@"C:\\Users\\Carlo\\OneDrive\\Escritorio\\ProcesoCert_{contador}.xml";
                    File.WriteAllText(xmlFilePath, formattedXml);
                    Console.WriteLine($"Archivo generado: {xmlFilePath}");
                }

                contador++;
            }

            Console.WriteLine("Todos los archivos XML fueron generados correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error: " + ex.Message);
        }
    }

    static JToken FilterJson(JToken token)
    {
        if (token.Type == JTokenType.Object)
        {
            JObject obj = (JObject)token.DeepClone();
            foreach (var property in obj.Properties().ToList())
            {
                if ((property.Value.Type == JTokenType.String && property.Value.ToString() == "#e") ||
                    property.Name == "Detalle" || property.Name == "Orden" || property.Name == "CasoPrueba")
                {
                    property.Remove();
                }
                else
                {
                    property.Value = FilterJson(property.Value);
                }
            }
            return obj;
        }
        else if (token.Type == JTokenType.Array)
        {
            JArray array = new JArray();
            foreach (var item in (JArray)token)
            {
                var filteredItem = FilterJson(item);
                if (!filteredItem.IsNullOrEmpty())
                {
                    array.Add(filteredItem);
                }
            }
            return array;
        }
        return token;
    }
}

public static class JsonExtensions
{
    public static bool IsNullOrEmpty(this JToken token)
    {
        return (token == null) ||
               (token.Type == JTokenType.Array && !token.HasValues) ||
               (token.Type == JTokenType.Object && !token.HasValues);
    }
}
