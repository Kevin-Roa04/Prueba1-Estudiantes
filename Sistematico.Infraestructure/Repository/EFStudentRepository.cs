using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico.Infraestructure.Repository
{
    public class EFStudentRepository : IStudentModel
    {
        public IStudenDbContext studenDbContext;
        public EFStudentRepository(IStudenDbContext studenDbContext)
        {
            this.studenDbContext = studenDbContext;
        }

        public void Create(Estudiante t)
        {

            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("The object Student doesn't be null");
                }
                studenDbContext.Students.Add(t);
                studenDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentException("The object Student isn't be a null");
                }
                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                studenDbContext.Students.Remove(t);
                studenDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"The Id: {id} doesn't less or equals than cero");
                }
                List<Estudiante> estudiantes = GetAll();
                return estudiantes.Find(x => x.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> FindByName(string name)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new Exception($"The name: {name} doesn't have the correct form");
                }
                return studenDbContext.Students.Where<Estudiante>(x => x.Nombres.Contains(name)).ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<Estudiante> GetAll()
        {
            try
            {
                return studenDbContext.Students.ToList();
            }
            catch
            {
                throw;
            }
        }
        public decimal GetAverageByStudent(Estudiante estudiante)
        {
            decimal promedio = 0;
            return promedio = (estudiante.Estadistica + estudiante.Matematica + estudiante.Programacion + estudiante.Contabilidad) / 4;
        }

        public int Update(Estudiante t)
        {
            try
            {
                if (t == null)
                {
                    throw new ArgumentNullException("The object Student doesn't be null");
                }
                Estudiante estudiante = FindById(t.Id);
                if (estudiante == null)
                {
                    throw new Exception($"The object with Id: {t.Id} don't exist");
                }
                studenDbContext.Students.Update(t);
                return studenDbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
