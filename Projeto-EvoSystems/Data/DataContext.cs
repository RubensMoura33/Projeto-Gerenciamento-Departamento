using Microsoft.EntityFrameworkCore;
using Projeto_EvoSystems.Models;

namespace Projeto_EvoSystems.Data
{
    public class DataContext: DbContext
    {
            public DbSet<Departamento>? Departamentos { get; set; }
            public DbSet<Funcionario>? Funcionarios { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=R4ULM1LGR4U\\SQLEXPRESSS; DataBase=Projeto-EvoSystems; User Id=sa; Pwd = Binho$2022; TrustServerCertificate=True;");
                base.OnConfiguring(optionsBuilder);
            }

        }
   
}
