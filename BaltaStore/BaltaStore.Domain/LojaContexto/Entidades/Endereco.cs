using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Endereco
    {
        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string pai, string complemento, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Pais = Pais;
            Complemento = complemento;
            Cep = cep;
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Complemento { get; private set; }
        public string Cep { get; private set; }
    }
}
