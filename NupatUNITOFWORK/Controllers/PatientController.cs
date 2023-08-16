using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NupatUNITOFWORK.DTO;
using NupatUNITOFWORK.UnitOFWork.Interface;

namespace NupatUNITOFWORK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientController(IUnitOfWork u)
        {
            _unitOfWork = u;
        }

        [HttpGet]
        [Route("GetallPatient")]

        public async Task<IActionResult> GetAllpatient()
        {
            var result = await _unitOfWork.patientServices.GetAllPatients();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _unitOfWork.patientServices.GetPatientById(id);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddPatient")]
        public async Task<IActionResult> AddPatient([FromBody] PatientDTO patientDTO)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _unitOfWork.patientServices.AddPatient(patientDTO);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeletePatient")]
        public async Task<IActionResult> DeletePatien(int id)
        {
            var result = await _unitOfWork.patientServices.DeletePatient(id);
            return Ok(result);
        }
    }
}
