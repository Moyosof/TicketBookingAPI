using NupatUNITOFWORK.DTO;
using NupatUNITOFWORK.Model;

namespace NupatUNITOFWORK.Services.Interface
{
    public interface IPatientService
    {
        Task<List<Patient>> GetAllPatients();
        Task<Patient> GetPatientById(int id);
        Task<PatientDTO> AddPatient(PatientDTO patientDTO);
        Task<string> DeletePatient(int id);
    }
}
