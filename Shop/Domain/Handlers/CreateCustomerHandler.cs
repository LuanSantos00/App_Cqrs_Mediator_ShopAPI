﻿using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia E-mail de boas vindas


            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Luan Santos",
                Email = "luancosmefilho@gmail.com",
                Date = DateTime.Now,
            };

            return Task.FromResult(result);
        }
    }
}
