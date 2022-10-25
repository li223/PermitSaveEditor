using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class TargetDelivery
{
    [JsonProperty("npcID")] 
    public string NpcID { get; set; }

    [JsonProperty("deliveryItemList")] 
    public List<DeliveryItemList> DeliveryItemList { get; set; }
}