using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SchoolAppASP.Application.Commands;
using SchoolAppASP.Application.Mappers;

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
            var userEntitiy = UserMapper.Mapper.Map<Core.Entities.UsersDB>(request);
            if (userEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newUser = await _userRepo.AddAsync(userEntitiy);
            var userResponse = UserMapper.Mapper.Map<UserResponse>(newUser);
            return userResponse;
        }
    }
}