namespace pizza_models
{
    public class RetornoPedidoModel
    {
        public string Cliente { get; set; }
        public string Tamanho { get; set; }
        public decimal Valor { get; set; }
        public int TempoDuracao { get; set; }
        public string Sabor { get; set; }
    }
}