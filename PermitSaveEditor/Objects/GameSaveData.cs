using Newtonsoft.Json;
using System.Collections.Generic;

namespace PermitSaveEditor.Objects
{
    public class GameSaveData
    {
        [JsonProperty("isEmptyData")]
        public bool IsEmptyData { get; set; }

        [JsonProperty("characterName")]
        public string CharacterName { get; set; }

        [JsonProperty("dogName")]
        public string DogName { get; set; }

        [JsonProperty("dayCount")]
        public int DayCount { get; set; }

        [JsonProperty("gold")]
        public int Gold { get; set; }

        [JsonProperty("wood")]
        public int Wood { get; set; }

        [JsonProperty("stone")]
        public int Stone { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("canGainTrust")]
        public bool CanGainTrust { get; set; }

        [JsonProperty("trustPoint")]
        public int TrustPoint { get; set; }

        [JsonProperty("trustPenalty")]
        public int TrustPenalty { get; set; }

        [JsonProperty("badgeLevel")]
        public int BadgeLevel { get; set; }

        [JsonProperty("diseaseLevel")]
        public int DiseaseLevel { get; set; }

        [JsonProperty("blacksmithLevel")]
        public int BlacksmithLevel { get; set; }

        [JsonProperty("carpenterLevel")]
        public int CarpenterLevel { get; set; }

        [JsonProperty("playTime")]
        public double PlayTime { get; set; }

        [JsonProperty("dayID")]
        public int DayID { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("hairID")]
        public int HairID { get; set; }

        [JsonProperty("playerInventoryItemData")]
        public List<PlayerInventoryItemDatum> PlayerInventoryItemData { get; set; }

        [JsonProperty("partTimePoliceStationCount")]
        public int PartTimePoliceStationCount { get; set; }

        [JsonProperty("partTimePostOfficeCount")]
        public int PartTimePostOfficeCount { get; set; }

        [JsonProperty("partTimeChurchCount")]
        public int PartTimeChurchCount { get; set; }

        [JsonProperty("playerVendingData")]
        public List<PlayerVendingDatum> PlayerVendingData { get; set; }

        [JsonProperty("itemLockState")]
        public ItemLockState ItemLockState { get; set; }

        [JsonProperty("mapResourceState")]
        public MapResourceState MapResourceState { get; set; }

        [JsonProperty("fastTravelState")]
        public FastTravelState FastTravelState { get; set; }

        [JsonProperty("potionSaveData")]
        public List<PotionSaveDatum> PotionSaveData { get; set; }

        [JsonProperty("potionLockState")]
        public PotionLockState PotionLockState { get; set; }

        [JsonProperty("keyItemActiveList")]
        public List<object> KeyItemActiveList { get; set; }

        [JsonProperty("researchList")]
        public List<string> ResearchList { get; set; }

        [JsonProperty("recipeLockState")]
        public RecipeLockState RecipeLockState { get; set; }

        [JsonProperty("tutorialFlag")]
        public TutorialFlag TutorialFlag { get; set; }

        [JsonProperty("newMaterialList")]
        public List<string> NewMaterialList { get; set; }

        [JsonProperty("newFoodIDList")]
        public List<string> NewFoodIDList { get; set; }

        [JsonProperty("newPotionIDList")]
        public List<object> NewPotionIDList { get; set; }

        [JsonProperty("newFishIDList")]
        public List<object> NewFishIDList { get; set; }

        [JsonProperty("newNpcIDList")]
        public List<string> NewNpcIDList { get; set; }

        [JsonProperty("newEnemyIDList")]
        public List<string> NewEnemyIDList { get; set; }

        [JsonProperty("newTutorialIDList")]
        public List<string> NewTutorialIDList { get; set; }

        [JsonProperty("newDiseaseDataList")]
        public List<object> NewDiseaseDataList { get; set; }

        [JsonProperty("newQuestDataList")]
        public List<NewQuestDataList> NewQuestDataList { get; set; }

        [JsonProperty("eventStateData")]
        public List<EventStateDatum> EventStateData { get; set; }

