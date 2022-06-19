using Microsoft.Win32;
using Newtonsoft.Json;
using PermitSaveEditor.Data;
using PermitSaveEditor.Objects;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace PermitSaveEditor
{
    public partial class MainWindow : Window
    {
        private string _fileName;
        private string _fileFullPath;
        private GameSaveData _loadedSave;

        public MainWindow()
        {
            InitializeComponent();
            SaveBtn.Visibility = Visibility.Hidden;
            DPJFile_Btn.Visibility = Visibility.Hidden;
        }

        private async void LoadFileBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                DefaultExt = "rjson",
                Title = "Load Data",
                Filter = "Potion Permit Save data (.rjson)|*.rjson"
            };
            dialog.ShowDialog();

            _fileFullPath = dialog.FileName;
            _fileName = dialog.FileName.Split("\\").Last();

            LoadedFileText.Text = _fileName;
            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                var fs = dialog.OpenFile();
                var buffer = new byte[fs.Length];
                await fs.ReadAsync(buffer.AsMemory());
                fs.Close();

                var fileData = Encoding.UTF8.GetString(buffer);
                var fileJsonData = DataManager.ExecuteCypher(fileData);

                var jsonData = JsonConvert.DeserializeObject<GameSaveData>(fileJsonData);
                SetInputValues(jsonData!);

                SaveBtn.Visibility = Visibility.Visible;
                DPJFile_Btn.Visibility = Visibility.Visible;
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var rjsonData = DataManager.ExecuteCypher(GetSaveDataAsJson());

            var saveDialog = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "rjson",
                Filter = "Potion Permit Save data (.rjson)|*.rjson",
                FileName = _fileName ?? "GameSave1.rjson",
                Title = "Save Data"
            };

            saveDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveDialog.FileName))
            {
                File.WriteAllText(saveDialog.FileName, rjsonData);

                _fileFullPath = saveDialog.FileName;
                _fileName = saveDialog.FileName.Split("\\").Last();
                LoadedFileText.Text = _fileName;
            }

            saveDialog.FileOk += (s, e) =>
            {
                MessageBox.Show("Save Successful!", "Save", MessageBoxButton.OK);
            };
        }

        private void DPJFile_Btn_Click(object sender, RoutedEventArgs e)
        {
            var rjsonData = GetSaveDataAsJson();

            var saveDialog = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "rjson",
                Filter = "Potion Permit Plain Json Data (.json)|*.json",
                FileName = "GameSave.json",
                Title = "Save Data"
            };

            saveDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                File.WriteAllText(saveDialog.FileName, rjsonData);
        }

        public void SetInputValues(GameSaveData saveData)
        {
            _loadedSave = saveData;

            PlayerName.Text = saveData.CharacterName;
            DogName.Text = saveData.DogName;
            Gold.Text = saveData.Gold.ToString();
            Wood.Text = saveData.Wood.ToString();
            Stone.Text = saveData.Wood.ToString();

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
    }
}
