﻿using Application.Features.Auts.Dtos;
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
            public Task<RegisteredDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                
            }
        }
    }
}