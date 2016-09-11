using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Clipboard_Paste_v2 {
    public partial class FormEditEntry : Form {
        public FormEditEntry() {
            InitializeComponent();
        }
        
        public string currentFileLocation { get; set; }
        public string stringToEdit { get; set; }
        public int selectedListIndex { get; set; }

        private void FormEditEntry_Load(object sender, EventArgs e) {
            tb_EditEntry.Text = stringToEdit;
        }

        private void b_AddNewCancel_Click(object sender, EventArgs e) {
            closeForm();
        }

        private void b_AddNewOK_Click(object sender, EventArgs e) {
            if (tb_EditEntry.Text.Trim().Length == 0) {
                MessageBox.Show("Input cannot be empty!");
            }
            else {
                addInputToFile(currentFileLocation);
            }
        }

        private void tb_AddNew_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == '\r') { // '\r' is Enter, I'd want a more elegant solution
                if (tb_EditEntry.Text.Trim().Length == 0) {
                    MessageBox.Show("Input cannot be empty!");
                }
                else {
                    addInputToFile(currentFileLocation);
                }
            }
            else if (e.KeyChar == '\u001b') { // Escape
                closeForm();
            }
            else if (e.KeyChar == '\u0017') { // Ctrl + W
                closeForm();
            }
        }

        /** List control **/
        public void addInputToFile(string filepath) {
            List<string> lst = new List<string>(File.ReadAllLines(filepath));
            lst.RemoveAt(selectedListIndex);
            lst.Insert(selectedListIndex, tb_EditEntry.Text);
            File.WriteAllLines(filepath, lst.ToArray());
            closeForm();
        }
        private void closeForm() {
            FormEditEntry f = this;
            f.Close();
        }

        
    }
}
