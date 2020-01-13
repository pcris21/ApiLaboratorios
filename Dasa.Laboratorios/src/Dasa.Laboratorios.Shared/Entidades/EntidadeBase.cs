using FluentValidator;
using System;

namespace Dasa.Laboratorios.Shared.Entidades
{
    public class EntidadeBase : Notifiable
    {
        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}
