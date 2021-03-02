using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    internal class Banco
    {
        private IDictionary<Guid, string> _banco;

        public Banco()
        {
            _banco = new Dictionary<Guid, string>();
        }

        private Guid _novaChave => new Guid();

        internal void Adicionar(string texto)
        {
            _banco.Add(_novaChave, texto);
        }

        internal void Atualizar(Guid key, string texto)
        {

        }

        internal KeyValuePair<Guid, string> Buscar (Guid Guid) =>
           
    }
}
