using System;
using Application.Commands;
using Application.Exceptions;
using Application.Queries;
using Domain.Entidades;
using Domain.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EmployeeApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyInformationController: ControllerBase
	{
        private readonly IMediator _mediator;
        public CompanyInformationController(IMediator mediator)
		{
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<ActionResult<List<CompanyInformation>>> GetAllCompanies()
        {
            var query = new GetAllCompaniesQuery();
            var companies = await _mediator.Send(query);
            return Ok(companies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CompanyInformation>> GetCompanyById(int id)
        {
            var query = new GetCompanyByIdQuery(id);
            var company = await _mediator.Send(query);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateCompany(CreateCompanyCommand command)
        {
            var companyId = await _mediator.Send(command);
            return Ok(companyId);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCompany(int id, UpdateCompanyCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            try
            {
                await _mediator.Send(command);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}

