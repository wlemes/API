using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Email.Models
{
    public class Usuario
    {
        [Key]
        public int idUsuario { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string NomeLogin { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TelefoneContato { get; set; }
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string IpCadastro { get; set; }
        public decimal? EspacoContratado { get; set; }
        public int? EspacoOcupado { get; set; }
        public string SituacaoCadastral { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
    }
}
