using Newtonsoft.Json;
using System.Collections.Generic;

namespace PermitSaveEditor.Objects
{
    public class TriggerDiseaseDict
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<int> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<int> Keys { get; set; }

        [JsonProperty("_values")]
        public List<int> Values { get; set; }
    }
}
