using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Attributes;

namespace FluentValidationFilter
{
    [Validator(typeof(PessoaValidator))]
    public class Pessoa
    {
        public string Nome { get; set; }
    }
}
