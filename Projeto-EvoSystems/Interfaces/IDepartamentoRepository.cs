using Projeto_EvoSystems.Models;

namespace Projeto_EvoSystems.Interfaces
{
    public interface IDepartamentoRepository
    {
        void Post(Departamento departamento);
        void Delete(int id);
        List<Departamento> GetAll();
        Departamento GetById(int id);
        void Update(int id, Departamento departamento);
    }
}
