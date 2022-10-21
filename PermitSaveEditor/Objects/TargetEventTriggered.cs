using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class TargetEventTriggered
{
    [JsonProperty("eventID")] public string EventID { get; set; }

    [JsonProperty("triggered")] public bool Triggered { get; set; }
}