namespace AfricaUrbanObservatory.Dtos.CityUserDto
{
    public class AddCityUserKpisCityAndPillar
    {
        public List<int> Cities { get; set; } = new();
        public List<int> Pillars { get; set; } = new();
        public bool IsAllCities { get; set; }
    }
}
