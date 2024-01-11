using Projeto_EvoSystems.Data;
using Projeto_EvoSystems.Interfaces;
using Projeto_EvoSystems.Models;

namespace Projeto_EvoSystems.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly DataContext _dataContext;

        public DepartamentoRepository()
        {
            _dataContext = new DataContext();
        }
        public void Delete(int id)
        {
            try
            {
                Departamento departmentSearched = _dataContext.Departamentos!.Find(id)!;
                if (departmentSearched != null) {
                    _dataContext.Departamentos.Remove(departmentSearched);
                }
                _dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Departamento> GetAll()
        {
            try
            {
                return _dataContext.Departamentos!.ToList();
            }
            catch (Exception)
            {

                throw;
            };
        }

        public Departamento GetById(int id)
        {
            try
            {
                return _dataContext.Departamentos!.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Departamento departamento)
        {
            try
            {
                _dataContext.Departamentos!.Add(departamento);
                _dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(int id, Departamento departamento)
        {
            try
            {
                Departamento departmentSearched = _dataContext.Departamentos!.Find(id)!;
                if (departmentSearched != null)
                {
                   departmentSearched.Id = departamento.Id;
                   departmentSearched.Nome = departamento.Nome;
                   departmentSearched.Sigla = departamento.Sigla;
                }

                _dataContext.Departamentos.Update(departmentSearched!);
                _dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
