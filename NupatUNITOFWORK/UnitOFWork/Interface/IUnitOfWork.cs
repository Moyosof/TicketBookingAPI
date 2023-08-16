using NupatUNITOFWORK.Services.Interface;

namespace NupatUNITOFWORK.UnitOFWork.Interface
{
    public interface IUnitOfWork
    {
        IPatientService patientServices { get; }
    }
}
