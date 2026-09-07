using AfricaUrbanObservatory.Dtos.CityDto;

namespace AfricaUrbanObservatory.Dtos.UserDtos
{
    public class GetUserByRoleResponse : PublicUserResponse
    {
        public List<AddUpdateCityDto> cities { get; set; } = new();
    }
}
