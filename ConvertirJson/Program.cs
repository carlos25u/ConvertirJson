using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using ConvertirJson;
using OfficeOpenXml;

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
            // Convertir JSON en un objeto JToken
            JToken jsonToken = JToken.Parse(json);

            // Filtrar los valores que sean "#e"
            jsonToken = FilterJson(jsonToken);

            XmlDocument xmlDoc;

            // Verificar si el JSON es un array
            if (jsonToken is JArray)
            {
                // Si es un array, lo envolvemos en un objeto con un nodo ráiz
                JObject rootObject = new JObject { ["Items"] = jsonToken };
                xmlDoc = JsonConvert.DeserializeXmlNode(rootObject.ToString(), "Root");
            }
            else
            {
                // Si es un objeto normal, lo convertimos directamente
                xmlDoc = JsonConvert.DeserializeXmlNode(jsonToken.ToString(), "Root");
            }

            string xmlFilePath = @"C:\\Users\\Carlo\\OneDrive\\Escritorio\\ProcesoCert.xml";

            // Formatear el XML con sangría y cada etiqueta en una línea
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = new XmlTextWriter(stringWriter))
            {
                xmlTextWriter.Formatting = System.Xml.Formatting.Indented;
                xmlDoc.WriteTo(xmlTextWriter);
                string formattedXml = stringWriter.ToString();

                // Guardar el XML formateado en un archivo
                File.WriteAllText(xmlFilePath, formattedXml);

                Console.WriteLine("Archivo XML generado correctamente.");
                Console.WriteLine("Contenido del archivo XML:");
                Console.WriteLine(formattedXml);
            }
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
                if (property.Value.Type == JTokenType.String && property.Value.ToString() == "#e")
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
