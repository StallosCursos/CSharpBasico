using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public sealed class Comandos
    {
        private Banco _banco;

        public Comandos(bool OrdenarAutomaticamente) => 
            _banco = OrdenarAutomaticamente ? InicializadorBanco.BancoOrdenado : InicializadorBanco.Banco;

        public void Insert(string Texto)
        {
            Guid key = Guid.NewGuid();
            _banco.Adicionar(key, Texto);
        }

        public void Update(Guid Chave, string Texto) 
        {
            if (_banco.ChaveExistente(Chave))
                _banco.Atualizar(Chave, Texto);
            else
                Console.WriteLine("Registro não encontrado para ser atualizado");
        }

        public void Delete(Guid Chave)
        {
            if (_banco.ChaveExistente(Chave))
                _banco.Remover(Chave);
            else
                Console.WriteLine("Registro não encontrado para ser removido");
        }

        public List<KeyValuePair<Guid, string>> Select() => _banco.BuscarTodos;

        public string Select(Guid guid) => _banco.Buscar(guid);
    }
}
