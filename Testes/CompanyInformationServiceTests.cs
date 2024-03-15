using System;
using Application.Commands;
using Application.Handlers;
using Application.Queries;
using Application.Services;
using Domain.Entidades;
using Domain.Services;
using MediatR;
using Moq;
using Xunit;

namespace Testes
{
    public class CompanyInformationServiceTests
    {

        [Fact]
        public async Task Handle_ShouldReturnCompanyInformation()
        {
            // Arrange
            var mockCompanyInformationService = new Mock<ICompanyInformationService>();
            mockCompanyInformationService.Setup(x => x.GetCompanyInformationAsync())
                .ReturnsAsync(new CompanyInformation
                {
                    Name = "Empresa ABC",
                    Address = "Rua XYZ, 123",
                    PhoneNumber = "987654321"
                });

            var handler = new GetCompanyInformationQueryHandler(mockCompanyInformationService.Object);
            var query = new GetCompanyInformationQuery();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Empresa ABC", result.Name);
            Assert.Equal("Rua XYZ, 123", result.Address);
            Assert.Equal("987654321", result.PhoneNumber);
        }
      
    }
}

