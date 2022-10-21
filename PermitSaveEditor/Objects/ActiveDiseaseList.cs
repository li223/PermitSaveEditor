using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class ActiveDiseaseList
{
    [JsonProperty("npcID")] public int NpcID { get; set; }

    [JsonProperty("currentSP")] public int CurrentSP { get; set; }

    [JsonProperty("targetSP")] public int TargetSP { get; set; }

    [JsonProperty("diseaseState")] public int DiseaseState { get; set; }

    [JsonProperty("symptomDataList")] public List<SymptomDataList> SymptomDataList { get; set; }

    [JsonProperty("pattern")] public Pattern Pattern { get; set; }
}