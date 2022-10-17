using Newtonsoft.Json;
using PermitSaveEditor.Data;
using PermitSaveEditor.Objects;
using System;
using System.Linq;
using System.Windows;

namespace PermitSaveEditor
{
    public partial class MainWindow
    {
        public void SetInputValues(GameSaveData saveData)
        {
            _loadedSave = saveData;

            PlayerName.Text = saveData.CharacterName;
            DogName.Text = saveData.DogName;
            Gold.Text = saveData.Gold.ToString();
            Wood.Text = saveData.Wood.ToString();
            Stone.Text = saveData.Stone.ToString();

            var (A, R, G, B) = saveData.SkinColor.ToArgb();
            SkinColor.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.HairColor.ToArgb();
            HairColor.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.EyesColor.ToArgb();
            EyeColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.ClothColor.ToArgb();
            OutfitColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.CapeColor.ToArgb();
            CapeColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            CarpenterLevel.Text = saveData.CarpenterLevel.ToString();
            BlacksmithLevel.Text = saveData.BlacksmithLevel.ToString();
            BadgeLevel.Text = saveData.BadgeLevel.ToString();

            FishingLevel1.Text = saveData.FishExpDict.Values[0].ToString();
            FishingLevel2.Text = saveData.FishExpDict.Values[1].ToString();
            FishingLevel3.Text = saveData.FishExpDict.Values[2].ToString();

            var isFemale = saveData.Gender == 1;
            MaleGenderRadio.IsChecked = !isFemale;
            FemaleGenderRadio.IsChecked = isFemale;
        }

        public string GetSaveDataAsJson()
        {
            _loadedSave ??= new GameSaveData();

            _loadedSave.CharacterName = PlayerName.Text;
            _loadedSave.DogName = DogName.Text;

            _loadedSave.CarpenterLevel = int.Parse(CarpenterLevel.Text);
            _loadedSave.BlacksmithLevel = int.Parse(BlacksmithLevel.Text);
            _loadedSave.BadgeLevel = int.Parse(BadgeLevel.Text);

            _loadedSave.Gold = int.Parse(Gold.Text);
            _loadedSave.Wood = int.Parse(Wood.Text);
            _loadedSave.Stone = int.Parse(Stone.Text);

            _loadedSave.SkinColor = SkinColor.SelectedColor!.Value.ToObjectsColor();
            _loadedSave.HairColor = HairColor.SelectedColor!.Value.ToObjectsColor();

            _loadedSave.EyesColor = EyeColour.SelectedColor!.Value.ToObjectsColor();
            _loadedSave.ClothColor = OutfitColour.SelectedColor!.Value.ToObjectsColor();

            _loadedSave.CapeColor = CapeColour.SelectedColor!.Value.ToObjectsColor();

            _loadedSave.FishExpDict.Values[0] = int.Parse(FishingLevel1.Text);
            _loadedSave.FishExpDict.Values[1] = int.Parse(FishingLevel2.Text);
            _loadedSave.FishExpDict.Values[2] = int.Parse(FishingLevel3.Text);

            return JsonConvert.SerializeObject(_loadedSave);
        }

        public void HandleInputVisibility()
        {
            if(MainWindow.IsRJsonFile)
                DPJFile_Btn.Visibility = Visibility.Visible;

            SaveBtn.Visibility = Visibility.Visible;
            UnlockablesTab.Visibility = Visibility.Visible;

            SkinUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.SkinLockStateList);
            HairUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.HairLockStateList);
            ClothUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.ClothLockStateList);
            CapeUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.CapeLockStateList);
            FastTravelUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.FastTravelState.Values);
            RecipesUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.RecipeLockState.Values);
            PotionsUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.PotionLockState.Values);
            HealAll.IsEnabled = !DataManager.AllEnabled(_loadedSave!.NpcHealthDataList.Select(x => !x.IsSick));
        }
    }
}
