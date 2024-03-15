using System;
using Domain.Entidades;
using MediatR;

namespace Application.Queries
{
    public record GetCompanyInformationQuery() : IRequest<CompanyInformation>;

}

