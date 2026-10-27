using System.ComponentModel.DataAnnotations.Schema;

namespace mf_apis_web_services_full_manager.Models
{
    public class Consumo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public TipoCombustivel Tipo { get; set; }

        [Required]
        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Diesel,
        Etanol,
 
    }
}
