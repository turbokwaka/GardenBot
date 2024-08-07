namespace GardenBot.Models;

public class PlantSearchModel
{
    public List<PlantSearchModelData?> Data { get; set; }

    public PlantSearchModel()
    {
        Data = new List<PlantSearchModelData>();
    }
}

public class PlantSearchModelData
{
    public int PlantId { get; set; }
    public string CommonName { get; set; }
    public string ScientificName { get; set; }
    public string Cycle { get; set; }
    public string Watering { get; set; }
    public string Sunlight { get; set; }
    public string ImageUrl { get; set; }
}