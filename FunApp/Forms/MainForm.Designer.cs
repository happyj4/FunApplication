namespace FunApplication.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripMainForm = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem = new ToolStripMenuItem();
            buttonMainFormToSearch = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            buttonToSportsmenRecordForm = new Button();
            menuStripMainForm.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainForm
            // 
            menuStripMainForm.Dock = DockStyle.None;
            menuStripMainForm.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStripMainForm.Location = new Point(0, 0);
            menuStripMainForm.Name = "menuStripMainForm";
            menuStripMainForm.Size = new Size(117, 24);
            menuStripMainForm.TabIndex = 0;
            menuStripMainForm.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator, toolStripSeparator1, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(100, 6);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(100, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(100, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(103, 22);
            выходToolStripMenuItem.Text = "Ви&хід";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(61, 20);
            справкаToolStripMenuItem.Text = "&Довідка";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            опрограммеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem });
            опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            опрограммеToolStripMenuItem.Size = new Size(158, 22);
            опрограммеToolStripMenuItem.Text = "&О программе…";
            // 
            // козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem
            // 
            козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem.Name = "козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem";
            козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem.Size = new Size(323, 22);
            козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem.Text = "© Козлов Сергій ПЗПІ-23-8  Довідник фаната";
            // 
            // buttonMainFormToSearch
            // 
            buttonMainFormToSearch.BackColor = Color.MediumSeaGreen;
            buttonMainFormToSearch.Cursor = Cursors.Hand;
            buttonMainFormToSearch.FlatAppearance.BorderSize = 0;
            buttonMainFormToSearch.FlatStyle = FlatStyle.Popup;
            buttonMainFormToSearch.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMainFormToSearch.ForeColor = SystemColors.ButtonHighlight;
            buttonMainFormToSearch.Location = new Point(25, 25);
            buttonMainFormToSearch.Name = "buttonMainFormToSearch";
            buttonMainFormToSearch.Size = new Size(271, 105);
            buttonMainFormToSearch.TabIndex = 2;
            buttonMainFormToSearch.Text = "Почати пошук спортсменів";
            buttonMainFormToSearch.UseVisualStyleBackColor = false;
            buttonMainFormToSearch.Click += buttonMainFormToSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(buttonMainFormToSearch);
            panel1.Location = new Point(665, 265);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 156);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(buttonToSportsmenRecordForm);
            panel3.Location = new Point(194, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 156);
            panel3.TabIndex = 4;
            // 
            // buttonToSportsmenRecordForm
            // 
            buttonToSportsmenRecordForm.BackColor = Color.MediumSeaGreen;
            buttonToSportsmenRecordForm.Cursor = Cursors.Hand;
            buttonToSportsmenRecordForm.FlatAppearance.BorderSize = 0;
            buttonToSportsmenRecordForm.FlatStyle = FlatStyle.Popup;
            buttonToSportsmenRecordForm.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonToSportsmenRecordForm.ForeColor = SystemColors.ButtonHighlight;
            buttonToSportsmenRecordForm.Location = new Point(13, 25);
            buttonToSportsmenRecordForm.Name = "buttonToSportsmenRecordForm";
            buttonToSportsmenRecordForm.Size = new Size(271, 105);
            buttonToSportsmenRecordForm.TabIndex = 2;
            buttonToSportsmenRecordForm.Text = "Почати пошук рекордсменів в спорті";
            buttonToSportsmenRecordForm.UseVisualStyleBackColor = false;
            buttonToSportsmenRecordForm.Click += buttonToSportsmenRecordForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1190, 622);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(menuStripMainForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMainForm;
            MaximumSize = new Size(1206, 661);
            MinimumSize = new Size(844, 661);
            Name = "MainForm";
            Text = "Довідник фаната";
            menuStripMainForm.ResumeLayout(false);
            menuStripMainForm.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private ToolStripMenuItem козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem;
        private Button buttonMainFormToSearch;
        private Panel panel1;
        private Panel panel3;
        private Button buttonToSportsmenRecordForm;
    }
}