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
        private string? _fileName;
        private GameSaveData? _loadedSave;

        public MainWindow()
        {
            InitializeComponent();
            SaveBtn.Visibility = Visibility.Hidden;
            DPJFile_Btn.Visibility = Visibility.Hidden;
            UnlockablesTab.Visibility = Visibility.Hidden;
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
            _fileName = dialog.FileName.Split("\\").Last();
            LoadedFileText.Text = _fileName;

            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                try
                {
                    var fs = dialog.OpenFile();
                    var buffer = new byte[fs.Length];
                    await fs.ReadAsync(buffer.AsMemory());
                    fs.Close();

                    var fileData = Encoding.UTF8.GetString(buffer);
                    var fileJsonData = DataManager.ExecuteCypher(fileData);

                    var jsonData = JsonConvert.DeserializeObject<GameSaveData>(fileJsonData);
                    SetInputValues(jsonData!);

                    HandleInputVisibility();
                }
                catch (Exception ex)
                {
                    LoadedFileText.Text = "File Name";
                    MessageBox.Show("Failed to load save file, data may be corrupted.", "Error", MessageBoxButton.OK);
                }
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
            var jsonData = GetSaveDataAsJson();

            var saveDialog = new SaveFileDialog()
            {
                AddExtension = true,
                DefaultExt = "json",
                Filter = "Potion Permit Plain Json data (.json)|*.json",
                FileName = "GameSave.json",
                Title = "Save Data"
            };

            saveDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveDialog.FileName))
                File.WriteAllText(saveDialog.FileName, jsonData);
        }

        private void SkinUnlock_Click(object sender, RoutedEventArgs e)
        {
            DataManager.UnlockAll(_loadedSave!.SkinLockStateList);
            HandleInputVisibility();
        }

        private void HairUnlock_Click(object sender, RoutedEventArgs e)
        {
            DataManager.UnlockAll(_loadedSave!.HairLockStateList);
            HandleInputVisibility();
        }

        private void ClothUnlock_Click(object sender, RoutedEventArgs e)
        {
            DataManager.UnlockAll(_loadedSave!.ClothLockStateList);
            HandleInputVisibility();
        }

        private void CapeUnlock_Click(object sender, RoutedEventArgs e)
        {
            DataManager.UnlockAll(_loadedSave!.CapeLockStateList);
            HandleInputVisibility();
        }
    }
}
