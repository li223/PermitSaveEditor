using Newtonsoft.Json;
using System.Collections.Generic;

namespace PermitSaveEditor.Objects
{
    public class TargetDelivery
    {
        [JsonProperty("npcID")]
        public string NpcID { get; set; }

        [JsonProperty("deliveryItemList")]
        public List<DeliveryItemList> DeliveryItemList { get; set; }
    }
}
