using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Services
{
    public class SystemCodeRepository : ISystemCodeRepository
    {
        private readonly ApplicationDbContext _context;

        public SystemCodeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<SystemCode> AddSystemCodeAsync(SystemCode systemCode)
        {
            throw new NotImplementedException();
        }

        public Task<SystemCode> DeleteSystemCodeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SystemCode> GetSystemCodeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SystemCodeDetail>> GetSystemCodeDetailsAsync(int systemCodeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<SystemCode>> GetSystemCodesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SystemCode> UpdateSystemCodeAsync(SystemCode systemCode)
        {
            throw new NotImplementedException();
        }
    }
}
