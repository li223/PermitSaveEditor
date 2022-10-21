using System.Collections.Generic;
using Newtonsoft.Json;

namespace PermitSaveEditor.Objects;

public class NewQuestDataList
{
    [JsonProperty("npcID")] public string? NpcID { get; set; }

    [JsonProperty("questState")] public string? QuestState { get; set; }

    [JsonProperty("questGiverName")] public string? QuestGiverName { get; set; }

    [JsonProperty("questGiverSprite")] public string? QuestGiverSprite { get; set; }

    [JsonProperty("questID")] public string? QuestID { get; set; }

    [JsonProperty("questName")] public string? QuestName { get; set; }

    [JsonProperty("questInfoDetail")] public string? QuestInfoDetail { get; set; }

    [JsonProperty("questActive")] public bool QuestActive { get; set; }

    [JsonProperty("isBypassReport")] public bool IsBypassReport { get; set; }

    [JsonProperty("isOverridePosition")] public bool IsOverridePosition { get; set; }

    [JsonProperty("generateRequirement")] public bool GenerateRequirement { get; set; }

    [JsonProperty("updateQuest")] public bool UpdateQuest { get; set; }

    [JsonProperty("dayDelay")] public int DayDelay { get; set; }

    [JsonProperty("questPosition")] public QuestPosition QuestPosition { get; set; }

    [JsonProperty("questFieldID")] public string? QuestFieldID { get; set; }

    [JsonProperty("questDialogList")] public List<object>? QuestDialogList { get; set; }

    [JsonProperty("questRequirementText")] public List<object>? QuestRequirementText { get; set; }

    [JsonProperty("questRequirementCheckerList")]
    public List<QuestRequirementCheckerList>? QuestRequirementCheckerList { get; set; }

    [JsonProperty("questReqType")] public string? QuestReqType { get; set; }

    [JsonProperty("questKillReq")] public QuestKillReq? QuestKillReq { get; set; }

    [JsonProperty("questCollectReq")] public QuestCollectReq? QuestCollectReq { get; set; }

    [JsonProperty("questTalkReq")] public QuestTalkReq? QuestTalkReq { get; set; }

    [JsonProperty("questEventReq")] public QuestEventReq? QuestEventReq { get; set; }

    [JsonProperty("questProgressReq")] public QuestProgressReq? QuestProgressReq { get; set; }

    [JsonProperty("questDeliveryReq")] public QuestDeliveryReq? QuestDeliveryReq { get; set; }

    [JsonProperty("questPostCompleteData")]
    public QuestPostCompleteData? QuestPostCompleteData { get; set; }

    [JsonProperty("questPreCompleteData")] public QuestPreCompleteData? QuestPreCompleteData { get; set; }

    [JsonProperty("initialize")] public bool Initialize { get; set; }
}