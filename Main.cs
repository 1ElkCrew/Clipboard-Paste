using Clipboard_Paste_v2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clipboard_Paste_v2 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }
        public string currentFileLocation = Settings.Default.FileLocation;

        private void Main_Load(object sender, EventArgs e) {
            if (currentFileLocation != "") {
                addLinesToMainList(currentFileLocation);
            }
            else {
                File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "default.txt");
                Settings.Default.FileLocation = AppDomain.CurrentDomain.BaseDirectory + "default.txt";
                Settings.Default.Save();
                currentFileLocation = AppDomain.CurrentDomain.BaseDirectory + "default.txt";
            }
        }

        private void toolStripMainItem_fileOpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = currentFileLocation;
            string name;
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                name = fileDialog.FileName;
                addLinesToMainList(name);
                Settings.Default.FileLocation = name;
                Settings.Default.Save();
                currentFileLocation = name;
            }
        }

        private void addLinesToMainList(string filepath) {
            listBox_main.Items.Clear();
            List<string> list_pastas = new List<string>(File.ReadAllLines(filepath));
            listBox_main.Items.AddRange(list_pastas.ToArray());
        }

        private void listBox_main_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1) {
                addLinesToMainList(files[0]);
                //foreach (string file in files)
                //    list_pastas.Add(file);
                // TODO: allow multiple files
            }
            else { MessageBox.Show("Only one file at a time is allowed!"); }
        }

        private void listBox_main_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Link;
        }

        private void toolStripMainItem_clipboardClear_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void toolStripMainItem_clipboardCurrent_Click(object sender, EventArgs e) {
            if (Clipboard.ContainsText()) {
                MessageBox.Show("Current clipboard contents:\n" + Clipboard.GetData(DataFormats.Text).ToString());
                //TextBox tb = new TextBox();
                //tb.Visible = true;
                //tb.Text = Clipboard.GetData(DataFormats.Text).ToString();
                //tb.Show();
                // TODO: make new form with editable textbox for the clipboard contents
            }
            else if (Clipboard.ContainsImage()) {
                MessageBox.Show("Clipboard contains an image.");
                // TODO: make the image to show up
            }
            else {
                MessageBox.Show("Unsupported format?");
            }
            
        }
    }
}
