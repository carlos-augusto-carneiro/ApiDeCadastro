using FluentValidation;

namespace ApiDeCadastro.Aplication.UseCase.UserCase.UpdateUser;

public sealed class UpdateUserValidation : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserValidation()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Surname).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Email).NotEmpty().MaximumLength(128).EmailAddress();
        RuleFor(x => x.Username).NotEmpty().MaximumLength(64).MinimumLength(3);
        RuleFor(x => x.Password).NotEmpty().MaximumLength(20).MinimumLength(8);
    }
}
