using Newtonsoft.Json;

namespace PermitSaveEditor.Objects
{
    public class QuestRequirementCheckerList
    {
        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("prefixText")]
        public string PrefixText { get; set; }

        [JsonProperty("requirementText")]
        public string RequirementText { get; set; }
    }
}
