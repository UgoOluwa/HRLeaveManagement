using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetail;

public record GetLeaveTypeQuery(int Id) : IRequest<LeaveTypeDetailDto>;