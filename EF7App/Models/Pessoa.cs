using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7App.Models
{
    public class Pessoa
    {
        [Key]
        public int idPessoa { get; set; }


        public string nome { get; set; }

        public string telefone { get; set; }

    }
}
