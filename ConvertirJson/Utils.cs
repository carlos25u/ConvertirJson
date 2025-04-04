using ConvertirJson.Mapeos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;


namespace ConvertirJson
{
    internal class Utils
    {



        public static DataTable WorksheetToDataTable(ExcelWorksheet worksheet)
        {
            DataTable dt = new DataTable();

            if (worksheet?.Dimension == null)
                return dt; // Retornar tabla vacía si la hoja está vacía

            int columns = worksheet.Dimension.End.Column;
            int rows = worksheet.Dimension.End.Row;

            // Agregar columnas al DataTable (usando la primera fila como encabezado)
            for (int col = 1; col <= columns; col++)
            {
                string columnName = worksheet.Cells[1, col].Value?.ToString().Trim() ?? $"Column{col}";
                dt.Columns.Add(columnName);
            }

            // Agregar filas al DataTable (desde la segunda fila en adelante)
            for (int row = 2; row <= rows; row++)
            {
                DataRow newRow = dt.NewRow();
                for (int col = 1; col <= columns; col++)
                {
                    newRow[col - 1] = worksheet.Cells[row, col].Value?.ToString().Trim() ?? string.Empty;
                }
                dt.Rows.Add(newRow);
            }

            return dt;
        }




        public static List<OrdenECF> CargarDatosDesdeExcel(string filePath)
        {
            var ordenes = new List<OrdenECF>();

            // Cargar el archivo Excel
            FileInfo fileInfo = new FileInfo(filePath);
            // Seleccionar la primera hoja de trabajo
            DataTable dt = new DataTable();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                dt = WorksheetToDataTable(worksheet);


            }


