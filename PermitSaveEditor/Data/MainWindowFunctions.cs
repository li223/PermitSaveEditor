using Newtonsoft.Json;
using PermitSaveEditor.Data;
using PermitSaveEditor.Objects;
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

            SkinR.Text = saveData.SkinColor.R.ToString();
            SkinG.Text = saveData.SkinColor.G.ToString();
            SkinB.Text = saveData.SkinColor.B.ToString();
            SkinA.Text = saveData.SkinColor.A.ToString("0.0");

            HairR.Text = saveData.HairColor.R.ToString();
            HairG.Text = saveData.HairColor.G.ToString();
            HairB.Text = saveData.HairColor.B.ToString();
            HairA.Text = saveData.HairColor.A.ToString("0.0");

            EyesR.Text = saveData.EyesColor.R.ToString();
            EyesG.Text = saveData.EyesColor.G.ToString();
            EyesB.Text = saveData.EyesColor.B.ToString();
            EyesA.Text = saveData.EyesColor.A.ToString("0.0");

            ClothR.Text = saveData.ClothColor.R.ToString();
            ClothG.Text = saveData.ClothColor.G.ToString();
            ClothB.Text = saveData.ClothColor.B.ToString();
            ClothA.Text = saveData.ClothColor.A.ToString("0.0");

            CapeA.Text = saveData.CapeColor.R.ToString();
            CapeG.Text = saveData.CapeColor.G.ToString();
            CapeB.Text = saveData.CapeColor.B.ToString();
            CapeA.Text = saveData.CapeColor.A.ToString("0.0");

            CarpenterLevel.Text = saveData.CarpenterLevel.ToString();
            BlacksmithLevel.Text = saveData.BlacksmithLevel.ToString();

            var isFemale = saveData.Gender == 0;
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

            _loadedSave.SkinColor = new Objects.Color(SkinR.Text, SkinG.Text, SkinB.Text, SkinA.Text);
            _loadedSave.HairColor = new Objects.Color(HairR.Text, HairG.Text, HairB.Text, HairA.Text);
            _loadedSave.EyesColor = new Objects.Color(EyesR.Text, EyesG.Text, EyesB.Text, EyesA.Text);
            _loadedSave.ClothColor = new Objects.Color(ClothR.Text, ClothG.Text, ClothB.Text, ClothA.Text);
            _loadedSave.CapeColor = new Objects.Color(CapeR.Text, CapeG.Text, CapeB.Text, CapeA.Text);

            return JsonConvert.SerializeObject(_loadedSave);
        }

        public void HandleInputVisibility()
        {
            SaveBtn.Visibility = Visibility.Visible;
            DPJFile_Btn.Visibility = Visibility.Visible;
            UnlockablesTab.Visibility = Visibility.Visible;

            SkinUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.SkinLockStateList);
            SkinUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.HairLockStateList);
            SkinUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.ClothLockStateList);
            SkinUnlock.IsEnabled = !DataManager.AllEnabled(_loadedSave!.CapeLockStateList);
        }
    }
}
