using System;
using System.Collections.Generic;

namespace Dasa.Laboratorios.Dominio.Repositorios
{
    public interface IRepositorioBase<TEntidade>
    {
        List<TEntidade> Listar();
        void Adicionar(TEntidade entidade);
        void Editar(TEntidade entidade, Guid id);
        void Excluir(Guid id);
    }
}
