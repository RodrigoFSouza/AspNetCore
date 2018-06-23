using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.LojaContexto.ValueObjects
{
    public class CpfVO
    {
        public CpfVO(string cpf)
        {
            Cpf = cpf;
        }

        public string Cpf { get; set; }

        public override string ToString()
        {
            return $"{Cpf}";
        }
    }
}
