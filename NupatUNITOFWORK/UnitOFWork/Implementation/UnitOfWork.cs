using NupatUNITOFWORK.Context;
using NupatUNITOFWORK.Services.Implemetation;
using NupatUNITOFWORK.Services.Interface;
using NupatUNITOFWORK.UnitOFWork.Interface;

namespace NupatUNITOFWORK.UnitOFWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private IPatientService _patientService;
        private AppDbContext _ctx;

        public UnitOfWork(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IPatientService patientServices
        {
            get { return _patientService = _patientService ?? new PatienceService(_ctx); }
        }
    }
}
