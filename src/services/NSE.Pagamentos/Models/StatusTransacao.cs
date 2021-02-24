namespace NSE.Pagamentos.Models
{
    public enum StatusTransacao
    {
        Autorizado = 1,
        Pago,
        Negado,
        Estornado,
        Cancelado
    }
}