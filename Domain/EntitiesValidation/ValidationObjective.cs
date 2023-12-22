using Domain.Entities;
using FluentValidation;

namespace Domain.EntitiesValidation;

public class ValidationObjective : AbstractValidator<Objective>
{
    public ValidationObjective()
    {
        RuleFor(o => o.NameObjective)
            .NotEmpty().WithMessage("O Nome do objetivo não pode ser vázio!")
            .NotNull().WithMessage("O nome do objetivo não pode ser nulo!");

        RuleFor(o => o.Concluded)
            .NotNull().WithMessage("Não pode ser nulo!");
    }
}
