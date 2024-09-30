using Envoycan_Application.DataAccess;
using Envoycan_Application.Models;
using System.Configuration;
namespace Envoycan_Application.Repository
{
    public class Registration_Repository
    {
        private readonly ApplicationDBContext _context;
        public Registration_Repository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<int> Registration(UserRegistration_Model registration_Model)
        {
            _context.User_registration.Add(registration_Model);
            int result =  await _context.SaveChangesAsync();
            return result;
        }

    }
}
