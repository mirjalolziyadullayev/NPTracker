using noisyPollutionTracker.models.CityModels;

namespace noisyPollutionTracker.models.AgentModel;

public class AgentModel
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public List<CityModel> DiscoveredCities { get; set; }
}
