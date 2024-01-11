using Projeto_EvoSystems.Models;

namespace Projeto_EvoSystems.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Post(Funcionario funcionario);
        void Delete(int id);
        List<Funcionario> GetAll();
        Funcionario GetById(int id);
        void Update(int id, Funcionario funcionario);

    }
}
