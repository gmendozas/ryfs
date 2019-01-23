using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ryfs
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> _scripts = new Dictionary<string, string>();
        private JPropertiesFileReader jReader;

        public Form1()
        {
            jReader = new JPropertiesFileReader("scripts_properties.json");
            _scripts = jReader.ReadFileContent();

            InitializeComponent();
            scriptsListBox.DataSource = _scripts.Keys.ToArray<string>();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Running!");
                loggingRunAction();
            } catch(Exception ex)
            {
                MessageBox.Show("An error has ocurred while the script was running.");
                loggingRunAction(true, ex.Message);

            }
            scriptsListBox.ClearSelected();
            runButton.Enabled = false;
        }

        private void scriptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(scriptsListBox.SelectedIndex >= 0)
                runButton.Enabled = true;
        }

        private void loggingRunAction(bool isError = false, string customMessage = "")
        {
            logTextBox.AppendText(string.Format("Running the script: {0}\n", isError ? customMessage : scriptsListBox.SelectedItem));
        }

        private void addScriptButton_Click(object sender, EventArgs e)
        {
            //if(!object.Equals(null, _items))
            //{
            //    _items.Add(string.Format("Script{0}", (_items.Count + 1).ToString()));
            //    scriptsListBox.DataSource = null;
            //    scriptsListBox.DataSource = _items;
            //}
        }

        private void scriptsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (scriptsListBox.SelectedIndex >= 0)
            {
                runButton_Click(sender, e);
            }
        }
    }
}
