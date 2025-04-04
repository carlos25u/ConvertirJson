using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirJson.Mapeos
{
    public class OrdenECF
    {
        public string Orden { get; set; }
        public string CasoPrueba { get; set; }
        public string Version { get; set; }
        public string TipoeCF { get; set; }
        public string ENCF { get; set; }
        public string FechaVencimientoSecuencia { get; set; }
        public string IndicadorNotaCredito { get; set; }
        public string IndicadorEnvioDiferido { get; set; }
        public string IndicadorMontoGravado { get; set; }
        public string TipoIngresos { get; set; }
        public string TipoPago { get; set; }
        public string FechaLimitePago { get; set; }
        public string TerminoPago { get; set; }
        public string FormaPago1 { get; set; }
        public string MontoPago1 { get; set; }
        public string FormaPago2 { get; set; }
        public string MontoPago2 { get; set; }
        public string FormaPago3 { get; set; }
        public string MontoPago3 { get; set; }
        public string FormaPago4 { get; set; }
        public string MontoPago4 { get; set; }
        public string FormaPago5 { get; set; }
        public string MontoPago5 { get; set; }
        public string FormaPago6 { get; set; }
        public string MontoPago6 { get; set; }
        public string FormaPago7 { get; set; }
        public string MontoPago7 { get; set; }
        public string TipoCuentaPago { get; set; }
        public string NumeroCuentaPago { get; set; }
        public string BancoPago { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string TotalPaginas { get; set; }
        public string RNCEmisor { get; set; }
        public string RazonSocialEmisor { get; set; }
        public string NombreComercial { get; set; }
        public string Sucursal { get; set; }
        public string DireccionEmisor { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public string TelefonoEmisor1 { get; set; }
        public string TelefonoEmisor2 { get; set; }
        public string TelefonoEmisor3 { get; set; }
        public string CorreoEmisor { get; set; }
        public string WebSite { get; set; }
        public string ActividadEconomica { get; set; }
        public string CodigoVendedor { get; set; }
        public string NumeroFacturaInterna { get; set; }
        public string NumeroPedidoInterno { get; set; }
        public string ZonaVenta { get; set; }
        public string RutaVenta { get; set; }
        public string InformacionAdicionalEmisor { get; set; }
        public string FechaEmision { get; set; }
        public string RNCComprador { get; set; }
        public string IdentificadorExtranjero { get; set; }
        public string RazonSocialComprador { get; set; }
        public string ContactoComprador { get; set; }
        public string CorreoComprador { get; set; }
        public string DireccionComprador { get; set; }
        public string MunicipioComprador { get; set; }
        public string ProvinciaComprador { get; set; }
        public string PaisComprador { get; set; }
        public string FechaEntrega { get; set; }
        public string ContactoEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public string TelefonoAdicional { get; set; }
        public string FechaOrdenCompra { get; set; }
        public string NumeroOrdenCompra { get; set; }
        public string CodigoInternoComprador { get; set; }
        public string ResponsablePago { get; set; }
        public string InformacionAdicionalComprador { get; set; }
        public string FechaEmbarque { get; set; }
        public string NumeroEmbarque { get; set; }
        public string NumeroContenedor { get; set; }
        public string NumeroReferencia { get; set; }
        public string NombrePuertoEmbarque { get; set; }
        public string CondicionesEntrega { get; set; }
        public string TotalFob { get; set; }
        public string Seguro { get; set; }
        public string Flete { get; set; }
        public string OtrosGastos { get; set; }
        public string TotalCif { get; set; }
        public string RegimenAduanero { get; set; }
        public string NombrePuertoSalida { get; set; }
        public string NombrePuertoDesembarque { get; set; }
        public string PesoBruto { get; set; }
        public string PesoNeto { get; set; }
        public string UnidadPesoBruto { get; set; }
        public string UnidadPesoNeto { get; set; }
        public string CantidadBulto { get; set; }
        public string UnidadBulto { get; set; }
        public string VolumenBulto { get; set; }
        public string UnidadVolumen { get; set; }
        public string ViaTransporte { get; set; }
        public string PaisOrigen { get; set; }
        public string DireccionDestino { get; set; }
        public string PaisDestino { get; set; }
        public string RNCIdentificacionCompaniaTransportista { get; set; }
        public string NombreCompaniaTransportista { get; set; }
        public string NumeroViaje { get; set; }
        public string Conductor { get; set; }
        public string DocumentoTransporte { get; set; }
        public string Ficha { get; set; }
        public string Placa { get; set; }
        public string RutaTransporte { get; set; }
        public string ZonaTransporte { get; set; }
        public string NumeroAlbaran { get; set; }
        public string MontoGravadoTotal { get; set; }
        public string MontoGravadoI1 { get; set; }
        public string MontoGravadoI2 { get; set; }
        public string MontoGravadoI3 { get; set; }
        public string MontoExento { get; set; }
        public string ITBIS1 { get; set; }
        public string ITBIS2 { get; set; }
        public string ITBIS3 { get; set; }
        public string TotalITBIS { get; set; }
        public string TotalITBIS1 { get; set; }
        public string TotalITBIS2 { get; set; }
        public string TotalITBIS3 { get; set; }
        public string MontoImpuestoAdicional { get; set; }


        public string TipoImpuesto1 { get; set; }
        public string TasaImpuestoAdicional1 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecifico1 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvalorem1 { get; set; }
        public string OtrosImpuestosAdicionales1 { get; set; }

        public string TipoImpuesto2 { get; set; }
        public string TasaImpuestoAdicional2 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecifico2 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvalorem2 { get; set; }
        public string OtrosImpuestosAdicionales2 { get; set; }

        public string TipoImpuesto3 { get; set; }
        public string TasaImpuestoAdicional3 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecifico3 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvalorem3 { get; set; }
        public string OtrosImpuestosAdicionales3 { get; set; }

        public string TipoImpuesto4 { get; set; }
        public string TasaImpuestoAdicional4 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecifico4 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvalorem4 { get; set; }
        public string OtrosImpuestosAdicionales4 { get; set; }


        public string MontoTotal { get; set; }
        public string MontoNoFacturable { get; set; }
        public string MontoPeriodo { get; set; }
        public string SaldoAnterior { get; set; }
        public string MontoAvancePago { get; set; }
        public string ValorPagar { get; set; }
        public string TotalITBISRetenido { get; set; }
        public string TotalISRRetencion { get; set; }
        public string TotalITBISPercepcion { get; set; }
        public string TotalISRPercepcion { get; set; }
        public string TipoMoneda { get; set; }
        public string TipoCambio { get; set; }
        public string MontoGravadoTotalOtraMoneda { get; set; }
        public string MontoGravado1OtraMoneda { get; set; }
        public string MontoGravado2OtraMoneda { get; set; }
        public string MontoGravado3OtraMoneda { get; set; }
        public string MontoExentoOtraMoneda { get; set; }
        public string TotalITBISOtraMoneda { get; set; }
        public string TotalITBIS1OtraMoneda { get; set; }
        public string TotalITBIS2OtraMoneda { get; set; }
        public string TotalITBIS3OtraMoneda { get; set; }
        public string MontoImpuestoAdicionalOtraMoneda { get; set; }

        public string TipoImpuestoOtraMoneda1 { get; set; }
        public string TasaImpuestoAdicionalOtraMoneda1 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecificoOtraMoneda1 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda1 { get; set; }
        public string OtrosImpuestosAdicionalesOtraMoneda1 { get; set; }

        public string TipoImpuestoOtraMoneda2 { get; set; }
        public string TasaImpuestoAdicionalOtraMoneda2 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecificoOtraMoneda2 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda2 { get; set; }
        public string OtrosImpuestosAdicionalesOtraMoneda2 { get; set; }

        public string TipoImpuestoOtraMoneda3 { get; set; }
        public string TasaImpuestoAdicionalOtraMoneda3 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecificoOtraMoneda3 { get; set; }
        public string MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda3 { get; set; }
        public string OtrosImpuestosAdicionalesOtraMoneda3 { get; set; }
        public string TipoImpuestoOtraMoneda4 { get; set; }
        public string TasaImpuestoAdicionalOtraMoneda4 { get; set; }
        public string MontoImpuestoSelectivoConsumoEspecificoOtraMoneda4 { get; set; }

        public string MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda4 { get; set; }
        public string OtrosImpuestosAdicionalesOtraMoneda4 { get; set; }
        public string MontoTotalOtraMoneda { get; set; }

        //Numero de cada linea
        public List<Items> Detalle { get; set; } = new List<Items>();

        public string NumeroSubTotal { get; set; }
        public string DescripcionSubtotal { get; set; }
        public string OrdenPie { get; set; }
        public string SubTotalMontoGravadoTotal { get; set; }
        public string SubTotalMontoGravadoI1 { get; set; }
        public string SubTotalMontoGravadoI2 { get; set; }
        public string SubTotalMontoGravadoI3 { get; set; }
        public string SubTotaITBIS { get; set; }
        public string SubTotaITBIS1 { get; set; }
        public string SubTotaITBIS2 { get; set; }
        public string SubTotaITBIS3 { get; set; }
        public string SubTotalImpuestoAdicional { get; set; }
        public string SubTotalExento { get; set; }
        public string MontoSubTotal { get; set; }
        public string Lineas { get; set; }

        public string NumeroLineaDoR1 { get; set; }
        public string TipoAjuste1 { get; set; }
        public string IndicadorNorma10071 { get; set; }
        public string DescripcionDescuentooRecargo1 { get; set; }
        public string TipoValor1 { get; set; }
        public string ValorDescuentooRecargo { get; set; }
        public string MontoDescuentooRecargo1 { get; set; }
        public string MontoDescuentooRecargoOtraMoneda1 { get; set; }
        public string IndicadorFacturacionDescuentooRecargo1 { get; set; }

        public string NumeroLineaDoR2 { get; set; }
        public string TipoAjuste2 { get; set; }
        public string IndicadorNorma10072 { get; set; }
        public string DescripcionDescuentooRecargo2 { get; set; }
        public string TipoValor2 { get; set; }
        public string ValorDescuentooRecargo2 { get; set; }
        public string MontoDescuentooRecargo2 { get; set; }
        public string MontoDescuentooRecargoOtraMoneda2 { get; set; }
        public string IndicadorFacturacionDescuentooRecargo2 { get; set; }

        public string PaginaNo1 { get; set; }
        public string NoLineaDesde1 { get; set; }
        public string NoLineaHasta1 { get; set; }
        public string SubtotalMontoGravadoPagina1 { get; set; }
        public string SubtotalMontoGravado1Pagina1 { get; set; }
        public string SubtotalMontoGravado2Pagina1 { get; set; }
        public string SubtotalMontoGravado3Pagina1 { get; set; }
        public string SubtotalExentoPagina1 { get; set; }
        public string SubtotalItbisPagina1 { get; set; }
        public string SubtotalItbis1Pagina1 { get; set; }
        public string SubtotalItbis2Pagina1 { get; set; }
        public string SubtotalItbis3Pagina1 { get; set; }
        public string SubtotalImpuestoAdicionalPagina1 { get; set; }
        public string SubtotalImpuestoAdicionalPaginaTabla1 { get; set; }
        public string SubtotalImpuestoSelectivoConsumoEspecificoPagina1 { get; set; }
        public string SubtotalOtrosImpuesto1 { get; set; }
        public string MontoSubtotalPagina1 { get; set; }
        public string SubtotalMontoNoFacturablePagina1 { get; set; }

        public string PaginaNo2 { get; set; }
        public string NoLineaDesde2 { get; set; }
        public string NoLineaHasta2 { get; set; }
        public string SubtotalMontoGravadoPagina2 { get; set; }
        public string SubtotalMontoGravado1Pagina2 { get; set; }
        public string SubtotalMontoGravado2Pagina2 { get; set; }
        public string SubtotalMontoGravado3Pagina2 { get; set; }
        public string SubtotalExentoPagina2 { get; set; }
        public string SubtotalItbisPagina2 { get; set; }
        public string SubtotalItbis1Pagina2 { get; set; }
        public string SubtotalItbis2Pagina2 { get; set; }
        public string SubtotalItbis3Pagina2 { get; set; }
        public string SubtotalImpuestoAdicionalPagina2 { get; set; }

        //public string SubtotalImpuestoAdicionalPaginaTabla2 { get; set; }

        public string SubtotalImpuestoSelectivoConsumoEspecificoPagina2 { get; set; }
        public string SubtotalOtrosImpuesto2 { get; set; }
        public string MontoSubtotalPagina2 { get; set; }
        public string SubtotalMontoNoFacturablePagina2 { get; set; }

        public string NCFModificado { get; set; }
        public string RNCOtroContribuyente { get; set; }
        public string FechaNCFModificado { get; set; }
        public string CodigoModificacion { get; set; }
        public string RazonModificacion { get; set; }











    }
}
