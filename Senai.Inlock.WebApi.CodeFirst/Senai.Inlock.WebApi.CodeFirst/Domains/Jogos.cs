using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("Jogos")]
    public class Jogos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdJogo { get; set; }

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "O nome do jogo é obrigatorio")]
        public string NomeJogo { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descriçao do jogo é obrigatorio")]
        public string Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "A data do jogo é obrigatoria")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "DECIMAL (18,2)")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O estudio do jogo é obrigatorio!")]
        public int IdEstudio { get; set; }

        public Estudios Estudio { get; set; }


    }
}
