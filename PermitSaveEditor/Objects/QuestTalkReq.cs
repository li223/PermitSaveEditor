using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class QuestTalkReq
{
    [JsonProperty("CURRENT_TALK_WITH_NPC")]
    public List<object> CURRENTTALKWITHNPC { get; set; }

    [JsonProperty("TARGET_TALK_WITH_NPC")]
    public List<object> TARGETTALKWITHNPC { get; set; }

    [JsonProperty("DIALOG_TALK_WITH_NPC")] 
    public List<object> DIALOGTALKWITHNPC { get; set; }
}