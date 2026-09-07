using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.AssessmentDto;
using AfricaUrbanObservatory.Dtos.CommonDto;
using AfricaUrbanObservatory.Dtos.QuestionDto;
using AfricaUrbanObservatory.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AfricaUrbanObservatory.IServices
{
    public interface IQuestionService
    {
        Task<List<Pillar>> GetPillarsAsync();
        Task<PaginationResponse<GetQuestionRespones>> GetQuestionsAsync(GetQuestionRequestDto requestDto);
        Task<Question> AddQuestionAsync(Question q);
        Task<ResultResponseDto<string>> AddUpdateQuestion(AddUpdateQuestionDto q);
        Task<ResultResponseDto<string>> AddBulkQuestion(AddBulkQuestionsDto q);
        Task<Question> EditQuestionAsync(int id, Question q);
        Task<bool> DeleteQuestionAsync(int id);
        Task<ResultResponseDto<GetPillarQuestionByCityRespones>> GetQuestionsByCityIdAsync(CityPillerRequestDto request, int userId);
        Task<Tuple<string,byte[]>> ExportAssessment(int userCityMappingID);
        Task<ResultResponseDto<List<QuestionsByUserPillarsResponsetDto>>> GetQuestionsHistoryByPillar(GetCityPillarHistoryRequestDto requestDto);
        Task<ResultResponseDto<GetPillarQuestionByCityRespones>> GetQuestionsByCityMappingIdForAnalyst(CityPillerRequestDto request, int userId);
    }
} 