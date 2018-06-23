using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{

    public partial class MainForm : Form
    {


        //initialize the space for our dictionary data
        DictionaryData DictData = new DictionaryData();



        //this is what runs at initialization
        public MainForm()
        {

            InitializeComponent();


            foreach (var encoding in Encoding.GetEncodings())
            {
                InputEncodingDropdown.Items.Add(encoding.Name);
                OutputEncodingDropdown.Items.Add(encoding.Name);
            }

            try
            {
                InputEncodingDropdown.SelectedIndex = InputEncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }
            catch
            {
                InputEncodingDropdown.SelectedIndex = InputEncodingDropdown.FindStringExact("utf-8");
            }

            try
            {
                OutputEncodingDropdown.SelectedIndex = OutputEncodingDropdown.FindStringExact("utf-8");
            }
            catch
            {
                OutputEncodingDropdown.SelectedIndex = OutputEncodingDropdown.FindStringExact(Encoding.Default.BodyName);
            }




        }







        private void StartButton_Click(object sender, EventArgs e)
        {


           

                    FolderBrowser.Description = "Please choose the location of your .txt files to process";
                    if (FolderBrowser.ShowDialog() != DialogResult.Cancel) {

                        DictData.TextFileFolder = FolderBrowser.SelectedPath.ToString();
                
                        if (DictData.TextFileFolder != "")
                        {

                            saveOutputDialog.Description = "Please choose a folder for your output files";
                            saveOutputDialog.SelectedPath = DictData.TextFileFolder;
                            if (saveOutputDialog.ShowDialog() != DialogResult.Cancel) {


                                if (FolderBrowser.SelectedPath == saveOutputDialog.SelectedPath)
                                {
                                    MessageBox.Show("You can not use the same folder for text input and text output. If you do this, your original data would be overwritten. Please use a different folder for your output location.", "Folder selection error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                DictData.OutputFileLocation = saveOutputDialog.SelectedPath;
                                DictData.FileExtension = FileTypeTextbox.Text.Trim();


                                if (DictData.OutputFileLocation != "") {



                                    StartButton.Enabled = false;
                                    ScanSubfolderCheckbox.Enabled = false;
                                    InputEncodingDropdown.Enabled = false;
                                    OutputEncodingDropdown.Enabled = false;
                                    FileTypeTextbox.Enabled = false;
                            
                                    BgWorker.RunWorkerAsync(DictData);
                                }
                            }
                        }

                    }

                

        }

        




        private void BgWorkerClean_DoWork(object sender, DoWorkEventArgs e)
        {


            DictionaryData DictData = (DictionaryData)e.Argument;


            //selects the text encoding based on user selection
            Encoding InputSelectedEncoding = null;
            Encoding OutputSelectedEncoding = null;
            this.Invoke((MethodInvoker)delegate ()
            {
                InputSelectedEncoding = Encoding.GetEncoding(InputEncodingDropdown.SelectedItem.ToString());
                OutputSelectedEncoding = Encoding.GetEncoding(OutputEncodingDropdown.SelectedItem.ToString());
            });

            

            //get the list of files
            var SearchDepth = SearchOption.TopDirectoryOnly;
            if (ScanSubfolderCheckbox.Checked)
            {
                SearchDepth = SearchOption.AllDirectories;
            }
            var files = Directory.EnumerateFiles(DictData.TextFileFolder, DictData.FileExtension, SearchDepth);



            try {

                //we want to be conservative and limit the number of threads to the number of processors that we have
                var options = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount};
                Parallel.ForEach(files, options, (string fileName) =>
                {

                    //set up our variables to report
                    string Filename_Clean = Path.GetFileName(fileName);

                    string SubDirStructure = Path.GetDirectoryName(fileName).Replace(DictData.TextFileFolder, "").TrimStart('\\');


                    //creates subdirs if they don't exist
                    string Output_Location = DictData.OutputFileLocation + '\\' + SubDirStructure;

                    if (!Directory.Exists(Output_Location))
                    {
                        Directory.CreateDirectory(Output_Location);
                    }

                    Output_Location = Path.Combine(Output_Location, Path.GetFileName(fileName));

                        //report what we're working on
                        FilenameLabel.Invoke((MethodInvoker)delegate
                    {
                        FilenameLabel.Text = "Processing: " + Filename_Clean;
                        FilenameLabel.Invalidate();
                        FilenameLabel.Update();
                        FilenameLabel.Refresh();
                        Application.DoEvents();

                    });









                    // __        __    _ _          ___        _               _   
                    // \ \      / / __(_) |_ ___   / _ \ _   _| |_ _ __  _   _| |_ 
                    //  \ \ /\ / / '__| | __/ _ \ | | | | | | | __| '_ \| | | | __|
                    //   \ V  V /| |  | | ||  __/ | |_| | |_| | |_| |_) | |_| | |_ 
                    //    \_/\_/ |_|  |_|\__\___|  \___/ \__,_|\__| .__/ \__,_|\__|
                    //                                            |_|              


                    using (StreamReader inputfile = new StreamReader(fileName, InputSelectedEncoding))
                    {

                        string readText = inputfile.ReadToEnd();
                    
                        //open up the output file
                        using (StreamWriter outputFile = new StreamWriter(new FileStream(Output_Location, FileMode.Create), OutputSelectedEncoding))
                        {
                            outputFile.Write(readText);
                        }
                    }


                });



            }
            catch
            {
                MessageBox.Show("TranscodeTXT encountered an issue somewhere while trying to analyze your texts. The most common cause of this is trying to open your output file(s) while the program is still running. Did any of your input files move, or is your output file being opened/modified by another application?", "Error while transcoding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }


        //when the bgworker is done running, we want to re-enable user controls and let them know that it's finished
        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StartButton.Enabled = true;
            ScanSubfolderCheckbox.Enabled = true;
            InputEncodingDropdown.Enabled = true;
            OutputEncodingDropdown.Enabled = true;
            FileTypeTextbox.Enabled = true;
            FilenameLabel.Text = "Finished!";
            MessageBox.Show("TranscodeTXT has finished processing your texts.", "Transcode Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }







        public class DictionaryData
        {

            public string TextFileFolder { get; set; }
            public string OutputFileLocation { get; set; }
            public string FileExtension { get; set; }

        }


    }
    


}
