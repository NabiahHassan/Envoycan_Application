using Envoycan_Application.DataAccess;
using Microsoft.EntityFrameworkCore;
using static Envoycan_Application.Models.Services;

namespace Envoycan_Application.Repository
{
    public class Service_Repo
    {
        private readonly ApplicationDBContext _context;
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public Service_Repo(ApplicationDBContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpcontextAccessor = httpContextAccessor;
        }
        public async Task<List<ACRepair>> GetAllAC_Services()
        {
            return await _context.ACRepiar.ToListAsync();
        }
        public async Task<List<Carpenter>> GetAllCarpenterServices()
        {
            return await _context.Carpenter.ToListAsync();
        }
        public async Task<List<HouseCleaning>> GetAllHouseCleaning()
        {
            return await _context.HouseCleaning.ToListAsync();  
        }
        public async Task<List<Painter>> GetAllPainter()
        {
            return await _context.Painter.ToListAsync();
        }
        public async Task<List<PestControl>> GetAllPestControl()
        {
            return await _context.PestControl.ToListAsync();
        }
        public async Task<List<Plumber>> GetAllPlumber()
        {
            return await _context.Plumber.ToListAsync();
        }
        public async Task<List<Salon>> GetAllSalon()
        {
            return await _context.Salon.ToListAsync();
        }
        public async Task<List<SmartHome>> GetAllSmartHome()
        {
            return await _context.SmartHome.ToListAsync();
        }
    }
}
