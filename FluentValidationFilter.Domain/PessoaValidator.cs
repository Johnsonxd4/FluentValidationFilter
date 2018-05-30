using FluentValidation;

namespace FluentValidationFilter.Domain
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().NotNull().WithMessage("Informe o nome da pessoa");
        }
    }
}
