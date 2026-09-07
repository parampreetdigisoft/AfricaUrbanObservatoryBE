using AfricaUrbanObservatory.Common.Models;
using AfricaUrbanObservatory.Dtos.AssessmentDto;
using AfricaUrbanObservatory.Dtos.CommonDto;
using AfricaUrbanObservatory.Dtos.UserDtos;
using AfricaUrbanObservatory.Models;

namespace AfricaUrbanObservatory.IServices
{
    public interface IUserService
    {
        User GetByEmail(string email);
        Task<PaginationResponse<GetUserByRoleResponse>> GetUserByRoleWithAssignedCity(GetUserByRoleRequestDto requestDto);
        Task<ResultResponseDto<List<PublicUserResponse>>> GetEvaluatorByAnalyst(GetAssignUserDto requestDto);
        Task<ResultResponseDto<List<GetAssessmentResponseDto>>> GetUsersAssignedToCity(int cityId);
        Task<ResultResponseDto<UpdateUserResponseDto>> GetUserInfo(int userId);

    }
} 