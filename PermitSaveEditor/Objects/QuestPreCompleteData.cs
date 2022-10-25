using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class QuestPreCompleteData
{
    [JsonProperty("completeID")] 
    public string CompleteID { get; set; }

    [JsonProperty("commandUI")] 
    public string CommandUI { get; set; }

    [JsonProperty("increaseFP")]
    public bool IncreaseFP { get; set; }

    [JsonProperty("getItem")]
    public bool GetItem { get; set; }

    [JsonProperty("activeEvent")] 
    public bool ActiveEvent { get; set; }

    [JsonProperty("activeQuest")] 
    public bool ActiveQuest { get; set; }

    [JsonProperty("activeObject")] 
    public bool ActiveObject { get; set; }

    [JsonProperty("playerStat")] 
    public bool PlayerStat { get; set; }

    [JsonProperty("badgeLevelUp")] 
    public bool BadgeLevelUp { get; set; }

    [JsonProperty("reputationLevelUp")] 
    public bool ReputationLevelUp { get; set; }

    [JsonProperty("getWood")] 
    public int GetWood { get; set; }

    [JsonProperty("getStone")] 
    public int GetStone { get; set; }

    [JsonProperty("repeatEvent")] 
    public bool RepeatEvent { get; set; }

    [JsonProperty("cameraFieldConfiner")] 
    public int CameraFieldConfiner { get; set; }

    [JsonProperty("goldReward")] 
    public int GoldReward { get; set; }

    [JsonProperty("chainEventDetail")]
    public int ChainEventDetail { get; set; }

    [JsonProperty("questEventDetail")]
    public int QuestEventDetail { get; set; }

    [JsonProperty("FriendshipPointStackings")]
    public List<object> FriendshipPointStackings { get; set; }

    [JsonProperty("ItemDetailList")] 
    public List<object> ItemDetailList { get; set; }

    [JsonProperty("ActiveQuestIDStackings")]
    public List<object> ActiveQuestIDStackings { get; set; }

    [JsonProperty("AssignQuestIDStackings")]
    public List<object> AssignQuestIDStackings { get; set; }

    [JsonProperty("ActiveEventDetailList")]
    public List<object> ActiveEventDetailList { get; set; }

    [JsonProperty("ProgressionObjDataList")]
    public List<object> ProgressionObjDataList { get; set; }
}