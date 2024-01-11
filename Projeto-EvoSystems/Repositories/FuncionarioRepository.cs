using Projeto_EvoSystems.Data;
using Projeto_EvoSystems.Interfaces;
using Projeto_EvoSystems.Models;

namespace Projeto_EvoSystems.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DataContext _dataContext;

        public FuncionarioRepository() 
        {
            _dataContext = new DataContext();
        }
        public void Delete(int id)
        {
            try
            {
                Funcionario funcionarioBuscado = _dataContext.Funcionarios!.Find(id)!;
                if (funcionarioBuscado != null)
                {
                    _dataContext.Funcionarios.Remove(funcionarioBuscado);
                }

                _dataContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Funcionario> GetAll()
        {
            try
            {
                return _dataContext.Funcionarios.Select(f => new Funcionario { 
                Id = f.Id,
                Nome = f.Nome,
                Foto = f.Foto,
                RG = f.RG,
                IdDepartamento = f.IdDepartamento,
                Departamento = new Departamento

                {
                    Id = f.Id,
                    Nome = f.Departamento!.Nome
                }
                }).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Funcionario GetById(int id)
        {
            try
            {
                return _dataContext.Funcionarios!.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Post(Funcionario funcionario)
        {
            try
            {
                _dataContext.Funcionarios!.Add(funcionario);
                _dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(int id, Funcionario funcionario)
        {
            try
            {
                Funcionario funcionarioBuscado = _dataContext.Funcionarios!.Find(id)!;
                if (funcionarioBuscado != null)
                {
                    funcionarioBuscado.Id = funcionario.Id;
                    funcionarioBuscado.Nome = funcionario.Nome;
                    funcionarioBuscado.Foto = funcionario.Foto;
                    funcionarioBuscado.RG = funcionario.RG;
                    funcionarioBuscado.IdDepartamento = funcionario.IdDepartamento;
                }
                _dataContext.Funcionarios.Update(funcionarioBuscado!);
                _dataContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
