using System.ComponentModel.DataAnnotations;

namespace Escola
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public decimal NotaPrimeiroSemestre { get; set; }

        public decimal NotaSegundoSemestre { get; set; }

        public string NomeDoProfessor { get; set; }

        public int NumeroDaSala { get; set; }
    }
}
