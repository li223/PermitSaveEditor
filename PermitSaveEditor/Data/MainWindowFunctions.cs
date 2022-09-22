﻿using Newtonsoft.Json;
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
            SkinColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.HairColor.ToArgb();
            HairColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.EyesColor.ToArgb();
            EyeColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.ClothColor.ToArgb();
            OutfitColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            (A, R, G, B) = saveData.CapeColor.ToArgb();
            CapeColour.SelectedColor = System.Windows.Media.Color.FromArgb(A, R, G, B);

            CarpenterLevel.Text = saveData.CarpenterLevel.ToString();
            BlacksmithLevel.Text = saveData.BlacksmithLevel.ToString();

            var isFemale = saveData.Gender == 1;
            MaleGenderRadio.IsChecked = !isFemale;
            FemaleGenderRadio.IsChecked = isFemale;
        }

        public string GetSaveDataAsJson()
        {
            _loadedSave ??= new GameSaveData();

            _loadedSave.CharacterName = PlayerName.Text;
            _loadedSave.DogName = DogName.Text;

            _loadedSave.Gold = int.Parse(Gold.Text);
            _loadedSave.Wood = int.Parse(Wood.Text);
            _loadedSave.Stone = int.Parse(Stone.Text);

            _loadedSave.SkinColor = SkinColour.SelectedColor!.Value.ToObjectsColor();
            _loadedSave.HairColor = HairColour.SelectedColor!.Value.ToObjectsColor();

            _loadedSave.EyesColor = EyeColour.SelectedColor!.Value.ToObjectsColor();
            _loadedSave.ClothColor = OutfitColour.SelectedColor!.Value.ToObjectsColor();

            _loadedSave.CapeColor = CapeColour.SelectedColor!.Value.ToObjectsColor();

            return JsonConvert.SerializeObject(_loadedSave);
        }

        public void HandleInputVisibility()
        {
            SaveBtn.Visibility = Visibility.Visible;
            DPJFile_Btn.Visibility = Visibility.Visible;
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
