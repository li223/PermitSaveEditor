using Newtonsoft.Json;
using System.Collections.Generic;

namespace PermitSaveEditor.Objects
{
    public class AchievementDict
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<object> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<object> Keys { get; set; }

        [JsonProperty("_values")]
        public List<object> Values { get; set; }
    }
}
