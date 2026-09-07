using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.CityUserDto;
using AfricaUrbanObservatory.Dtos.CommonDto;
using AfricaUrbanObservatory.Dtos.kpiDto;
using AfricaUrbanObservatory.Enums;
using AfricaUrbanObservatory.Models;

namespace AfricaUrbanObservatory.IServices
{
    public interface IKpiService
    {
        Task<PaginationResponse<GetAnalyticalLayerResultDto>> GetAnalyticalLayerResults(GetAnalyticalLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<ResultResponseDto<List<AnalyticalLayer>>> GetAllKpi(int userId, UserRole role);
        Task<ResultResponseDto<CompareCityResponseDto>> CompareCities(CompareCityRequestDto c, int userId, UserRole role, bool applyPagination = true);
        Task<ResultResponseDto<GetMutiplekpiLayerResultsDto>> GetMutiplekpiLayerResults(GetMutiplekpiLayerRequestDto request, int userId, UserRole role, TieredAccessPlan userPlan = TieredAccessPlan.Pending);
        Task<Tuple<string, byte[]>> ExportCompareCities(CompareKpiCityRequest request, int userId, UserRole role);

    }
}
