using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class SymptomDataList
{
    [JsonProperty("isHidden")] 
    public bool IsHidden { get; set; }

    [JsonProperty("bodyPartID")] 
    public int BodyPartID { get; set; }

    [JsonProperty("symptomID")] 
    public int SymptomID { get; set; }

    [JsonProperty("potionID")]
    public int PotionID { get; set; }

    [JsonProperty("symptomState")]
    public int SymptomState { get; set; }

    [JsonProperty("miniGameID")] 
    public int MiniGameID { get; set; }
}