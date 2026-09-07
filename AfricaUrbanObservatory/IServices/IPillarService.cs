using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.AssessmentDto;
using AfricaUrbanObservatory.Dtos.CommonDto;
using AfricaUrbanObservatory.Dtos.PillarDto;
using AfricaUrbanObservatory.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AfricaUrbanObservatory.IServices
{
    public interface IPillarService
    {
        Task<List<Pillar>> GetAllAsync();
        Task<Pillar?> GetByIdAsync(int id);
        Task<Pillar> AddAsync(Pillar pillar);
        Task<Pillar> UpdateAsync(int id, UpdatePillarDto pillar);
        Task<bool> DeleteAsync(int id);
        Task<Tuple<string, byte[]>> ExportPillarsHistoryByUserId(GetCityPillarHistoryRequestDto requestDto);
        Task<PaginationResponse<PillarsHistroyResponseDto>> GetResponsesByUserId(GetPillarResponseHistoryRequestNewDto request, UserRole userRole);

    }
} 