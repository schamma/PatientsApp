//using PatientsApp.DTOs;
//using PatientsApp.Entities;
//using PatientsApp.Interfaces;
//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using PatientsApp.Server.DTOs;
//using PatientsApp.Server.Entities;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.Data;
using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace PatientsApp.Server.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        //        private readonly UserManager<AppUser> _userManager;
        //        private readonly ITokenService _tokenService;
        //        private readonly IMapper _mapper;

        //        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, IMapper mapper)
        //        {
        //            _userManager = userManager;
        //            _tokenService = tokenService;
        //            _mapper = mapper;
        //        }


        [HttpPost("register")]
        //public async Task<ActionResult<AppUser>> Register(string username, string password)
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.Username)) return BadRequest("Username is taken");
            
            using var hmac = new HMACSHA512();

            //var user = new AppUser
            //{
            //    UserName = username,
            //    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
            //    PasswordSalt = hmac.Key
            //};
            var user = new AppUser
            {
                UserName = registerDto.Username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return new UserDto
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user),
                //KnownAs = user.KnownAs,
                //Gender = user.Gender
            };
        }

        //[HttpPost("register")]
        //public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        //{
        //    if (await UserExists(registerDto.Username)) return BadRequest("Username is taken");

        //    var user = _mapper.Map<AppUser>(registerDto);

        //    user.UserName = registerDto.Username.ToLower();

        //    var result = await _userManager.CreateAsync(user, registerDto.Password);

        //    if (!result.Succeeded) return BadRequest(result.Errors);

        //    var roleResult = await _userManager.AddToRoleAsync(user, "Member");

        //    if (!roleResult.Succeeded) return BadRequest(result.Errors);

        //    return new UserDto
        //    {
        //        Username = user.UserName,
        //        Token = await _tokenService.CreateToken(user),
        //        KnownAs = user.KnownAs,
        //        Gender = user.Gender
        //    };
        //}

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(x => x.UserName == loginDto.Username);

            if (user == null) return Unauthorized("Invalid username");

            using var hmac = new HMACSHA512(user.PasswordSalt);
            
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (var i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid Password");
                }
            }

            return new UserDto
            {
                Username = user.UserName,
                Token = _tokenService.CreateToken(user),
                //KnownAs = user.KnownAs,
                //Gender = user.Gender
            };
        }

        //        [HttpPost("login")]
        //        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        //        {
        //            var user = await _userManager.Users
        //                .Include(p => p.Photos)
        //                .SingleOrDefaultAsync(x => x.UserName == loginDto.Username);

        //            if (user == null) return Unauthorized("Invalid username");

        //            var result = await _userManager.CheckPasswordAsync(user, loginDto.Password);

        //            if (!result) return Unauthorized();

        //            return new UserDto
        //            {
        //                Username = user.UserName!,
        //                Token = await _tokenService.CreateToken(user),
        //                PhotoUrl = user.Photos.FirstOrDefault(x => x.IsMain)?.Url,
        //                KnownAs = user.KnownAs,
        //                Gender = user.Gender
        //            };
        //        }

        private async Task<bool> UserExists(string username)
        {
            //return await _userManager.Users.AnyAsync(x => x.UserName == username.ToLower());
            return await _context.Users.AnyAsync(x => x.UserName == username.ToLower());
        }
    }
}