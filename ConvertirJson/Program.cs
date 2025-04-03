using System;
using System.Collections.Generic;
using System.IO;
using ConvertirJson;
using Newtonsoft.Json;
using OfficeOpenXml;

class Program
{
    static void Main()
    {

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        string rutaExcel = @"C:\\Users\\Carlo\\OneDrive\\Escritorio\\ProcesoCert.xlsx";
        var lista = Utils.CargarDatosDesdeExcel(rutaExcel);

        string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
        File.WriteAllText("C:\\Users\\Carlo\\OneDrive\\Escritorio\\ConverJson.json", json);
    }
}