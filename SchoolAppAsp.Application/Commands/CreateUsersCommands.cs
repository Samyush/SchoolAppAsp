using MediatR;
using System;

namespace SchoolAppASP.Application.Commands
{
    public class CreateUsersCommand : IRequest<UserResponse>
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }

    }
}