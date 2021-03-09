using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    internal class BancoAutoOrdenado : Banco
    {
        internal override List<KeyValuePair<Guid, string>> BuscarTodos => BuscarOrdenado();

        private List<KeyValuePair<Guid, string>> BuscarOrdenado()
        {
            return BancoStorage.OrderBy(t => t.Value).ToList();
        }
    }
}
