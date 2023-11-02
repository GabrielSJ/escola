using System.ComponentModel.DataAnnotations;

namespace Escola
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        public decimal NotaPrimeiroSemestre { get; set; }

        public decimal NotaSegundoSemestre { get; set; }

        [StringLength(100)]
        public string NomeDoProfessor { get; set; }

        public int NumeroDaSala { get; set; }
    }
}
