using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class QuestProgressReq
{
    [JsonProperty("CURRENT_FP_COUNT")] public int CurrentFPCount { get; set; }

    [JsonProperty("CURRENT_TOWN_UPGRADE_COUNT")]
    public int CurrentTownUpgradeCount { get; set; }

    [JsonProperty("CURRENT_CAULDRON_LEVEL")]
    public int CurrentCauldronLevel { get; set; }

    [JsonProperty("CURRENT_EVENT_TAG_COUNT")]
    public int CurrentEventTagCount { get; set; }

    [JsonProperty("TARGET_FP_COUNT")] public int TargetFPCount { get; set; }

    [JsonProperty("TARGET_FP_LEVEL")] public int TargetFPLevel { get; set; }

    [JsonProperty("TARGET_CAULDRON_LEVEL")]
    public int TargetCauldronLevel { get; set; }

    [JsonProperty("TARGET_TOWN_UPGRADE_COUNT")]
    public int TargetTownUpgradeCount { get; set; }

    [JsonProperty("TARGET_EVENT_TAG")] public string TagetEventTag { get; set; }

    [JsonProperty("TARGET_EVENT_TAG_COUNT")]
    public int TargetEventTagCount { get; set; }
}