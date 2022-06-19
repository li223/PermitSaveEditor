using Newtonsoft.Json;

namespace PermitSaveEditor.Objects
{
    public class QuestProgressList
    {
        [JsonProperty("questID")]
        public string QuestID { get; set; }

        [JsonProperty("questState")]
        public string QuestState { get; set; }
    }
}
