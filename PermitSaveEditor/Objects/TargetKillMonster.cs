using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class TargetKillMonster
{
    [JsonProperty("monster")] 
    public string Monster { get; set; }

    [JsonProperty("count")] 
    public int Count { get; set; }

    [JsonProperty("items")] 
    public Items Items { get; set; }
}