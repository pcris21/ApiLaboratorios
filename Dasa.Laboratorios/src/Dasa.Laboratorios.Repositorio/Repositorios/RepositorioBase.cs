using System;
using System.Collections.Generic;
using System.Linq;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Repositorio.Contexto;
using Dasa.Laboratorios.Shared.Entidades;

namespace Dasa.Laboratorios.Repositorio.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly ContextoLaboratorioBD _contexto;
        public RepositorioBase(ContextoLaboratorioBD contexto)
        {
            _contexto = contexto;
        }
        public void Adicionar(TEntidade entidade)
        {
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

        public List<TEntidade> Listar()
        {
            var entidades = _contexto.Set<TEntidade>().ToList();
            return entidades.Any() ? entidades : new List<TEntidade>();
        }
    }
}
