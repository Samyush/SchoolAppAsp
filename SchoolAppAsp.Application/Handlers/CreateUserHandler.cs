using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace SchoolAppASP.Application.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUsersCommand, UserResponse>
    {
        private readonly IUserRepository _userRepo;
        public CreateUserHandler(IUserRepository userRepository)
        {
            _userRepo = userRepository;
        }
        public async Task<UserResponse> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
            var employeeEntitiy = UserMapper.Mapper.Map<Core.Entities.UsersDB>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _userRepo.AddAsync(employeeEntitiy);
            var employeeResponse = UserMapper.Mapper.Map<UserResponse>(newEmployee);
            return employeeResponse;
        }
    }
}