using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Extensions;
using PatientsApp.Server.Interfaces;
using PatientsApp.Server.Services;
using System.Security.Cryptography;
using System.Text;

namespace PatientsApp.Server.Controllers
{
    public class AllergyChecksController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IAllergyChecksRepository _allergyChecksRepository;
        private readonly IMapper _mapper;

        public AllergyChecksController(IUserRepository userRepository, IAllergyChecksRepository allergyChecksRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _allergyChecksRepository = allergyChecksRepository;
            _mapper = mapper;
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAllergy(AllergyChecksDto allergyChecksDto)
        {
            var user = await _userRepository.GetUserByUsernameAsync(User.GetUsername());

            _mapper.Map(allergyChecksDto, user);

            _userRepository.Update(user);

            if (await _userRepository.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to update user");
        }
    }
}

