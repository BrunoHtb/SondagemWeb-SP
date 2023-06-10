using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace sondagemSP.Models
{
    [Table("cadastro")]
    public class Cadastro
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("data_cadastro")]
        public string Data_Cadastro { get; set; }

        [Column("latitude")]
        public string Latitude { get; set; }

        [Column("longitude")]
        public string Longitude { get; set; }

        [Column("latitude_prevista")]
        public string Latitude_Prevista { get; set; }

        [Column("longitude_prevista")]
        public string Longitude_Prevista { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("rodovia")]
        public string Rodovia { get; set; }

        [Column("km")]
        public string Km { get; set; }

        [Column("metro")]
        public string Metro { get; set; }

        [Column("trecho")]
        public string Trecho { get; set; }

        [Column("subtrecho")]
        [DefaultValue("")]
        public string Subtrecho { get; set; }

        [Column("fotos")]
        [DefaultValue(";;;;")]
        [DataType(DataType.Text)]
        public string Fotos { get; set; }

        [Column("camadas")]
        [DefaultValue(";;;")]
        [DataType(DataType.Text)]
        public string Camadas { get; set; }

        [Column("espessuras")]
        [DataType(DataType.Text)]
        public string Espessuras { get; set; }

        [Column("observacao")]
        [DefaultValue("")]
        public string Observacao { get; set; }

        [Column("area")]
        public string Area { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("entrega")]
        public string Entrega { get; set; }

        [Column("regional")]
        public string Regional { get; set; }

        [Column("estaca")]
        public string Estaca { get; set; }

        [Column("latitude_local")]
        public string Latitude_Local { get; set; }

        [Column("longitude_local")]
        public string Longitude_Local { get; set; }

        [Column("observacao_lado")]
        public string Observacao_Lado { get; set; }

        [Column("data_modificacao")]
        public string Data_Modificacao { get; set; }

        /* 
         *****************************************************************************
                                    VARIAVEIS NÃO MAPEADAS
        ****************************************************************************
         */
        [NotMapped]
        public string? Camada1 { get; set; }
        [NotMapped]
        public string? Camada2 { get; set; }
        [NotMapped]
        public string? Camada3 { get; set; }
        [NotMapped]
        public string? Camada4 { get; set; }
        [NotMapped]
        public string? Espessura1 { get; set; }
        [NotMapped]
        public string? Espessura2 { get; set; }
        [NotMapped]
        public string? Espessura3 { get; set; }
        [NotMapped]
        public string? Espessura4 { get; set; }

    }
}
