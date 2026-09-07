

using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.chatDto;
using AfricaUrbanObservatory.Models;
using AfricaUrbanObservatory.Services;


namespace AfricaUrbanObservatory.IServices
{
    public interface IChatService
    {
        Task<ResultResponseDto<List<AIAssistantFAQDto>>> GetAssistantFAQDs(int userId, UserRole userRole);
        Task<ResultResponseDto<ChatResponseDto>> AskAboutCity(CityChatRequestDto request);
        Task<ResultResponseDto<ChatResponseDto>> AskAboutGlobal(ChatGlobalAskQuestionRequestDto request);
        Task<ResultResponseDto<ChatCityExecutiveSlidesResponse>> GetCitySlides(int cityId, int userId, UserRole userRole);

        Task<ResultResponseDto<ChatResponseDto>> CrossComparision(CrossComparisionRequestDto request);
    }
}
