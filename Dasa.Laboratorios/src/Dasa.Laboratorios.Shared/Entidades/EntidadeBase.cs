using FluentValidator;
using System;

namespace Dasa.Laboratorios.Shared.Entidades
{
    public class EntidadeBase : Notifiable
    {
        public long Id { get; private set; }
    }
}
