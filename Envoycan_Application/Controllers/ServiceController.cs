
using Envoycan_Application.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Envoycan_Application.Controllers
{
    [Route("Service")]
    public class ServiceController : Controller
    {
        private readonly Service_Repo service_Repo;
        
        public ServiceController(Service_Repo _service_Repo)
        {
            service_Repo = _service_Repo;
        }
        [HttpGet("GetACRepairOptions")]
        public async Task<IActionResult> GetACRepairOptions()
        {
            try
            {
                var options = await service_Repo.GetAllAC_Services();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetCarpenterOptions")]
        public async Task<IActionResult> GetCarpenterOptions()
        {
            try
            {
                var options = await service_Repo.GetAllCarpenterServices();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetHouseCleaningOptions")]
        public async Task<IActionResult> GetHouseCleaningOptions()
        {
            try
            {
                var options = await service_Repo.GetAllHouseCleaning();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetPainterOptions")]
        public async Task<IActionResult> GetPainterOptions()
        {
            try
            {
                var options = await service_Repo.GetAllPainter();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetPestControlOptions")]
        public async Task<IActionResult> GetPestControlOptions()
        {
            try
            {
                var options = await service_Repo.GetAllPestControl();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetPlumberOptions")]
        public async Task<IActionResult> GetPlumberOptions()
        {
            try
            {
                var options = await service_Repo.GetAllPlumber();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetSalonOptions")]
        public async Task<IActionResult> GetSalonOptions()
        {
            try
            {
                var options = await service_Repo.GetAllSalon();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }
        [HttpGet("GetSmartHomeOptions")]
        public async Task<IActionResult> GetSmartHomeOptions()
        {
            try
            {
                var options = await service_Repo.GetAllSmartHome();
                return Json(options);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error : {ex.Message}");

            }
        }

    }
}
