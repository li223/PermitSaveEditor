using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class TargetCollectionItem
{
    [JsonProperty("item")] 
    public string Item { get; set; }

    [JsonProperty("count")] 
    public int Count { get; set; }

    [JsonProperty("requirementText")] 
    public string RequirementText { get; set; }
}