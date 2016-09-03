namespace Clipboard_Paste_v2 {
    partial class Main {
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMainItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainItem_fileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainItem_clipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainItem_clipboardClear = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_main = new System.Windows.Forms.ListBox();
            this.toolStripMainItem_clipboardCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMainItem_file,
            this.toolStripMainItem_clipboard});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuStripMain.Size = new System.Drawing.Size(102, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // toolStripMainItem_file
            // 
            this.toolStripMainItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMainItem_fileOpen});
            this.toolStripMainItem_file.Name = "toolStripMainItem_file";
            this.toolStripMainItem_file.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripMainItem_file.Size = new System.Drawing.Size(29, 24);
            this.toolStripMainItem_file.Text = "File";
            // 
            // toolStripMainItem_fileOpen
            // 
            this.toolStripMainItem_fileOpen.Name = "toolStripMainItem_fileOpen";
            this.toolStripMainItem_fileOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMainItem_fileOpen.Text = "Open";
            this.toolStripMainItem_fileOpen.Click += new System.EventHandler(this.toolStripMainItem_fileOpen_Click);
            // 
            // toolStripMainItem_clipboard
            // 
            this.toolStripMainItem_clipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMainItem_clipboardClear,
            this.toolStripMainItem_clipboardCurrent});
            this.toolStripMainItem_clipboard.Name = "toolStripMainItem_clipboard";
            this.toolStripMainItem_clipboard.Size = new System.Drawing.Size(71, 24);
            this.toolStripMainItem_clipboard.Text = "Clipboard";
            // 
            // toolStripMainItem_clipboardClear
            // 
            this.toolStripMainItem_clipboardClear.Name = "toolStripMainItem_clipboardClear";
            this.toolStripMainItem_clipboardClear.Size = new System.Drawing.Size(152, 22);
            this.toolStripMainItem_clipboardClear.Text = "Clear";
            this.toolStripMainItem_clipboardClear.Click += new System.EventHandler(this.toolStripMainItem_clipboardClear_Click);
            // 
            // listBox_main
            // 
            this.listBox_main.AllowDrop = true;
            this.listBox_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.listBox_main.FormattingEnabled = true;
            this.listBox_main.ItemHeight = 20;
            this.listBox_main.Location = new System.Drawing.Point(0, 28);
            this.listBox_main.Margin = new System.Windows.Forms.Padding(0);
            this.listBox_main.Name = "listBox_main";
            this.listBox_main.Size = new System.Drawing.Size(404, 544);
            this.listBox_main.TabIndex = 1;
            this.listBox_main.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_main_DragDrop);
            this.listBox_main.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_main_DragEnter);
            // 
            // toolStripMainItem_clipboardCurrent
            // 
            this.toolStripMainItem_clipboardCurrent.Name = "toolStripMainItem_clipboardCurrent";
            this.toolStripMainItem_clipboardCurrent.Size = new System.Drawing.Size(152, 22);
            this.toolStripMainItem_clipboardCurrent.Text = "Current";
            this.toolStripMainItem_clipboardCurrent.Click += new System.EventHandler(this.toolStripMainItem_clipboardCurrent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 572);
            this.Controls.Add(this.listBox_main);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clipboard Paste";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMainItem_file;
        private System.Windows.Forms.ToolStripMenuItem toolStripMainItem_fileOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMainItem_clipboard;
        private System.Windows.Forms.ToolStripMenuItem toolStripMainItem_clipboardClear;
        private System.Windows.Forms.ListBox listBox_main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMainItem_clipboardCurrent;
    }
}

