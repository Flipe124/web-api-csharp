using System.Text.Json.Serialization;

namespace Umfg.Web.Api.ProgramacaoIV._27._04._2023.Entities
{
    public sealed class Produto
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set;}

        [JsonPropertyName("codigoBarra")]
        public string CodigoBarra { get; set;}

        [JsonPropertyName("descricao")]
        public string Descricao { get; set;}

        [JsonPropertyName("valor")]
        public decimal Valor { get; set;}

        public Produto() 
        {
            Id = Guid.NewGuid();
        }
    }
}