            foreach (DataRow row in dt.Rows)
            {

                var orden = new OrdenECF
                {

                    Orden = row[0].ToString(),
                    CasoPrueba = row[1].ToString(),
                    Version = row[2].ToString(),
                    TipoeCF = row[3].ToString(),
                    ENCF = row[4].ToString(),
                    FechaVencimientoSecuencia = row[5].ToString(),
                    IndicadorNotaCredito = row[6].ToString(),
                    IndicadorEnvioDiferido = row[7].ToString(),
                    IndicadorMontoGravado = row[8].ToString(),
                    TipoIngresos = row[9].ToString(),
                    TipoPago = row[10].ToString(),
                    FechaLimitePago = row[11].ToString(),
                    TerminoPago = row[12].ToString(),
                    FormaPago1 = row[13].ToString(),
                    MontoPago1 = row[14].ToString(),
                    FormaPago2 = row[15].ToString(),
                    MontoPago2 = row[16].ToString(),
                    FormaPago3 = row[17].ToString(),
                    MontoPago3 = row[18].ToString(),
                    FormaPago4 = row[19].ToString(),
                    MontoPago4 = row[20].ToString(),
                    FormaPago5 = row[21].ToString(),
                    MontoPago5 = row[22].ToString(),
                    FormaPago6 = row[23].ToString(),
                    MontoPago6 = row[24].ToString(),
                    FormaPago7 = row[25].ToString(),
                    MontoPago7 = row[26].ToString(),
                    TipoCuentaPago = row[27].ToString(),
                    NumeroCuentaPago = row[28].ToString(),
                    BancoPago = row[29].ToString(),
                    FechaDesde = row[30].ToString(),
                    FechaHasta = row[31].ToString(),
                    TotalPaginas = row[32].ToString(),
                    RNCEmisor = row[33].ToString(),
                    RazonSocialEmisor = row[34].ToString(),
                    NombreComercial = row[35].ToString(),
                    Sucursal = row[36].ToString(),
                    DireccionEmisor = row[37].ToString(),
                    Municipio = row[38].ToString(),
                    Provincia = row[39].ToString(),
                    TelefonoEmisor1 = row[40].ToString(),
                    TelefonoEmisor2 = row[41].ToString(),
                    TelefonoEmisor3 = row[42].ToString(),
                    CorreoEmisor = row[43].ToString(),
                    WebSite = row[44].ToString(),
                    ActividadEconomica = row[45].ToString(),
                    CodigoVendedor = row[46].ToString(),
                    NumeroFacturaInterna = row[47].ToString(),
                    NumeroPedidoInterno = row[48].ToString(),
                    ZonaVenta = row[49].ToString(),
                    RutaVenta = row[50].ToString(),
                    InformacionAdicionalEmisor = row[51].ToString(),
                    FechaEmision = row[52].ToString(),
                    RNCComprador = row[53].ToString(),
                    IdentificadorExtranjero = row[54].ToString(),
                    RazonSocialComprador = row[55].ToString(),
                    ContactoComprador = row[56].ToString(),
                    CorreoComprador = row[57].ToString(),
                    DireccionComprador = row[58].ToString(),
                    MunicipioComprador = row[59].ToString(),
                    ProvinciaComprador = row[60].ToString(),
                    PaisComprador = row[61].ToString(),
                    FechaEntrega = row[62].ToString(),
                    ContactoEntrega = row[63].ToString(),
                    DireccionEntrega = row[64].ToString(),
                    TelefonoAdicional = row[65].ToString(),
                    FechaOrdenCompra = row[66].ToString(),
                    NumeroOrdenCompra = row[67].ToString(),
                    CodigoInternoComprador = row[68].ToString(),
                    ResponsablePago = row[69].ToString(),
                    InformacionAdicionalComprador = row[70].ToString(),
                    FechaEmbarque = row[71].ToString(),
                    NumeroEmbarque = row[72].ToString(),
                    NumeroContenedor = row[73].ToString(),
                    NumeroReferencia = row[74].ToString(),
                    NombrePuertoEmbarque = row[75].ToString(),
                    CondicionesEntrega = row[76].ToString(),
                    TotalFob = row[77].ToString(),
                    Seguro = row[78].ToString(),
                    Flete = row[79].ToString(),
                    OtrosGastos = row[80].ToString(),
                    TotalCif = row[81].ToString(),
                    RegimenAduanero = row[82].ToString(),
                    NombrePuertoSalida = row[83].ToString(),
                    NombrePuertoDesembarque = row[84].ToString(),
                    PesoBruto = row[85].ToString(),
                    PesoNeto = row[86].ToString(),
                    UnidadPesoBruto = row[87].ToString(),
                    UnidadPesoNeto = row[88].ToString(),
                    CantidadBulto = row[89].ToString(),
                    UnidadBulto = row[90].ToString(),
                    VolumenBulto = row[91].ToString(),
                    UnidadVolumen = row[92].ToString(),
                    ViaTransporte = row[93].ToString(),
                    PaisOrigen = row[94].ToString(),
                    DireccionDestino = row[95].ToString(),
                    PaisDestino = row[96].ToString(),
                    RNCIdentificacionCompaniaTransportista = row[97].ToString(),
                    NombreCompaniaTransportista = row[98].ToString(),
                    NumeroViaje = row[99].ToString(),
                    Conductor = row[100].ToString(),
                    DocumentoTransporte = row[101].ToString(),
                    Ficha = row[102].ToString(),
                    Placa = row[103].ToString(),
                    RutaTransporte = row[104].ToString(),
                    ZonaTransporte = row[105].ToString(),
                    NumeroAlbaran = row[106].ToString(),
                    MontoGravadoTotal = row[107].ToString(),
                    MontoGravadoI1 = row[108].ToString(),
                    MontoGravadoI2 = row[109].ToString(),
                    MontoGravadoI3 = row[110].ToString(),
                    MontoExento = row[111].ToString(),
                    ITBIS1 = row[112].ToString(),
                    ITBIS2 = row[113].ToString(),
                    ITBIS3 = row[114].ToString(),
                    TotalITBIS = row[115].ToString(),
                    TotalITBIS1 = row[116].ToString(),
                    TotalITBIS2 = row[117].ToString(),
                    TotalITBIS3 = row[118].ToString(),
                    MontoImpuestoAdicional = row[119].ToString(),
                    //hasta aqui esta bien

                    TipoImpuesto1 = row[120].ToString(),
                    TasaImpuestoAdicional1 = row[121].ToString(),
                    MontoImpuestoSelectivoConsumoEspecifico1 = row[122].ToString(),
                    MontoImpuestoSelectivoConsumoAdvalorem1 = row[123].ToString(),
                    OtrosImpuestosAdicionales1 = row[124].ToString(),

                    TipoImpuesto2 = row[125].ToString(),
                    TasaImpuestoAdicional2 = row[126].ToString(),
                    MontoImpuestoSelectivoConsumoEspecifico2 = row[127].ToString(),
                    MontoImpuestoSelectivoConsumoAdvalorem2 = row[128].ToString(),
                    OtrosImpuestosAdicionales2 = row[129].ToString(),

                    TipoImpuesto3 = row[130].ToString(),
                    TasaImpuestoAdicional3 = row[131].ToString(),
                    MontoImpuestoSelectivoConsumoEspecifico3 = row[132].ToString(),
                    MontoImpuestoSelectivoConsumoAdvalorem3 = row[133].ToString(),
                    OtrosImpuestosAdicionales3 = row[134].ToString(),

                    TipoImpuesto4 = row[135].ToString(),
                    TasaImpuestoAdicional4 = row[136].ToString(),
                    MontoImpuestoSelectivoConsumoEspecifico4 = row[137].ToString(),
                    MontoImpuestoSelectivoConsumoAdvalorem4 = row[138].ToString(),
                    OtrosImpuestosAdicionales4 = row[139].ToString(),


                    MontoTotal = row[140].ToString(),
                    MontoNoFacturable = row[141].ToString(),
                    MontoPeriodo = row[142].ToString(),
                    SaldoAnterior = row[143].ToString(),
                    MontoAvancePago = row[144].ToString(),
                    ValorPagar = row[145].ToString(),
                    TotalITBISRetenido = row[146].ToString(),
                    TotalISRRetencion = row[147].ToString(),
                    TotalITBISPercepcion = row[148].ToString(),
                    TotalISRPercepcion = row[149].ToString(),
                    TipoMoneda = row[150].ToString(),
                    TipoCambio = row[151].ToString(),

                    MontoGravadoTotalOtraMoneda = row[152].ToString(),
                    MontoGravado1OtraMoneda = row[153].ToString(),
                    MontoGravado2OtraMoneda = row[154].ToString(),
                    MontoGravado3OtraMoneda = row[155].ToString(),
                    MontoExentoOtraMoneda = row[156].ToString(),

                    TotalITBISOtraMoneda = row[157].ToString(),
                    TotalITBIS1OtraMoneda = row[158].ToString(),
                    TotalITBIS2OtraMoneda = row[159].ToString(),
                    TotalITBIS3OtraMoneda = row[160].ToString(),
                    MontoImpuestoAdicionalOtraMoneda = row[161].ToString(),

                    TipoImpuestoOtraMoneda1 = row[162].ToString(),
                    TasaImpuestoAdicionalOtraMoneda1 = row[163].ToString(),
                    MontoImpuestoSelectivoConsumoEspecificoOtraMoneda1 = row[164].ToString(),
                    MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda1 = row[165].ToString(),
                    OtrosImpuestosAdicionalesOtraMoneda1 = row[166].ToString(),

                    TipoImpuestoOtraMoneda2 = row[167].ToString(),
                    TasaImpuestoAdicionalOtraMoneda2 = row[168].ToString(), //hasta aqui
                    MontoImpuestoSelectivoConsumoEspecificoOtraMoneda2 = row[169].ToString(),
                    MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda2 = row[170].ToString(),
                    OtrosImpuestosAdicionalesOtraMoneda2 = row[171].ToString(),

                    TipoImpuestoOtraMoneda3 = row[172].ToString(),
                    TasaImpuestoAdicionalOtraMoneda3 = row[173].ToString(),
                    MontoImpuestoSelectivoConsumoEspecificoOtraMoneda3 = row[174].ToString(),
                    MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda3 = row[175].ToString(),
                    OtrosImpuestosAdicionalesOtraMoneda3 = row[176].ToString(),

                    TipoImpuestoOtraMoneda4 = row[177].ToString(),
                    TasaImpuestoAdicionalOtraMoneda4 = row[178].ToString(),
                    MontoImpuestoSelectivoConsumoEspecificoOtraMoneda4 = row[179].ToString(),
                    MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda4 = row[180].ToString(),
                    OtrosImpuestosAdicionalesOtraMoneda4 = row[181].ToString(),

                    MontoTotalOtraMoneda = row[182].ToString(),

                    //Campos despues del detalle 

                    NumeroSubTotal = row[5143].ToString(),
                    DescripcionSubtotal = row[5144].ToString(),
                    OrdenPie = row[5145].ToString(),
                    SubTotalMontoGravadoTotal = row[5146].ToString(),
                    SubTotalMontoGravadoI1 = row[5147].ToString(),
                    SubTotalMontoGravadoI2 = row[5148].ToString(),
                    SubTotalMontoGravadoI3 = row[5149].ToString(),
                    SubTotaITBIS = row[5150].ToString(),
                    SubTotaITBIS1 = row[5151].ToString(),
                    SubTotaITBIS2 = row[5152].ToString(),
                    SubTotaITBIS3 = row[5153].ToString(),
                    SubTotalImpuestoAdicional = row[5154].ToString(),
                    SubTotalExento = row[5155].ToString(),
                    MontoSubTotal = row[5156].ToString(),
                    Lineas = row[5157].ToString(),

                    NumeroLineaDoR1 = row[5158].ToString(),
                    TipoAjuste1 = row[5159].ToString(),
                    IndicadorNorma10071 = row[5160].ToString(),
                    DescripcionDescuentooRecargo1 = row[5161].ToString(),
                    TipoValor1 = row[5162].ToString(),
                    ValorDescuentooRecargo = row[5163].ToString(),
                    MontoDescuentooRecargo1 = row[5164].ToString(),
                    MontoDescuentooRecargoOtraMoneda1 = row[5165].ToString(),
                    IndicadorFacturacionDescuentooRecargo1 = row[5166].ToString(),

                    NumeroLineaDoR2 = row[5167].ToString(),
                    TipoAjuste2 = row[5168].ToString(),
                    IndicadorNorma10072 = row[5169].ToString(),
                    DescripcionDescuentooRecargo2 = row[5170].ToString(),
                    TipoValor2 = row[5171].ToString(),
                    ValorDescuentooRecargo2 = row[5172].ToString(),
                    MontoDescuentooRecargo2 = row[5173].ToString(),
                    MontoDescuentooRecargoOtraMoneda2 = row[5174].ToString(),
                    IndicadorFacturacionDescuentooRecargo2 = row[5175].ToString(),

                    PaginaNo1 = row[5176].ToString(),
                    NoLineaDesde1 = row[5177].ToString(),
                    NoLineaHasta1 = row[5178].ToString(),
                    SubtotalMontoGravadoPagina1 = row[5179].ToString(),
                    SubtotalMontoGravado1Pagina1 = row[5180].ToString(),
                    SubtotalMontoGravado2Pagina1 = row[5181].ToString(),
                    SubtotalMontoGravado3Pagina1 = row[5182].ToString(),
                    SubtotalExentoPagina1 = row[5183].ToString(),
                    SubtotalItbisPagina1 = row[5184].ToString(),
                    SubtotalItbis1Pagina1 = row[5185].ToString(),
                    SubtotalItbis2Pagina1 = row[5186].ToString(),
                    SubtotalItbis3Pagina1 = row[5187].ToString(),
                    SubtotalImpuestoAdicionalPagina1 = row[5188].ToString(),
                    SubtotalImpuestoAdicionalPaginaTabla1 = row[5189].ToString(),
                    SubtotalImpuestoSelectivoConsumoEspecificoPagina1 = row[5190].ToString(),
                    SubtotalOtrosImpuesto1 = row[5191].ToString(),
                    MontoSubtotalPagina1 = row[5192].ToString(),
                    SubtotalMontoNoFacturablePagina1 = row[5193].ToString(),

                    PaginaNo2 = row[5194].ToString(),
                    NoLineaDesde2 = row[5195].ToString(),
                    NoLineaHasta2 = row[5196].ToString(),
                    SubtotalMontoGravadoPagina2 = row[5197].ToString(),
                    SubtotalMontoGravado1Pagina2 = row[5198].ToString(),
                    SubtotalMontoGravado2Pagina2 = row[5199].ToString(),
                    SubtotalMontoGravado3Pagina2 = row[5200].ToString(),
                    SubtotalExentoPagina2 = row[5201].ToString(),
                    SubtotalItbisPagina2 = row[5202].ToString(),
                    SubtotalItbis1Pagina2 = row[5203].ToString(),
                    SubtotalItbis2Pagina2 = row[5204].ToString(),
                    SubtotalItbis3Pagina2 = row[5205].ToString(),
                    SubtotalImpuestoAdicionalPagina2 = row[5206].ToString(),
                    // SubtotalImpuestoAdicionalPaginaTabla2 = row[5207].ToString(),
                    SubtotalImpuestoSelectivoConsumoEspecificoPagina2 = row[5207].ToString(),
                    SubtotalOtrosImpuesto2 = row[5208].ToString(),
                    MontoSubtotalPagina2 = row[5209].ToString(),
                    SubtotalMontoNoFacturablePagina2 = row[5210].ToString(),

                    NCFModificado = row[5211].ToString(),
                    RNCOtroContribuyente = row[5212].ToString(),
                    FechaNCFModificado = row[5213].ToString(),
                    CodigoModificacion = row[5214].ToString(),
                    RazonModificacion = row[5215].ToString(),

                };

                orden.Detalle = new List<Items>();
                int columnasInicio = 183;
                int columnasPorItem = 80;

                for (int i = 0; i < 62; i++)
                {
                    orden.Detalle.Add(
                        new Items
                        {
                            NumeroLinea = row[columnasInicio].ToString(),
                            TipoCodigo1 = row[columnasInicio + 1].ToString(),
                            CodigoItem1 = row[columnasInicio + 2].ToString(),
                            TipoCodigo2 = row[columnasInicio + 3].ToString(),
                            CodigoItem2 = row[columnasInicio + 4].ToString(),
                            TipoCodigo3 = row[columnasInicio + 5].ToString(),
                            CodigoItem3 = row[columnasInicio + 6].ToString(),
                            TipoCodigo4 = row[columnasInicio + 7].ToString(),
                            CodigoItem4 = row[columnasInicio + 8].ToString(),
                            TipoCodigo5 = row[columnasInicio + 9].ToString(),
                            CodigoItem5 = row[columnasInicio + 10].ToString(),
                            IndicadorFacturacion = row[columnasInicio + 11].ToString(),
                            IndicadorAgenteRetencionoPercepcion = row[columnasInicio + 12].ToString(),
                            MontoITBISRetenido = row[columnasInicio + 13].ToString(),
                            MontoISRRetenido = row[columnasInicio + 14].ToString(),
                            NombreItem = row[columnasInicio + 15].ToString(),
                            IndicadorBienoServicio = row[columnasInicio + 16].ToString(),
                            DescripcionItem = row[columnasInicio + 17].ToString(),
                            CantidadItem = row[columnasInicio + 18].ToString(),
                            UnidadMedida = row[columnasInicio + 19].ToString(),
                            CantidadReferencia = row[columnasInicio + 20].ToString(),
                            UnidadReferencia = row[columnasInicio + 21].ToString(),
                            Subcantidad1 = row[columnasInicio + 22].ToString(),
                            CodigoSubcantidad1 = row[columnasInicio + 23].ToString(),
                            Subcantidad2 = row[columnasInicio + 24].ToString(),
                            CodigoSubcantidad2 = row[columnasInicio + 25].ToString(),
                            Subcantidad3 = row[columnasInicio + 26].ToString(),
                            CodigoSubcantidad3 = row[columnasInicio + 27].ToString(),
                            Subcantidad4 = row[columnasInicio + 28].ToString(),
                            CodigoSubcantidad4 = row[columnasInicio + 29].ToString(),
                            Subcantidad5 = row[columnasInicio + 30].ToString(),
                            CodigoSubcantidad5 = row[columnasInicio + 31].ToString(),
                            GradosAlcohol = row[columnasInicio + 32].ToString(),
                            PrecioUnitarioReferencia = row[columnasInicio + 33].ToString(),
                            FechaElaboracion = row[columnasInicio + 34].ToString(),
                            FechaVencimientoItem = row[columnasInicio + 35].ToString(),
                            PesoNetoKilogramo = row[columnasInicio + 36].ToString(),
                            PesoNetoMineria = row[columnasInicio + 37].ToString(),
                            TipoAfiliacion = row[columnasInicio + 38].ToString(),
                            Liquidacion = row[columnasInicio + 39].ToString(),
                            PrecioUnitarioItem = row[columnasInicio + 40].ToString(),
                            DescuentoMonto = row[columnasInicio + 41].ToString(),
                            TipoSubDescuento1 = row[columnasInicio + 42].ToString(),
                            SubDescuentoPorcentaje1 = row[columnasInicio + 43].ToString(),
                            MontoSubDescuento1 = row[columnasInicio + 44].ToString(),
                            TipoSubDescuento2 = row[columnasInicio + 45].ToString(),
                            SubDescuentoPorcentaje2 = row[columnasInicio + 46].ToString(),
                            MontoSubDescuento2 = row[columnasInicio + 47].ToString(),
                            TipoSubDescuento3 = row[columnasInicio + 48].ToString(),
                            SubDescuentoPorcentaje3 = row[columnasInicio + 49].ToString(),
                            MontoSubDescuento3 = row[columnasInicio + 50].ToString(),
                            TipoSubDescuento4 = row[columnasInicio + 51].ToString(),
                            SubDescuentoPorcentaje4 = row[columnasInicio + 52].ToString(),
                            MontoSubDescuento4 = row[columnasInicio + 53].ToString(),
                            TipoSubDescuento5 = row[columnasInicio + 54].ToString(),
                            SubDescuentoPorcentaje5 = row[columnasInicio + 55].ToString(),
                            MontoSubDescuento5 = row[columnasInicio + 56].ToString(),
                            RecargoMonto = row[columnasInicio + 57].ToString(),
                            TipoSubRecargo1 = row[columnasInicio + 58].ToString(),
                            SubRecargoPorcentaje1 = row[columnasInicio + 59].ToString(),
                            MontosubRecargo1 = row[columnasInicio + 60].ToString(),
                            TipoSubRecargo2 = row[columnasInicio + 61].ToString(),
                            SubRecargoPorcentaje2 = row[columnasInicio + 62].ToString(),
                            MontosubRecargo2 = row[columnasInicio + 63].ToString(),
                            TipoSubRecargo3 = row[columnasInicio + 64].ToString(),
                            SubRecargoPorcentaje3 = row[columnasInicio + 65].ToString(),
                            MontosubRecargo3 = row[columnasInicio + 66].ToString(),
                            TipoSubRecargo4 = row[columnasInicio + 67].ToString(),
                            SubRecargoPorcentaje4 = row[columnasInicio + 68].ToString(),
                            MontosubRecargo4 = row[columnasInicio + 69].ToString(),
                            TipoSubRecargo5 = row[columnasInicio + 70].ToString(),
                            SubRecargoPorcentaje5 = row[columnasInicio + 71].ToString(),
                            MontosubRecargo5 = row[columnasInicio + 72].ToString(),
                            TipoImpuesto1 = row[columnasInicio + 73].ToString(),
                            TipoImpuesto2 = row[columnasInicio + 74].ToString(),
                            PrecioOtraMoneda = row[columnasInicio + 75].ToString(),
                            DescuentoOtraMoneda = row[columnasInicio + 76].ToString(),
                            RecargoOtraMoneda = row[columnasInicio + 77].ToString(),
                            MontoItemOtraMoneda = row[columnasInicio + 78].ToString(),
                            MontoItem = row[columnasInicio + 79].ToString(),
                        });

                    columnasInicio += columnasPorItem; // Aumentar el índice de columnas para el siguiente item
                };

                // Agregar la orden a la lista
                ordenes.Add(orden);

            }


            return ordenes;
        }

    }



}


