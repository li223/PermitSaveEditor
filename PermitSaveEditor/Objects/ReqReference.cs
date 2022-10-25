using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class ReqReferences
{
    [JsonProperty("m_FileID")] 
    public int MFileID { get; set; }

    [JsonProperty("m_PathID")] 
    public int MPathID { get; set; }
}