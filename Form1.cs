using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Extract_Files
{
    public partial class frmExtract : Form
    {
        public frmExtract()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = openFileDialog.FileName;
                fileOutputPath.Text = Path.Combine(Path.GetDirectoryName(filePathTextBox.Text), Path.GetFileNameWithoutExtension(filePathTextBox.Text) + "_output_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss")
                    + Path.GetExtension(filePathTextBox.Text));
            }
            this.lstMessages.Items.Add("Input file is selected");
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(filePathTextBox.Text))
                {
                    MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] values1 = null;
                string[] selectedColumns = txtColumns.Text.Split(',');
                using (var reader0 = new StreamReader(filePathTextBox.Text))
                {
                    //while (reader0.Peek() != -1)
                    for(int i=0; i < 1; i++)
                    {
                        var line1 = reader0.ReadLine();
                        values1 = line1.Split(',');
                    }
                }
                    List<int> columnIndices = new List<int>();
                //columnIndices = selectedColumns.

                foreach (var column in selectedColumns)
                {
                    //if (!int.TryParse(column.Trim(), out int columnIndex))
                    //{
                    //    MessageBox.Show("Invalid column index!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    columnIndices.Add(Array.IndexOf(values1,column));
                }

                string outputPath = fileOutputPath.Text;
                using (var reader = new StreamReader(filePathTextBox.Text))
                using (var writer = new StreamWriter(outputPath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var selectedValues = columnIndices.Select(index => index >= 0 && index < values.Length ? values[index] : "").ToArray();
                        var newLine = string.Join(",", selectedValues);
                        if (newLine.EndsWith(","))
                        {
                           newLine = newLine.Substring(0,newLine.Length-1);
                        }
                        writer.WriteLine(newLine);
                    }
                }
                this.lstMessages.Items.Add("Success: Extraction is completed and file generated.");

                //MessageBox.Show("Extraction complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.lstMessages.Items.Add("Error: " + ex.Message);
                //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFileType_SelectedValueChanged(object sender, EventArgs e)
        {
            // Path to the JSON file

            string LPath;
            var Location = AppDomain.CurrentDomain.BaseDirectory + "Data\\Map.json";
            int index;
            index = Location.IndexOf("bin");
            if (index > 0)
            {
                LPath = Location.Remove(index, 25);
            }
            else
            {
                LPath = Location;
            }

            //string jsonFilePath = @"C:\xampp\htdocs\dklabs\Extract_Files\Data\Map.json";
            string jsonFilePath = LPath;
            try
            {
                // Read the file into a string and deserialize JSON to a type dynamic
                var jsonData = File.ReadAllText(jsonFilePath);
                JObject jsonObject = JObject.Parse(jsonData);

                // Create a display string from the JSON object
                string displayText = "";               

                displayText = jsonObject[cmbFileType.SelectedItem.ToString()].ToString();

                // Set the text box text
                txtColumns.Text = displayText;
                this.lstMessages.Items.Add("File Type is changed and set");
            }
            catch (Exception ex)
            {
                // Show error message if the operation fails
                this.lstMessages.Items.Add("Error: " + ex.Message);
                //MessageBox.Show("Error reading or parsing JSON: " + ex.Message);
            }
        }

        
        private void frmExtract_Load(object sender, EventArgs e)
        {
            this.lstMessages.Items.Clear();
            this.lstMessages.Items.Add("All Set for Extraction");
            // Path to the JSON file
            string LPath;
            var Location = AppDomain.CurrentDomain.BaseDirectory + "Data\\Map.json";
            int index;
            index = Location.IndexOf("bin");
            if(index > 0)
            {
                LPath = Location.Remove(index, 25);                
            }
            else
            {
                LPath = Location;
            }
            // string jsonFilePath2 = @"C:\xampp\htdocs\dklabs\Extract_Files\Data\Map.json";
            string jsonFilePath2 = LPath;
            try
            {
                // Read the file into a string and deserialize JSON to a type dynamic
                var jsonData = File.ReadAllText(jsonFilePath2);
                JObject jsonObject = JObject.Parse(jsonData);
                List<string> valist = new List<string>();

                // Create a display string from the JSON object
                
                foreach (var item in jsonObject)
                {
                    valist.Add(item.Key.ToString());

                    // displayText += $"{item.Value}\n";

                }
                                
                // Set the text box text
                //txtColumns.Text = displayText;
                cmbFileType.DataSource = valist;
            }
            catch (Exception ex)
            {
                // Show error message if the operation fails
                this.lstMessages.Items.Add("Error: " + ex.Message);
                //MessageBox.Show("Error reading or parsing JSON: " + ex.Message);
            }
        }
    }
}

    