using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SDA2Wav
{
    public partial class SDA2Wav : Form
    {
        public SDA2Wav()
        {
            InitializeComponent();
        }

        string filePath;
        bool convertType;
        byte sdByte = 0x5E;
        private void selectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Elgato\\StreamDeck\\Audio";
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                filePath = fbd.SelectedPath;
                filePathLabel.Text = "Folder: " + filePath;
                convertButton.Text = "Convert Folder";
                convertButton.Enabled = true;
                convertType = false;
            }
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Elgato\\StreamDeck\\Audio";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                filePathLabel.Text = "File: " + filePath;
                convertButton.Text = "Convert File";
                convertButton.Enabled = true;
                convertType = true;
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (convertType)
            {
                outputLog.Items.Clear();
                byte[] sdFile = File.ReadAllBytes(filePath);
                int i = 0;
                foreach(byte b in sdFile)
                {
                    sdFile[i] = (byte)(b ^ sdByte);
                    i++;
                }
                string newFileName = filePath.Replace(filePath + "\\", "");
                string newFile = filePath.Replace(".streamDeckAudio", ".wav");
                try
                {
                    File.WriteAllBytes(newFile, sdFile);
                    outputLog.Items.Add("Successfully Created: " + newFileName.Replace(".streamDeckAudio", ".wav"));
                }
                catch (Exception ex)
                {
                    outputLog.Items.Add(ex.Message);
                }
                convertButton.Enabled = false;
                convertButton.Text = "Select a File/Folder";
                selectFolder.Enabled = true;
                filePathLabel.Text = "No File/Folder Selected";
            } else
            {
                outputLog.Items.Clear();
                string[] files = Directory.GetFiles(filePath, "*.streamDeckAudio", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    byte[] sdFile = File.ReadAllBytes(file);
                    int i = 0;
                    foreach (byte b in sdFile)
                    {
                        sdFile[i] = (byte)(b ^ sdByte);
                        i++;
                    }
                    string newFileName = file.Replace(filePath+"\\", "");
                    string newFile = file.Replace(".streamDeckAudio", ".wav");
                    try
                    {
                        File.WriteAllBytes(newFile, sdFile);
                        outputLog.Items.Add("Successfully Created: " + newFileName.Replace(".streamDeckAudio", ".wav"));
                    }
                    catch (Exception ex)
                    {
                        outputLog.Items.Add(ex.Message);
                    }

                };

                convertButton.Enabled = false;
                convertButton.Text = "Select a File/Folder";
                selectFile.Enabled = true;
                filePathLabel.Text = "No File/Folder Selected";
            }
        }
    }
}