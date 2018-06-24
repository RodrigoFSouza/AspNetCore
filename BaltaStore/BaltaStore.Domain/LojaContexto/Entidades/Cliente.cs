using System.Collections.Generic;
using System.Linq;
using BaltaStore.Domain.LojaContexto.ValueObjects;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Cliente
    {
        private readonly IList<Endereco> _enderecos;

        public Cliente(Nome nome, CpfVO cpf, EmailVO 
            email, string telefone, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            _enderecos = new List<Endereco>();
        }

        public Nome Nome { get; set; }
        public CpfVO Cpf { get; private set; }
        public EmailVO Email { get; private set; }
        public string Telefone { get; private set; }
        public IReadOnlyCollection<Endereco> Enderecos => _enderecos.ToArray(); 
        
        public void AdicionarEndereco(Endereco endereco)
        {
            _enderecos.Add(endereco);
        }

        public override string ToString()
        {
            return Cpf.ToString();
        }
    }
}