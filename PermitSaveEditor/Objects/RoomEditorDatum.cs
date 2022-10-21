using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class RoomEditorDatum
{
    [JsonProperty("roomObjectStr")] 
    public string RoomObjectStr { get; set; }

    [JsonProperty("roomObjectID")]
    public int RoomObjectID { get; set; }

    [JsonProperty("direction")] 
    public int Direction { get; set; }

    [JsonProperty("position")] 
    public Position Position { get; set; }
}