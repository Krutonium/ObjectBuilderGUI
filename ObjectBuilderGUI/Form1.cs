using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ObjectBuilderGUI
{
    public partial class frmObjectBuilder : Form
    {
        public frmObjectBuilder()
        {
            InitializeComponent();
        }

        private void BtnSelectGenFiles_Click(object sender, EventArgs e)
        {
            DialogResult result = genFilesDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                tbGenFiles.Text = genFilesDialog.SelectedPath;
            }
        }

        private void btnFindJson_Click(object sender, EventArgs e)
        {
            DialogResult result = baseJsonDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                tbJson.Text = baseJsonDialog.InitialDirectory + baseJsonDialog.FileName;
            }
        }

        private void btnSaveLocation_Click(object sender, EventArgs e)
        {
            DialogResult result = objectSaveLocation.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbFinalSave.Text = objectSaveLocation.FileName;
            }
        }

        //UI Stuff above ^

        //Backend Work v

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //This goes through the process of building our new object.
            var BaseJSON = LoadJSON(tbJson.Text);
            var SpritesAndOffsets = BuildObjectData(tbGenFiles.Text);
            BuildObject(BaseJSON, SpritesAndOffsets, tbFinalSave.Text, tbAuthors.Text);
        }
        private JObject LoadJSON(string Path)
        {
            return JObject.Parse(File.ReadAllText(Path));
            //Gets us our JSON - I chose this method because we don't know the format of the JSON reliably.
        }

        private Dictionary<string, string> BuildObjectData(string folder)
        {
            Dictionary<string, string> ImageOffset = new Dictionary<string, string>();
            foreach(var file in Directory.GetFiles(folder))
            {
                if (file.ToUpper().EndsWith(".PNG"))
                {
                    var offsetFile = Path.ChangeExtension(file, "txt");
                    ImageOffset.Add(file, File.ReadAllText(offsetFile));
                }
            }
            //This builds a Dictionary of the Sprites and their offsets.
            return ImageOffset;
        }

        private void BuildObject(JObject json, Dictionary<string, string> SpritesAndOffsets, string SaveLocation, string Authors)
        {
            //Our Goals here are as follows:
            //Mutate the JSON to work with our new object
            //Move Files into appropriate Locations
            //Generate the Object file
            //Move it to the designated save location.
            //JToken token;
            json.Remove("sourceGame");
            //json.Remove("images");
            json["images"] = JToken.FromObject(convertFromDictionary(SpritesAndOffsets));
            //Removed sourcegame property - there isn't one.
            //Removed the existing images list.
            //Convert and Add our list of images and their offsets.
            json["authors"].Replace(JToken.FromObject(Authors));
            
            var rand = new Random();
            string tempDir = Path.GetTempPath() + rand.Next(0,5000);
            Directory.CreateDirectory(tempDir);
            Directory.CreateDirectory(tempDir + "/images");
           
            File.WriteAllText(tempDir + "/" + Path.GetFileName(tbJson.Text), JsonConvert.SerializeObject(json, Formatting.Indented));
            //^Creates our JSON file.
            foreach(var image in SpritesAndOffsets)
            {
                File.Copy(image.Key, tempDir + "/images/" + Path.GetFileName(image.Key));
            }
            ZipFile.CreateFromDirectory(tempDir, tbFinalSave.Text);
            Process.Start("explorer.exe", Path.GetDirectoryName(tbFinalSave.Text));
            MessageBox.Show("Process complete!");
        }
        private List<ImagesObject> convertFromDictionary (Dictionary<string, string> startingData) 
        {
            var P = new List<ImagesObject>();
            foreach (var item in startingData)
            {
                var tmp = new ImagesObject();
                tmp.path = "/images/" + Path.GetFileName(item.Key);
                var coords = item.Value.Split(' ');
                tmp.x = "-" + coords[0];
                tmp.y = "-" + coords[1];
                P.Add(tmp);
            }
            return P;  //This converts our list of images and offsets into a list of ImageObjects.
        }
        public class ImagesObject
        {
            public string path;
            public string x;
            public string y;
            public string format = "raw";
        }
    }
}
