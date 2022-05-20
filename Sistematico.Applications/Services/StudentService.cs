using Sistematico.Applications.Interfaces;
using Sistematico.Domain.Entities;
using Sistematico.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico.Applications.Services
{
    public class StudentService : IStudentService
    {
        private IStudentModel studentModel;
        public StudentService(IStudentModel studentModel)
        {
            this.studentModel = studentModel;
        }
        public void Create(Estudiante t)
        {
            try
            {
                studentModel.Create(t);
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
                return studentModel.Delete(t);
            }
            catch
            {
                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                return studentModel.FindById(id);
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
                return studentModel.FindByName(name);
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
                return studentModel.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public decimal GetAverageByStudent(Estudiante estudiante)
        {
            return studentModel.GetAverageByStudent(estudiante);
        }

        public int Update(Estudiante t)
        {
            try
            {
                return studentModel.Update(t);
            }
            catch
            {
                throw;
            }
        }
    }
}
