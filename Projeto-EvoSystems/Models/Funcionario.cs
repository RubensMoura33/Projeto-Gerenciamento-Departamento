using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_EvoSystems.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Foto { get; set; }

        public string? RG { get; set; }

        public int IdDepartamento { get; set; }

        [ForeignKey("IdDepartamento")]
        public Departamento? Departamento { get; set; }
    }
}
