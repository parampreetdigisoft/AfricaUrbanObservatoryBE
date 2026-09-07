using AfricaUrbanObservatory.Dtos.CommonDto;
using AfricaUrbanObservatory.Models;

namespace AfricaUrbanObservatory.Dtos.UserDtos
{
    public class GetUserByRoleRequestDto : PaginationRequest
    {
        public UserRole? GetUserRole { get; set; }
        public int UserID { get; set; }
    }
}
