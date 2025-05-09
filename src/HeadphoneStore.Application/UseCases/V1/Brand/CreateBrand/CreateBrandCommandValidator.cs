﻿using FluentValidation;

using HeadphoneStore.Domain.Enumerations;

namespace HeadphoneStore.Application.UseCases.V1.Brand.CreateBrand;

public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
{
    public CreateBrandCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Description)
            .NotNull()
            .NotEmpty();
    }
}
