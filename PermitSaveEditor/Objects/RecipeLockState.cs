using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class RecipeLockState
{
    [JsonProperty("reorderableList")] public ReorderableList ReorderableList { get; set; }

    [JsonProperty("reqReferences")] public ReqReferences ReqReferences { get; set; }

    [JsonProperty("isExpanded")] public bool IsExpanded { get; set; }

    [JsonProperty("_keyValues")] public List<string> KeyValues { get; set; }

    [JsonProperty("_keys")] public List<string> Keys { get; set; }

    [JsonProperty("_values")] public List<bool> Values { get; set; }
}