namespace Ayni.Configuracion.Aplication.Dto
{
    /*
     * Atributos que seran expuestos
     */
    public class MonedaDto
    {
        public int moneda_id { get; set; }
        public string descripcion { get; set; }
        public string abreviatura { get; set; }
        public string simbolo { get; set; }
        public bool estado { get; set; }
        public string usuario_reg { get; set; }
        public DateTime? fecha_reg { get; set; }
        public string usuario_act { get; set; }
        public DateTime? fecha_act { get; set; }
    }
}