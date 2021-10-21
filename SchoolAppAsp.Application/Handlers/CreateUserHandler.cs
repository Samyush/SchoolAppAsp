using System;
using System.Threading;
using System.Threading.Tasks;

public class CreateEmployeeHandler : IRequestHandler<CreateUsersCommand, UserResponse>
{
    private readonly IRequestRepository _userRepo;
    public CreateEmployeeHandler(IUserRepository userRepository)
    {
        _userRepo = userRepository;
    }
    public async Task<UserResponse> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
    {
        var employeeEntitiy = UserMapper.Mapper.Map<SchoolAppASP.Core.Entities.UsersDB>(request);
        if (employeeEntitiy is null)
        {
            throw new ApplicationException("Issue with mapper");
        }
        var newEmployee = await _userRepo.AddAsync(employeeEntitiy);
        var employeeResponse = UserMapper.Mapper.Map<UserResponse>(newEmployee);
        return employeeResponse;
    }
}