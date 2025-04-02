using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirJson
{
    public class Items
    {
        public int NumeroLinea { get; set; }
        public List<TipoCodigo> TipoCodigo { get; set; }
        public List<CodigoItem> CodigoItem { get; set; }
        public bool IndicadorFacturacion { get; set; }
        public bool IndicadorAgenteRetencionoPercepcion { get; set; }
        public decimal MontoITBISRetenido { get; set; }
        public decimal MontoISRRetenido { get; set; }
        public string NombreItem { get; set; }
        public bool IndicadorBienoServicio { get; set; }
        public string DescripcionItem { get; set; }
        public decimal CantidadItem { get; set; }
        public string UnidadMedida { get; set; }
        public decimal CantidadReferencia { get; set; }
        public string UnidadReferencia { get; set; }
        public List<Subcantidad> Subcantidades { get; set; }
        public decimal GradosAlcohol { get; set; }
        public decimal PrecioUnitarioReferencia { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaVencimientoItem { get; set; }
        public decimal PesoNetoKilogramo { get; set; }
        public decimal PesoNetoMineria { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal Liquidacion { get; set; }
        public decimal PrecioUnitarioItem { get; set; }
        public decimal DescuentoMonto { get; set; }
        public List<SubDescuento> SubDescuentos { get; set; }
        public decimal RecargoMonto { get; set; }
        public List<SubRecargo> SubRecargos { get; set; }
        public List<TipoImpuesto> TiposImpuesto { get; set; }
        public decimal PrecioOtraMoneda { get; set; }
        public decimal DescuentoOtraMoneda { get; set; }
        public decimal RecargoOtraMoneda { get; set; }
        public decimal MontoItemOtraMoneda { get; set; }
        public decimal MontoItem { get; set; }
    }

    public class TipoCodigo
    {
        public string Tipo { get; set; }
        public string Codigo { get; set; }
    }

    public class CodigoItem
    {
        public string Codigo { get; set; }
    }

    public class Subcantidad
    {
        public string Codigo { get; set; }
        public decimal SubcantidadValor { get; set; }
    }

    public class SubDescuento
    {
        public string Tipo { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Monto { get; set; }
    }

    public class SubRecargo
    {
        public string Tipo { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Monto { get; set; }
    }

    public class TipoImpuesto
    {
        public string Tipo { get; set; } 
        public decimal Monto { get; set; }
    }
}