namespace Clipboard_Paste_v2 {
    partial class FormEditEntry {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb_EditEntry = new System.Windows.Forms.TextBox();
            this.b_AddNewOK = new System.Windows.Forms.Button();
            this.b_AddNewCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_EditEntry
            // 
            this.tb_EditEntry.Location = new System.Drawing.Point(9, 9);
            this.tb_EditEntry.Margin = new System.Windows.Forms.Padding(0);
            this.tb_EditEntry.Name = "tb_EditEntry";
            this.tb_EditEntry.Size = new System.Drawing.Size(272, 20);
            this.tb_EditEntry.TabIndex = 0;
            this.tb_EditEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AddNew_KeyPress);
            // 
            // b_AddNewOK
            // 
            this.b_AddNewOK.Location = new System.Drawing.Point(90, 32);
            this.b_AddNewOK.Name = "b_AddNewOK";
            this.b_AddNewOK.Size = new System.Drawing.Size(191, 23);
            this.b_AddNewOK.TabIndex = 1;
            this.b_AddNewOK.Text = "OK";
            this.b_AddNewOK.UseVisualStyleBackColor = true;
            this.b_AddNewOK.Click += new System.EventHandler(this.b_AddNewOK_Click);
            // 
            // b_AddNewCancel
            // 
            this.b_AddNewCancel.Location = new System.Drawing.Point(9, 32);
            this.b_AddNewCancel.Name = "b_AddNewCancel";
            this.b_AddNewCancel.Size = new System.Drawing.Size(75, 23);
            this.b_AddNewCancel.TabIndex = 2;
            this.b_AddNewCancel.Text = "Cancel";
            this.b_AddNewCancel.UseVisualStyleBackColor = true;
            this.b_AddNewCancel.Click += new System.EventHandler(this.b_AddNewCancel_Click);
            // 
            // FormEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 65);
            this.Controls.Add(this.b_AddNewCancel);
            this.Controls.Add(this.b_AddNewOK);
            this.Controls.Add(this.tb_EditEntry);
            this.Name = "FormEditEntry";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.FormEditEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EditEntry;
        private System.Windows.Forms.Button b_AddNewOK;
        private System.Windows.Forms.Button b_AddNewCancel;
    }
}