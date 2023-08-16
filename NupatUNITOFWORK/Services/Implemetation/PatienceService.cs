using Microsoft.EntityFrameworkCore;
using NupatUNITOFWORK.Context;
using NupatUNITOFWORK.DTO;
using NupatUNITOFWORK.Model;
using NupatUNITOFWORK.Services.Interface;

namespace NupatUNITOFWORK.Services.Implemetation
{
    public class PatienceService : IPatientService
    {
        private readonly AppDbContext _ctx;

        public PatienceService(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<PatientDTO> AddPatient(PatientDTO patientDTO)
        {
            Patient patient = new Patient()
            {
                Name = patientDTO.Name,
                Address = patientDTO.Address,
                Description = patientDTO.Description,
            };
            _ctx.Patients.Add(patient);
            await _ctx.SaveChangesAsync();

            
            return patientDTO;
        }

        public async Task<string> DeletePatient(int id)
        {
            var patient = _ctx.Patients.FirstOrDefault( c => c.Id == id);
            if (patient != null)
            {
                _ctx.Patients.Remove(patient);
                await _ctx.SaveChangesAsync();
                return "Patient Deleted Successfully";
            }
            return "Patient Not found.";
        }

        public async Task<List<Patient>> GetAllPatients()
        {
            var patients = await _ctx.Patients.ToListAsync();
            return patients;
        }

        public async Task<Patient> GetPatientById(int id)
        {
            return await _ctx.Patients.FindAsync(id);
        }
    }
}
