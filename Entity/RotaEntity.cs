namespace Entity
{
    public class RotaEntity
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public double Valor { get; set; }
        public int IdConexao { get; set; }
    }
}