using FluentValidation;
using NextSoft.Domain.Entitites;
using System;

namespace NextSoft.Service.Validations
{
    public class MoradorValidator : AbstractValidator<Morador>
    {
        public MoradorValidator()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Objeto não encontrado.");
                    });

            RuleFor(c => c.Id_Familia)
                .NotEmpty().WithMessage("Preicsa informar a família.")
                .NotNull().WithMessage("Preicsa informar a família.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Preicsa informar o nome.")
                .NotNull().WithMessage("Precisa informar o nome.");

            RuleFor(c => c.QuantidadeBichosEstimação)
                .NotEmpty().WithMessage("Preicsa informar quantos bichos de estimação tem.")
                .NotNull().WithMessage("Preicsa informar quantos bichos de estimação tem.");
        }
    }
}
