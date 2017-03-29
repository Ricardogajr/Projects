using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet
{
    public class Controle
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public virtual Cliente Cliente { get; set; }
        [Required]
        public int ClienteID { get; set; }
        [Required]
        public DateTime Horaini { get; set; }
        [Required]
        public DateTime Horafim { get; set; }
        [Required]
        public DateTime Desconto { get; set; }
        [Required]
        public DateTime Translado { get; set; }
        [Required]
        public DateTime Total { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
