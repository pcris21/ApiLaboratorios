using System;
using System.Collections.Generic;
using System.Linq;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;
using Dasa.Laboratorios.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Dasa.Laboratorios.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntidade> : IBaseRepositorio<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly ContextoLaboratorioBD _contexto;
        protected readonly DbSet<TEntidade> _entidade;
        public BaseRepositorio(ContextoLaboratorioBD contexto)
        {
           // _entidade = contexto.Set<TEntidade>();
            _contexto = contexto;
        }
        public void Adicionar(TEntidade entidade)
        {
           // _entidade = contexto.Set<TEntity>();

            throw new NotImplementedException();
        }

        public void Editar(TEntidade entidade, Guid id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

      

        public void Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
