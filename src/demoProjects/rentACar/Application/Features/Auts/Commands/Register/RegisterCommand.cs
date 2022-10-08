using Application.Features.Auts.Dtos;
using Application.Features.Auts.Rules;
using Application.Services.Repositories;
using Core.Security.Dtos;
using MediatR;

namespace Application.Features.Auts.Commands.Register
{
    public class RegisterCommand:IRequest<RegisteredDto>
    {
        public UserForRegisterDto? UserForRegisterDto { get; set; }

        public string? IpAddress { get; set; }

        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisteredDto>
        {
            private readonly AuthBusinessRules _authBusinessRules;

            private readonly IUserRepository _userRepository;
            public Task<RegisteredDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
             //devam et
             return null;
            }
        }
    }
}