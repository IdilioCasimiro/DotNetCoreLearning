using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreLearning.Models
{
    public class Filme
    {
        public int ID { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [DisplayName("Género")]
        public string Genero { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Preco { get; set; }
    }
}
