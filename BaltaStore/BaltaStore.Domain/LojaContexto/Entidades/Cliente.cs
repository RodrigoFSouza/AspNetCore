using System;
using BaltaStore.Domain.LojaContexto.ValueObjects;

namespace BaltaStore.Domain.LojaContexto.Entidades
{
    public class Cliente 
    {
        public Cliente(Nome nome, CpfVO cpf, EmailVO 
            email, string telefone, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public Nome Nome { get; set; }
        public CpfVO Cpf { get; private set; }
        public EmailVO Email { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }

        public override string ToString()
        {
            return Cpf.ToString();
        }
    }
}