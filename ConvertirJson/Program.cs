using System.Xml;
using OfficeOpenXml;
using System.Xml.Linq;
using ConvertirJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


class Program
{
    static void Main()
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        string rutaExcel = "/Users/jhonalbert/Downloads/131918476-04042025134740.xlsx";
        var lista = Utils.CargarDatosDesdeExcelRFCE(rutaExcel, 1);

        string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

        try
        {
            JArray jsonArray = JArray.Parse(json);
            Console.WriteLine(jsonArray[0]);
            
            string rutaSalida = "/Users/jhonalbert/Downloads/ArchivosGenerados/";
            Directory.CreateDirectory(rutaSalida);
            int contador = 0;

            foreach (JToken jToken in jsonArray)
            {
                XmlDocument xmlDoc = JsonConvert.DeserializeXmlNode(jToken.ToString(), "root");
                
                // Formatear XML con indentación
                using (var stringWriter = new StringWriter())
                using (var xmlTextWriter = new XmlTextWriter(stringWriter))
                {
                    xmlTextWriter.Formatting = System.Xml.Formatting.Indented;
                    xmlDoc.WriteTo(xmlTextWriter);
                    string xmlString = stringWriter.ToString();

                 
                    string nombreArchivo = Path.Combine(rutaSalida, $"archivo_{contador}.xml");
                    File.WriteAllText(nombreArchivo, xmlString);
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

    static XElement XmlIfNotEmpty(string tag, JToken token)
    {
        if (token == null || string.IsNullOrWhiteSpace(token.ToString())) return null;
        return new XElement(tag, token.ToString());
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