        [JsonProperty("activeQuestList")]
        public List<ActiveQuestList> ActiveQuestList { get; set; }

        [JsonProperty("queueQuestList")]
        public List<object> QueueQuestList { get; set; }

        [JsonProperty("questProgressList")]
        public List<QuestProgressList> QuestProgressList { get; set; }

        [JsonProperty("targetQuest")]
        public TargetQuest TargetQuest { get; set; }

        [JsonProperty("targetQuestID")]
        public int TargetQuestID { get; set; }

        [JsonProperty("npcFPDataList")]
        public List<NpcFPDataList> NpcFPDataList { get; set; }

        [JsonProperty("npcHealthDataList")]
        public List<NpcHealthDataList> NpcHealthDataList { get; set; }

        [JsonProperty("roomEditorData")]
        public List<RoomEditorDatum> RoomEditorData { get; set; }

        [JsonProperty("diseaseDay")]
        public int DiseaseDay { get; set; }

        [JsonProperty("diseaseDayCounterSudden")]
        public int DiseaseDayCounterSudden { get; set; }

        [JsonProperty("diseaseCounter")]
        public int DiseaseCounter { get; set; }

        [JsonProperty("activeDiseaseList")]
        public List<ActiveDiseaseList> ActiveDiseaseList { get; set; }

        [JsonProperty("triggerDiseaseDict")]
        public TriggerDiseaseDict TriggerDiseaseDict { get; set; }

        [JsonProperty("diseasePatternList")]
        public DiseasePatternList DiseasePatternList { get; set; }

        [JsonProperty("isFirstDisease")]
        public bool IsFirstDisease { get; set; }

        [JsonProperty("progressionObjDataList")]
        public List<ProgressionObjDataList> ProgressionObjDataList { get; set; }

        [JsonProperty("capsuleDict")]
        public CapsuleDict CapsuleDict { get; set; }

        [JsonProperty("statusUpgradeList")]
        public List<object> StatusUpgradeList { get; set; }

        [JsonProperty("upgradeDataDict")]
        public UpgradeDataDict UpgradeDataDict { get; set; }

        [JsonProperty("skinColor")]
        public Color SkinColor { get; set; }

        [JsonProperty("hairColor")]
        public Color HairColor { get; set; }

        [JsonProperty("eyesColor")]
        public Color EyesColor { get; set; }

        [JsonProperty("clothColor")]
        public Color ClothColor { get; set; }

        [JsonProperty("capeColor")]
        public Color CapeColor { get; set; }

        [JsonProperty("skinLockStateList")]
        public List<bool> SkinLockStateList { get; set; }

        [JsonProperty("hairLockStateList")]
        public List<bool> HairLockStateList { get; set; }

        [JsonProperty("eyesLockStateList")]
        public List<bool> EyesLockStateList { get; set; }

        [JsonProperty("clothLockStateList")]
        public List<bool> ClothLockStateList { get; set; }

        [JsonProperty("capeLockStateList")]
        public List<bool> CapeLockStateList { get; set; }

        [JsonProperty("storyTimelineIndex")]
        public int StoryTimelineIndex { get; set; }

        [JsonProperty("enemySlainDatas")]
        public List<EnemySlainData> EnemySlainDatas { get; set; }

        [JsonProperty("enemyQuestDatas")]
        public List<object> EnemyQuestDatas { get; set; }

        [JsonProperty("resourcesRecords")]
        public ResourcesRecords ResourcesRecords { get; set; }

        [JsonProperty("fishRecordList")]
        public List<FishRecordList> FishRecordList { get; set; }

        [JsonProperty("fishExpDict")]
        public FishExpDict FishExpDict { get; set; }

        [JsonProperty("petDogieFP")]
        public int PetDogieFP { get; set; }

        [JsonProperty("campBedList")]
        public List<CampBedList> CampBedList { get; set; }

        [JsonProperty("achievementDict")]
        public AchievementDict AchievementDict { get; set; }
    }
}
