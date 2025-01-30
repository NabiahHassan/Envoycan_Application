using Envoycan_Application.DataAccess;
using Envoycan_Application.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Security.Claims;
namespace Envoycan_Application.Repository
{
    public class Registration_Repository
    {
        private readonly ApplicationDBContext _context;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public Registration_Repository(ApplicationDBContext context , IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpcontextAccessor = httpContextAccessor;
        }
        public async Task<int> Registration(UserRegistration_Model registration_Model)
        {
            _context.User_registration.Add(registration_Model);
            int result =  await _context.SaveChangesAsync();
            return result;
        }
        public async Task<List<UserRegistration_Model>> GetAllUsers()
        {
            return await _context.User_registration.ToListAsync();
        }
        public async Task<UserRegistration_Model> GetUserByEmail(string Email, string Password)
        {
            var UserEmail = await _context.User_registration.FirstOrDefaultAsync(x => x.Email == Email && x.Password == Password);
            return UserEmail;
        }

    }
}
