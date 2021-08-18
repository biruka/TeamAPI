using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Issuance.Domain.Entities;
using Issuance.Domain.Model;
using Issuance.Domain.Interfaces.Facade;
using Issuance.Domain.Interfaces.Repository;
namespace Issuance.Application
{
    public class IssuanceService : IIssuanceService
    {
        private readonly IIssuanceRepository _issuanceRepository;
        public IssuanceService(IIssuanceRepository issuanceRepository)
        {
            _issuanceRepository = issuanceRepository;
        }
        public async Task<Guid> Add(IssuanceEntity issuance)
        {
            Issuance.Domain.Model.Issuance issuanceModel = issuance.MapToModel();
            await _issuanceRepository.AddAsync(issuanceModel);
            return issuanceModel.Guid;
        }

        public async Task Delete(IssuanceEntity issuance)
        {
            Issuance.Domain.Model.Issuance issuanceModel = issuance.MapToModel();
            await _issuanceRepository.DeleteAsync(issuanceModel);
        }

        public async Task<List<IssuanceEntity>> GetAllIssuance()
        {
            var objInssuanceList = await _issuanceRepository.GetAllAsync();
            return objInssuanceList.Select(x => new IssuanceEntity()).ToList();

        }

        public async Task<List<IssuanceEntity>> GetIssuance(Guid issuanceId)
        {
            var objInssuanceList = await _issuanceRepository.GetAsync(x => x.Guid == issuanceId);
            List<Domain.Entities.IssuanceEntity> issuances = objInssuanceList.Select(x => new IssuanceEntity()).ToList();
            return issuances;
        }

        public async Task UpdateIssuance(IssuanceEntity issuance)
        {
            Issuance.Domain.Model.Issuance issuanceModel = issuance.MapToModel();
            await _issuanceRepository.UpdateAsync(issuanceModel);
        }
    }
}
