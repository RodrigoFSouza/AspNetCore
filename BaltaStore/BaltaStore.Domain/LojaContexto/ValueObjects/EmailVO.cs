using System;
using System.Collections.Generic;
using System.Text;

namespace BaltaStore.Domain.LojaContexto.ValueObjects
{
    public class EmailVO
    {
        public EmailVO(string email)
        {
            Email = email;
        }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Email}";
        }
    }
}
