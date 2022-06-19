using Newtonsoft.Json;
using System.Collections.Generic;

namespace PermitSaveEditor.Objects
{
    public class QuestTalkReq
    {
        [JsonProperty("CURRENT_TALK_WITH_NPC")]
        public List<object> CURRENTTALKWITHNPC { get; set; }

        [JsonProperty("TARGET_TALK_WITH_NPC")]
        public List<object> TARGETTALKWITHNPC { get; set; }

        [JsonProperty("DIALOG_TALK_WITH_NPC")]
        public List<object> DIALOGTALKWITHNPC { get; set; }
    }
}
