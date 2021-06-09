using Bussnes.Bussines;
using Bussnes.ChangeLocation;
using Core.Constants;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Repository.UnitOfWork;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargerController : ControllerBase
    {
        UnitOfWork unitOfWork;
        LocationChanger locationChanger;
        public ChargerController()
        {
            unitOfWork = new UnitOfWork();
        }
        [HttpPost]
        public IActionResult Add(LocationRequest locationRequest)
        {
            locationChanger = new LocationChanger(locationRequest);
            var result = unitOfWork.GetRepository<Location>().Add(locationChanger.Changer());
            if (result != null)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("api/locations")]
        public IActionResult LocationGet()
        {
           var result=unitOfWork.GetRepository<Location>().GetAll();
            if (result.Data != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("api/locations/{locationId}")]
        public IActionResult LocationGetByID(int locationId)
        {
            var result = unitOfWork.GetRepository<Location>().GetById(locationId);
            if (result.Data != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPatch("api/locations/{locationId}")]
        public IActionResult Update(PatchLocationRequest patchLocationRequest)
        {
            var result = unitOfWork.GetRepository<PatchLocationRequest>().Update(patchLocationRequest);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("api/locations/{locationId}")]
        public IActionResult ChagePoint(ChargePointRequest chargePointRequest)
        {
            ChargePointToId chargerPointToId = new ChargePointToId(chargePointRequest);
            chargerPointToId.GetChargerPoint();
            chargerPointToId.GetChargerPointUpdate();
            var result = unitOfWork.GetRepository<ChargePoint>().Update(chargerPointToId.GetChargerPoint());
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
