﻿using Clipboard_Paste_v2.Properties;
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
        //private static Main instance; // global voids
        // For global voids:
        // must be public static void
        // must be called with Main.FUNCTION()
        public Main() {
            InitializeComponent();
            /*listBox_main.MouseUp += new MouseEventHandler(this.listBox_main_RightClick);*/
            //instance = this; // global voids
        }
        public string currentFileLocation = Settings.Default.FileLocation;

        private void Main_Load(object sender, EventArgs e) {
            if (currentFileLocation != "") {
                addLinesToMainList(currentFileLocation);
            } // First load management
            else {
                File.CreateText(AppDomain.CurrentDomain.BaseDirectory + "default.txt");
                Settings.Default.FileLocation = AppDomain.CurrentDomain.BaseDirectory + "default.txt";
                Settings.Default.Save();
                currentFileLocation = AppDomain.CurrentDomain.BaseDirectory + "default.txt";
            }
            // TODO: save user window location and dimension
        }

        /** Open function from the File toolstrip **/
        private void toolStripMainItem_fileOpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = currentFileLocation;
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                addLinesToMainList(fileDialog.FileName);
                Settings.Default.FileLocation = fileDialog.FileName;
                Settings.Default.Save();
                currentFileLocation = fileDialog.FileName;
            }
        }

        /** List control **/
        public void addLinesToMainList(string filepath) {
            listBox_main.Items.Clear();
            List<string> list_pastas = new List<string>(File.ReadAllLines(filepath));
            listBox_main.Items.AddRange(list_pastas.ToArray());
        }

        /** Drag & Drop functionality support **/
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
                // TODO: make new form with editable textbox for the clipboard contents
            }
            else if (Clipboard.ContainsImage()) {
                MessageBox.Show("Clipboard contains an image.");
                // TODO: make the image to show up
            }
            else if (string.IsNullOrEmpty(Clipboard.GetText())) {
                MessageBox.Show("Clipboard is empty!");
            }
            else {
                MessageBox.Show("Unsupported format?");
            }
            
        }

        private void toolStripMainItem_fileNewEntry_Click(object sender, EventArgs e) {
            FormAddNew f = new FormAddNew();
            f.currentFileLocation = currentFileLocation;
            f.Show();
        }

        //This function duplicates with Main_Load when opening the program for the first time and idk how to do this better
        private void Main_Activated(object sender, EventArgs e) {
            addLinesToMainList(currentFileLocation);
        }

        private void listBox_main_MouseDoubleClick(object sender, MouseEventArgs e) {
            Clipboard.SetText(listBox_main.SelectedItem.ToString());
            lb_copied.Visible = true;
            timer_Copied.Enabled = true;
            timer_Copied.Start();
        }

        private void timer_Copied_Tick(object sender, EventArgs e) {
            lb_copied.Visible = false;
            timer_Copied.Stop();
        }

        private void toolStripMainItem_fileEdit_Click(object sender, EventArgs e) {
            if (listBox_main.SelectedItems.Count == 1) {
                FormEditEntry f = new FormEditEntry();
                f.currentFileLocation = currentFileLocation;
                f.stringToEdit = listBox_main.SelectedItem.ToString();
                f.selectedListIndex = listBox_main.SelectedIndex;
                f.Show();
            }
        }

        /*
        private void listBox_main_RightClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                int index = listBox_main.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches) {
                    listBox_main.Items[index];
                }
            }
        }
        */
        //TODO: make context menu strip usable
    }
}
