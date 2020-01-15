using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dasa.Laboratorios.Dominio.Repositorios
{
   public interface IUnitOfWork 
    {
       Task Commit();
    }
}
