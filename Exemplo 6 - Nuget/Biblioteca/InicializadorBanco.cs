using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public static class InicializadorBanco
    {
        internal static Banco Banco { get; } = new Banco();

        internal static Banco BancoOrdenado { get; } = new BancoAutoOrdenado();
    }
}
