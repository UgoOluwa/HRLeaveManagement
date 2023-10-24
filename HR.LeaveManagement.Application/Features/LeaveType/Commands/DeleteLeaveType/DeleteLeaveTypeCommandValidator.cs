using FluentValidation;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;

namespace HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class DeleteLeaveTypeCommandValidator : AbstractValidator<DeleteLeaveTypeCommand>
    {
        public DeleteLeaveTypeCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}
