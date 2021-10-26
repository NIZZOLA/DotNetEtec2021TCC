using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tcc2021.Models
{
    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        [MaxLength(10)]
        public string Senha { get; set; }
        [MaxLength(15)]
        public string Telefone { get; set; }
        [MaxLength(10)]
        public string Cep { get; set; }
        [MaxLength(40)]
        public string Cidade { get; set; }
        [MaxLength(2)]
        public string Estado { get; set; }
        [MaxLength(40)]
        public string Endereco { get; set; }
        [MaxLength(40)]
        public string Bairro { get; set; }

        public bool Bloqueado { get; set; }
}
}
