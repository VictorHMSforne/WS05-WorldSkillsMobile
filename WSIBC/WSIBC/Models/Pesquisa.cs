using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace WSIBC.Models
{
    [Table("Pesquisa")]
    public class Pesquisa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Nome { get; set; }

        [NotNull]
        public int Pergunta1 { get; set; }

        [NotNull]
        public int Pergunta2 { get; set; }

        [NotNull]
        public int Pergunta3 { get; set; }

        [NotNull]
        public double Resultado { get; set; }

        public Pesquisa()
        {
            this.Id = 0;
            this.Nome = "";
            this.Pergunta1 = 0;
            this.Pergunta2 = 0;
            this.Pergunta3 = 0;
            this.Resultado = 0;
        }

    }
}
