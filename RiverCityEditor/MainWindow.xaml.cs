using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media;
namespace RiverCityEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string hexValues;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string directory = string.Empty;
            RomFile currentRom = new RomFile();

            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "NESrom|*.nes|All|*.*";
            OFD.FileName = "chat";
            bool? result = OFD.ShowDialog();

            if (result == true)
            {
                directory = OFD.FileName;

                if (directory.Length > 8)
                {
                    currentRom.romByes = new List<byte>(File.ReadAllBytes(directory));
                    this.OpenRomButton.Background = Brushes.Green;
                    this.StatusbarText.Text = "File Loaded.";
                    hexValues = RomFile.ByteArrayToHexString(currentRom.romByes.ToArray());
                }
                else
                {
                    currentRom.romByes = new List<byte>();
                    this.OpenRomButton.Background = Brushes.Green;
                    this.StatusbarText.Text = "File Failed to Load.";
                    hexValues = string.Empty;
                }
            }
        }
    }
}
