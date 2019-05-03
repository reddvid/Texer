using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Texer.UWP.Models;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;

namespace Texer.UWP.ViewModels
{
    class MainViewModel : ObservableObject
    {
        private char[] alpha = null;
        private string[] alphaShit = null;
        private string[,] charArray = null;

        StorageFolder roamingFolder = ApplicationData.Current.RoamingFolder;
        private string filename = "favorites.txt";

        public MainViewModel()
        {
            alpha = new Styles().alpha;
            alphaShit = new Styles().alphaShit;
            charArray = new Styles().charArray;

            LoadHistory();

            LoadBingImageOfTheDay();

            InputText = string.Empty;
        }

        private async void LoadHistory()
        {
            try
            {
                StorageFile file = await roamingFolder.GetFileAsync(filename);

                if (file == null) return;

                string json = await FileIO.ReadTextAsync(file);
                ObservableCollection<StyleItem> history = JsonConvert.DeserializeObject<ObservableCollection<StyleItem>>(json);

                foreach (var item in history)
                {
                    SavedList.Add(item);
                }

            }
            catch (Exception)
            {
                return;
            }
        }

        private BitmapImage _bingImage;

        internal void CopyHistoryStyledText()
        {
            if (ClickedItem == null) return;

            var dataPackage = new DataPackage();
            dataPackage.SetText(ClickedItem.TextResult);

            Clipboard.SetContent(dataPackage);
        }

        public BitmapImage BingImage {
            get => _bingImage;
            set
            {
                Set(ref _bingImage, value);
            }
        }

        private string _inputText;
        public string InputText
        {
            get => _inputText;
            set
            {
                Set(ref _inputText, value);
                StyleText();
                RaisePropertyChanged(nameof(IsInputBoxEmpty));
                RaisePropertyChanged(nameof(StyledTextList));
            }
        }

        public ObservableCollection<StyleItem> StyledTextList { get; private set; }

        public ObservableCollection<StyleItem> SavedList { get; } = new ObservableCollection<StyleItem>();

        public bool IsInputBoxEmpty
        {
            get
            {
                return InputText != string.Empty; //|| !IsManual;
            }
        }

        public void StyleText()
        {
            string bold = "";
            string italic = "";
            string em = "";
            string score = "";
            string script = "";
            string super = "";
            string small = "";
            string dark = "";
            string circle = "";
            string thin = "";
            string utf = "";

            foreach (char c in InputText)
            {
                int alphaIndex = Array.IndexOf(alpha, c);

                if (alphaIndex != -1)
                {
                    bold += charArray[alphaIndex, 0];
                    italic += charArray[alphaIndex, 1];
                    em += charArray[alphaIndex, 2];
                    score += charArray[alphaIndex, 3];
                    script += charArray[alphaIndex, 4];
                    super += charArray[alphaIndex, 5];
                    small += charArray[alphaIndex, 6];
                    dark += charArray[alphaIndex, 7];
                    circle += charArray[alphaIndex, 8];
                    thin += charArray[alphaIndex, 9];
                    //utf += Convert(c.ToString());
                }
                else if (Array.IndexOf(alphaShit, c) > -1)
                {
                    int shitIndex = Array.IndexOf(alphaShit, c);
                    utf += alpha[shitIndex];
                }
                else
                {
                    bold += c;
                    italic += c;
                    em += c;
                    score += c;
                    script += c;
                    super += c;
                    small += c;
                    dark += c;
                    circle += c;
                    thin += c;
                    //utf += Convert(c.ToString());
                }
            }

            StyledTextList = new ObservableCollection<StyleItem>
            {
                new StyleItem("Bold", bold),
                new StyleItem("Italic", italic),
                new StyleItem("Emphasized", em),
                new StyleItem("Dark Bubble", dark),
                new StyleItem("Bubble", circle),
                new StyleItem("Thin", thin),
                new StyleItem("Scored", score),
                new StyleItem("Script", script),
                new StyleItem("Tiny", super),
                new StyleItem("Small Caps", small),
            };

        }

        public StyleItem ClickedItem { get; set; }

        public void CopyStyledText()
        {
            if (ClickedItem == null) return;

            var dataPackage = new DataPackage();
            dataPackage.SetText(ClickedItem.TextResult);

            Clipboard.SetContent(dataPackage);

            SavedList.Insert(0, ClickedItem);

            SaveHisory();
        }

        
        private async void SaveHisory()
        {
            string json = JsonConvert.SerializeObject(SavedList);
            StorageFile file = await roamingFolder.CreateFileAsync(filename,
                        CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(file, json);
        }

        public async void LoadBingImageOfTheDay()
        {
            try
            {
                var client = new HttpClient();
                string json = null;
                var response = await client.GetAsync("http://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US");
                var responseContent = response.Content;
                using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
                {
                    // Write the output.
                    json = await reader.ReadToEndAsync();
                }

                var obj = JsonConvert.DeserializeObject<BingImage>(json);

                BingImage = new BitmapImage(new Uri(@"https://www.bing.com" + obj.Images[0].Url, UriKind.RelativeOrAbsolute));

                client?.Dispose();

            }
            catch (Exception ex)
            {
                // oops
            }

        }

    }
}
