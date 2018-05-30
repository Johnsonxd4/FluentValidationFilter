using FluentValidation.Attributes;

namespace FluentValidationFilter.Domain
{
    [Validator(typeof(PessoaValidator))]
    public class Pessoa
    {
        public string Nome { get; set; }
    }
}
