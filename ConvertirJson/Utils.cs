using ConvertirJson.Mapeos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirJson
{
    internal class Utils
    {
        public static List<OrdenECF> CargarDatosDesdeExcel(string filePath)
        {
            var ordenes = new List<OrdenECF>();

            // Cargar el archivo Excel
            FileInfo fileInfo = new FileInfo(filePath);
            using (var package = new ExcelPackage(fileInfo))
            {
                // Seleccionar la primera hoja de trabajo
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                // Iterar sobre las filas del Excel, comenzando en la segunda fila (la primera fila puede ser la cabecera)
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    var orden = new OrdenECF
                    {
                        Orden = worksheet.Cells[row, 1].Text,
                        CasoPrueba = worksheet.Cells[row, 2].Text,
                        Version = worksheet.Cells[row, 3].Text,
                        TipoeCF = worksheet.Cells[row, 4].Text,
                        ENCF = worksheet.Cells[row, 5].Text,
                        FechaVencimientoSecuencia = worksheet.Cells[row, 6].Text,
                        IndicadorNotaCredito = worksheet.Cells[row, 7].Text,
                        IndicadorEnvioDiferido = worksheet.Cells[row, 8].Text,
                        IndicadorMontoGravado = worksheet.Cells[row, 9].Text,
                        TipoIngresos = worksheet.Cells[row, 10].Text,
                        TipoPago = worksheet.Cells[row, 11].Text,
                        FechaLimitePago = worksheet.Cells[row, 12].Text,
                        TerminoPago = worksheet.Cells[row, 13].Text,
                        FormaPago1 = worksheet.Cells[row, 14].Text,
                        MontoPago1 = worksheet.Cells[row, 15].Text,
                        FormaPago2 = worksheet.Cells[row, 16].Text,
                        MontoPago2 = worksheet.Cells[row, 17].Text,
                        FormaPago3 = worksheet.Cells[row, 18].Text,
                        MontoPago3 = worksheet.Cells[row, 19].Text,
                        FormaPago4 = worksheet.Cells[row, 20].Text,
                        MontoPago4 = worksheet.Cells[row, 21].Text,
                        FormaPago5 = worksheet.Cells[row, 22].Text,
                        MontoPago5 = worksheet.Cells[row, 23].Text,
                        FormaPago6 = worksheet.Cells[row, 24].Text,
                        MontoPago6 = worksheet.Cells[row, 25].Text,
                        FormaPago7 = worksheet.Cells[row, 26].Text,
                        MontoPago7 = worksheet.Cells[row, 27].Text,
                        TipoCuentaPago = worksheet.Cells[row, 28].Text,
                        NumeroCuentaPago = worksheet.Cells[row, 29].Text,
                        BancoPago = worksheet.Cells[row, 30].Text,
                        FechaDesde = worksheet.Cells[row, 31].Text,
                        FechaHasta = worksheet.Cells[row, 32].Text,
                        TotalPaginas = worksheet.Cells[row, 33].Text,
                        RNCEmisor = worksheet.Cells[row, 34].Text,
                        RazonSocialEmisor = worksheet.Cells[row, 35].Text,
                        NombreComercial = worksheet.Cells[row, 36].Text,
                        Sucursal = worksheet.Cells[row, 37].Text,
                        DireccionEmisor = worksheet.Cells[row, 38].Text,
                        Municipio = worksheet.Cells[row, 39].Text,
                        Provincia = worksheet.Cells[row, 40].Text,
                        TelefonoEmisor1 = worksheet.Cells[row, 41].Text,
                        TelefonoEmisor2 = worksheet.Cells[row, 42].Text,
                        TelefonoEmisor3 = worksheet.Cells[row, 43].Text,
                        CorreoEmisor = worksheet.Cells[row, 44].Text,
                        WebSite = worksheet.Cells[row, 45].Text,
                        ActividadEconomica = worksheet.Cells[row, 46].Text,
                        CodigoVendedor = worksheet.Cells[row, 47].Text,
                        NumeroFacturaInterna = worksheet.Cells[row, 48].Text,
                        NumeroPedidoInterno = worksheet.Cells[row, 49].Text,
                        ZonaVenta = worksheet.Cells[row, 50].Text,
                        RutaVenta = worksheet.Cells[row, 51].Text,
                        InformacionAdicionalEmisor = worksheet.Cells[row, 52].Text,
                        FechaEmision = worksheet.Cells[row, 53].Text,
                        RNCComprador = worksheet.Cells[row, 54].Text,
                        IdentificadorExtranjero = worksheet.Cells[row, 55].Text,
                        RazonSocialComprador = worksheet.Cells[row, 56].Text,
                        ContactoComprador = worksheet.Cells[row, 57].Text,
                        CorreoComprador = worksheet.Cells[row, 58].Text,
                        DireccionComprador = worksheet.Cells[row, 59].Text,
                        MunicipioComprador = worksheet.Cells[row, 60].Text,
                        ProvinciaComprador = worksheet.Cells[row, 61].Text,
                        PaisComprador = worksheet.Cells[row, 62].Text,
                        FechaEntrega = worksheet.Cells[row, 63].Text,
                        ContactoEntrega = worksheet.Cells[row, 64].Text,
                        DireccionEntrega = worksheet.Cells[row, 65].Text,
                        TelefonoAdicional = worksheet.Cells[row, 66].Text,
                        FechaOrdenCompra = worksheet.Cells[row, 67].Text,
                        NumeroOrdenCompra = worksheet.Cells[row, 68].Text,
                        CodigoInternoComprador = worksheet.Cells[row, 69].Text,
                        ResponsablePago = worksheet.Cells[row, 70].Text,
                        InformacionAdicionalComprador = worksheet.Cells[row, 71].Text,
                        FechaEmbarque = worksheet.Cells[row, 72].Text,
                        NumeroEmbarque = worksheet.Cells[row, 73].Text,
                        NumeroContenedor = worksheet.Cells[row, 74].Text,
                        NumeroReferencia = worksheet.Cells[row, 75].Text,
                        NombrePuertoEmbarque = worksheet.Cells[row, 76].Text,
                        CondicionesEntrega = worksheet.Cells[row, 77].Text,
                        TotalFob = worksheet.Cells[row, 78].Text,
                        Seguro = worksheet.Cells[row, 79].Text,
                        Flete = worksheet.Cells[row, 80].Text,
                        OtrosGastos = worksheet.Cells[row, 81].Text,
                        TotalCif = worksheet.Cells[row, 82].Text,
                        RegimenAduanero = worksheet.Cells[row, 83].Text,
                        NombrePuertoSalida = worksheet.Cells[row, 84].Text,
                        NombrePuertoDesembarque = worksheet.Cells[row, 85].Text,
                        PesoBruto = worksheet.Cells[row, 86].Text,
                        PesoNeto = worksheet.Cells[row, 87].Text,
                        UnidadPesoBruto = worksheet.Cells[row, 88].Text,
                        UnidadPesoNeto = worksheet.Cells[row, 89].Text,
                        CantidadBulto = worksheet.Cells[row, 90].Text,
                        UnidadBulto = worksheet.Cells[row, 91].Text,
                        VolumenBulto = worksheet.Cells[row, 92].Text,
                        UnidadVolumen = worksheet.Cells[row, 93].Text,
                        ViaTransporte = worksheet.Cells[row, 94].Text,
                        PaisOrigen = worksheet.Cells[row, 95].Text,
                        DireccionDestino = worksheet.Cells[row, 96].Text,
                        PaisDestino = worksheet.Cells[row, 97].Text,
                        RNCIdentificacionCompaniaTransportista = worksheet.Cells[row, 98].Text,
                        NombreCompaniaTransportista = worksheet.Cells[row, 99].Text,
                        NumeroViaje = worksheet.Cells[row, 100].Text,
                        Conductor = worksheet.Cells[row, 101].Text,
                        DocumentoTransporte = worksheet.Cells[row, 102].Text,
                        Ficha = worksheet.Cells[row, 103].Text,
                        Placa = worksheet.Cells[row, 104].Text,
                        RutaTransporte = worksheet.Cells[row, 105].Text,
                        ZonaTransporte = worksheet.Cells[row, 106].Text,
                        NumeroAlbaran = worksheet.Cells[row, 107].Text,
                        MontoGravadoTotal = worksheet.Cells[row, 108].Text,
                        MontoGravadoI1 = worksheet.Cells[row, 109].Text,
                        MontoGravadoI2 = worksheet.Cells[row, 110].Text,
                        MontoGravadoI3 = worksheet.Cells[row, 111].Text,
                        MontoExento = worksheet.Cells[row, 112].Text,
                        ITBIS1 = worksheet.Cells[row, 113].Text,
                        ITBIS2 = worksheet.Cells[row, 114].Text,
                        ITBIS3 = worksheet.Cells[row, 115].Text,
                        TotalITBIS = worksheet.Cells[row, 116].Text,
                        TotalITBIS1 = worksheet.Cells[row, 117].Text,
                        TotalITBIS2 = worksheet.Cells[row, 118].Text,
                        TotalITBIS3 = worksheet.Cells[row, 119].Text,
                        MontoImpuestoAdicional = worksheet.Cells[row, 120].Text,
                        TipoImpuesto1 = worksheet.Cells[row, 121].Text,
                        TasaImpuestoAdicional1 = worksheet.Cells[row, 122].Text,
                        MontoImpuestoSelectivoConsumoEspecifico1 = worksheet.Cells[row, 123].Text,
                        MontoImpuestoSelectivoConsumoAdvalorem1 = worksheet.Cells[row, 124].Text,
                        OtrosImpuestosAdicionales1 = worksheet.Cells[row, 125].Text,
                        MontoTotal = worksheet.Cells[row, 126].Text,
                        MontoNoFacturable = worksheet.Cells[row, 127].Text,
                        MontoPeriodo = worksheet.Cells[row, 128].Text,
                        SaldoAnterior = worksheet.Cells[row, 129].Text,
                        MontoAvancePago = worksheet.Cells[row, 130].Text,
                        ValorPagar = worksheet.Cells[row, 131].Text,
                        TotalITBISRetenido = worksheet.Cells[row, 132].Text,
                        TotalISRRetencion = worksheet.Cells[row, 133].Text,
                        TotalITBISPercepcion = worksheet.Cells[row, 134].Text,
                        TotalISRPercepcion = worksheet.Cells[row, 135].Text,
                        TipoMoneda = worksheet.Cells[row, 136].Text,
                        TipoCambio = worksheet.Cells[row, 137].Text,
                        MontoGravadoTotalOtraMoneda = worksheet.Cells[row, 138].Text,
                        MontoGravado1OtraMoneda = worksheet.Cells[row, 139].Text,
                        MontoGravado2OtraMoneda = worksheet.Cells[row, 140].Text,
                        MontoGravado3OtraMoneda = worksheet.Cells[row, 141].Text,
                        MontoExentoOtraMoneda = worksheet.Cells[row, 142].Text,
                        TotalITBISOtraMoneda = worksheet.Cells[row, 143].Text,
                        TotalITBIS1OtraMoneda = worksheet.Cells[row, 144].Text,
                        TotalITBIS2OtraMoneda = worksheet.Cells[row, 145].Text,
                        TotalITBIS3OtraMoneda = worksheet.Cells[row, 146].Text,
                        MontoImpuestoAdicionalOtraMoneda = worksheet.Cells[row, 147].Text,
                        MontoTotalOtraMoneda = worksheet.Cells[row, 148].Text
                    };

                    // Agregar la orden a la lista
                    ordenes.Add(orden);
                }
            }

            return ordenes;
        }
    }
}
 