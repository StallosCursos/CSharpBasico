using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    internal class Banco
    {
        protected IDictionary<Guid, string> BancoStorage { get; set; }

        public Banco()
        {
            BancoStorage = new Dictionary<Guid, string>();
        }

        internal void Adicionar(Guid key, string texto) => BancoStorage.Add(key, texto);

        internal void Atualizar(Guid key, string texto) => BancoStorage[key] = texto;

        internal void Remover(Guid key) => BancoStorage.Remove(key);

        internal string Buscar(Guid key) => BancoStorage[key];

        internal bool ChaveExistente(Guid key) => BancoStorage.ContainsKey(key);

        internal virtual List<KeyValuePair<Guid, string>> BuscarTodos => BancoStorage.ToList();
    }
}
