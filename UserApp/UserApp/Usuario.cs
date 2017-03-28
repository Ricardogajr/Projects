using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
