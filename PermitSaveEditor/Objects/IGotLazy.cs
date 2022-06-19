using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermitSaveEditor.Objects
{
    public class AssignQuestIDStacking
    {
        [JsonProperty("npcID")]
        public string NpcID { get; set; }

        [JsonProperty("questID")]
        public string QuestID { get; set; }
    }

    public class CampBedList
    {
        [JsonProperty("campBedObject")]
        public CampBedObject CampBedObject { get; set; }

        [JsonProperty("sickNPC")]
        public int SickNPC { get; set; }
    }

    public class CampBedObject
    {
        [JsonProperty("m_FileID")]
        public int MFileID { get; set; }

        [JsonProperty("m_PathID")]
        public int MPathID { get; set; }
    }

    public class CapsuleDict
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
        public List<bool> Values { get; set; }
    }
    public class CURRENTKILLMONSTER
    {
        [JsonProperty("monster")]
        public string Monster { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }
    }

    public class DeliveryItemList
    {
        [JsonProperty("itemID")]
        public string ItemID { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class DiseasePatternList
    {
        [JsonProperty("upgradeLevel")]
        public int UpgradeLevel { get; set; }

        [JsonProperty("pattern")]
        public List<Pattern> Pattern { get; set; }
    }

    public class EnemySlainData
    {
        [JsonProperty("monsterID")]
        public int MonsterID { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }
    }

    public class EventStateDatum
    {
        [JsonProperty("eventID")]
        public string EventID { get; set; }

        [JsonProperty("eventState")]
        public string EventState { get; set; }

        [JsonProperty("eventDelay")]
        public int EventDelay { get; set; }
    }

    public class FastTravelState
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<string> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<string> Keys { get; set; }

        [JsonProperty("_values")]
        public List<bool> Values { get; set; }
    }

    public class FishExpDict
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

    public class FishRecordList
    {
        [JsonProperty("FISH_ID")]
        public int FISHID { get; set; }

        [JsonProperty("TOTAL")]
        public int TOTAL { get; set; }

        [JsonProperty("BEST_LBS")]
        public double BESTLBS { get; set; }
    }

    public class ItemLockState
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<string> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<string> Keys { get; set; }

        [JsonProperty("_values")]
        public List<bool> Values { get; set; }
    }

    public class Items
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<KeyValue> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<object> Keys { get; set; }

        [JsonProperty("_values")]
        public List<object> Values { get; set; }
    }

    public class KeyValue
    {
        [JsonProperty("m_FileID")]
        public int MFileID { get; set; }

        [JsonProperty("m_PathID")]
        public int MPathID { get; set; }
    }

    public class MapResourceState
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<string> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<string> Keys { get; set; }

        [JsonProperty("_values")]
        public List<bool> Values { get; set; }
    }

    public class NewQuestDataList
    {
        [JsonProperty("npcID")]
        public string NpcID { get; set; }

        [JsonProperty("questState")]
        public string QuestState { get; set; }

        [JsonProperty("questGiverName")]
        public string QuestGiverName { get; set; }

        [JsonProperty("questGiverSprite")]
        public string QuestGiverSprite { get; set; }

        [JsonProperty("questID")]
        public string QuestID { get; set; }

        [JsonProperty("questName")]
        public string QuestName { get; set; }

        [JsonProperty("questInfoDetail")]
        public string QuestInfoDetail { get; set; }

        [JsonProperty("questActive")]
        public bool QuestActive { get; set; }

        [JsonProperty("isBypassReport")]
        public bool IsBypassReport { get; set; }

        [JsonProperty("isOverridePosition")]
        public bool IsOverridePosition { get; set; }

        [JsonProperty("generateRequirement")]
        public bool GenerateRequirement { get; set; }

        [JsonProperty("updateQuest")]
        public bool UpdateQuest { get; set; }

        [JsonProperty("dayDelay")]
        public int DayDelay { get; set; }

        [JsonProperty("questPosition")]
        public QuestPosition QuestPosition { get; set; }

        [JsonProperty("questFieldID")]
        public string QuestFieldID { get; set; }

        [JsonProperty("questDialogList")]
        public List<object> QuestDialogList { get; set; }

        [JsonProperty("questRequirementText")]
        public List<object> QuestRequirementText { get; set; }

        [JsonProperty("questRequirementCheckerList")]
        public List<QuestRequirementCheckerList> QuestRequirementCheckerList { get; set; }

        [JsonProperty("questReqType")]
        public string QuestReqType { get; set; }

        [JsonProperty("questKillReq")]
        public QuestKillReq QuestKillReq { get; set; }

        [JsonProperty("questCollectReq")]
        public QuestCollectReq QuestCollectReq { get; set; }

        [JsonProperty("questTalkReq")]
        public QuestTalkReq QuestTalkReq { get; set; }

        [JsonProperty("questEventReq")]
        public QuestEventReq QuestEventReq { get; set; }

        [JsonProperty("questProgressReq")]
        public QuestProgressReq QuestProgressReq { get; set; }

        [JsonProperty("questDeliveryReq")]
        public QuestDeliveryReq QuestDeliveryReq { get; set; }

        [JsonProperty("questPostCompleteData")]
        public QuestPostCompleteData QuestPostCompleteData { get; set; }

        [JsonProperty("questPreCompleteData")]
        public QuestPreCompleteData QuestPreCompleteData { get; set; }

        [JsonProperty("initialize")]
        public bool Initialize { get; set; }
    }

    public class NpcFPDataList
    {
        [JsonProperty("npcID")]
        public string NpcID { get; set; }

        [JsonProperty("fpPoint")]
        public int FpPoint { get; set; }

        [JsonProperty("fpLevel")]
        public int FpLevel { get; set; }
    }

    public class NpcHealthDataList
    {
        [JsonProperty("npcID")]
        public string NpcID { get; set; }

        [JsonProperty("isSick")]
        public bool IsSick { get; set; }

        [JsonProperty("isAway")]
        public bool IsAway { get; set; }

        [JsonProperty("isCure")]
        public bool IsCure { get; set; }

        [JsonProperty("npcHP")]
        public int NpcHP { get; set; }

        [JsonProperty("awayCnt")]
        public int AwayCnt { get; set; }

        [JsonProperty("cureDelayCnt")]
        public int CureDelayCnt { get; set; }
    }

    public class Pattern
    {
        [JsonProperty("symptomDifficulty")]
        public List<int> SymptomDifficulty { get; set; }
    }

    public class PlayerInventoryItemDatum
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("itemIDString")]
        public string ItemIDString { get; set; }

        [JsonProperty("itemIconName")]
        public string ItemIconName { get; set; }

        [JsonProperty("itemQty")]
        public int ItemQty { get; set; }

        [JsonProperty("itemID")]
        public int ItemID { get; set; }

        [JsonProperty("itemGrade")]
        public int ItemGrade { get; set; }

        [JsonProperty("itemType")]
        public int ItemType { get; set; }

        [JsonProperty("itemPuzzleShape")]
        public int ItemPuzzleShape { get; set; }

        [JsonProperty("itemElement")]
        public int ItemElement { get; set; }

        [JsonProperty("materialType")]
        public int MaterialType { get; set; }

        [JsonProperty("spawnAreaList")]
        public List<int> SpawnAreaList { get; set; }

        [JsonProperty("buyingPrice")]
        public int BuyingPrice { get; set; }

        [JsonProperty("sellingPrice")]
        public int SellingPrice { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("stamina")]
        public int Stamina { get; set; }
    }

    public class PlayerVendingDatum
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("itemIDString")]
        public string ItemIDString { get; set; }

        [JsonProperty("itemIconName")]
        public string ItemIconName { get; set; }

        [JsonProperty("itemQty")]
        public int ItemQty { get; set; }

        [JsonProperty("itemID")]
        public int ItemID { get; set; }

        [JsonProperty("itemGrade")]
        public int ItemGrade { get; set; }

        [JsonProperty("itemType")]
        public int ItemType { get; set; }

        [JsonProperty("itemPuzzleShape")]
        public int ItemPuzzleShape { get; set; }

        [JsonProperty("itemElement")]
        public int ItemElement { get; set; }

        [JsonProperty("materialType")]
        public int MaterialType { get; set; }

        [JsonProperty("spawnAreaList")]
        public List<object> SpawnAreaList { get; set; }

        [JsonProperty("buyingPrice")]
        public int BuyingPrice { get; set; }

        [JsonProperty("sellingPrice")]
        public int SellingPrice { get; set; }

        [JsonProperty("health")]
        public int Health { get; set; }

        [JsonProperty("stamina")]
        public int Stamina { get; set; }
    }

    public class Position
    {
        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class PotionLockState
    {
        [JsonProperty("reorderableList")]
        public ReorderableList ReorderableList { get; set; }

        [JsonProperty("reqReferences")]
        public ReqReferences ReqReferences { get; set; }

        [JsonProperty("isExpanded")]
        public bool IsExpanded { get; set; }

        [JsonProperty("_keyValues")]
        public List<string> KeyValues { get; set; }

        [JsonProperty("_keys")]
        public List<string> Keys { get; set; }

        [JsonProperty("_values")]
        public List<bool> Values { get; set; }
    }

    public class PotionSaveDatum
    {
        [JsonProperty("craftCount")]
        public int CraftCount { get; set; }

        [JsonProperty("potionRecipe_1")]
        public List<object> PotionRecipe1 { get; set; }

        [JsonProperty("potionRecipe_2")]
        public List<object> PotionRecipe2 { get; set; }

        [JsonProperty("potionRecipe_3")]
        public List<object> PotionRecipe3 { get; set; }

        [JsonProperty("potionID")]
        public int PotionID { get; set; }

        [JsonProperty("potionIDStr")]
        public string PotionIDStr { get; set; }
    }

    public class ProgressionObjDataList
    {
        [JsonProperty("progressionID")]
        public string ProgressionID { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public class QuestCollectReq
    {
        [JsonProperty("TARGET_COLLECT_ITEM")]
        public List<TargetCollectionItem> TargetCollectionItem { get; set; }
    }

    public class QuestDeliveryReq
    {
        [JsonProperty("CURRENT_DELIVERY")]
        public List<int> CURRENTDELIVERY { get; set; }

        [JsonProperty("TARGET_DELIVERY")]
        public List<TargetDelivery> TargetDelivery { get; set; }
    }

    public class QuestEventReq
    {
        [JsonProperty("CURRENT_EVENT_TRIGGERED")]
        public List<object> CurrentEventTriggered { get; set; }

        [JsonProperty("TARGET_EVENT_TRIGGERED")]
        public List<TargetEventTriggered> TargetEventTriggered { get; set; }
    }

    public class QuestKillReq
    {
        [JsonProperty("CURRENT_KILL_MONSTER")]
        public List<object> CurrentKillMonster { get; set; }

        [JsonProperty("TARGET_KILL_MONSTER")]
        public List<object> TargetKillMonster { get; set; }
    }

    public class QuestPosition
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class QuestPostCompleteData
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
        public List<AssignQuestIDStacking> AssignQuestIDStackings { get; set; }

        [JsonProperty("ActiveEventDetailList")]
        public List<object> ActiveEventDetailList { get; set; }

        [JsonProperty("ProgressionObjDataList")]
        public List<object> ProgressionObjDataList { get; set; }
    }
}
