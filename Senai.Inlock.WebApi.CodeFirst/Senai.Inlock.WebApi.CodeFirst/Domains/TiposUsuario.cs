using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        //Define que sera uma chave primaria
        [Key]
        //Define o auto-incremento
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoUsuario { get; set; }
        
        //Define o tipo do dado
        [Column(TypeName = "VARCHAR (255)")]
        //Define que a propriedade é obrigatoria
        [Required(ErrorMessage = "O titulo do tipo usuario é obrigatoria")]
        public string Titulo { get; set; }
    }
}
