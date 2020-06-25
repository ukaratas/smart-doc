using System.Text.Json.Serialization;

public class TagStatisticsItem
{

    [JsonPropertyName("entity-code")]
    public string EntityCode { get; set; }

    [JsonPropertyName("instance-count")]
    public long InstanceCount { get; set; }

}