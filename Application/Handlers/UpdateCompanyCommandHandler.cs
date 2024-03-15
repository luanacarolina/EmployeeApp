using System;
using Application.Commands;
using Application.Exceptions;
using Domain.Repositories;
using MediatR;

namespace Application.Handlers
{
	public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand>
    {
        private readonly ICompanyInformationRepository _companyRepository;

        public UpdateCompanyCommandHandler(ICompanyInformationRepository companyRepository)
		{
            _companyRepository = companyRepository;

        }
        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = await _companyRepository.GetByIdAsync(request.Id);
            if (company == null)
            {
                throw new NotFoundException($"Company with ID {request.Id} not found.");
            }

            // Update company properties here
            company.Name = request.Name;
            company.Address = request.Address;
            company.PhoneNumber = request.PhoneNumber;

            await _companyRepository.UpdateAsync(company);

            return Unit.Value;
        }
    }
}

