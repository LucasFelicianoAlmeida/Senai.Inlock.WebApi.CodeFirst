using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Domains
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUsuario { get; set; }
        
        [Column(TypeName ="VARCHAR (150)")]
        [Required(ErrorMessage = "O email do usuario é obrigatorio!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column(TypeName = "VARCHAR (150)")]
        [Required(ErrorMessage = "A senha do usuario é obrigatoria")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "A senha deve ter no minimo 6 e no maximo 30 caracteres")]
        public string Senha { get; set; }

        public int IdTipoUsuario { get; set; }

        [ForeignKey]
        public TipoUsuario TipoUsuario { get; set; }
    }
}
