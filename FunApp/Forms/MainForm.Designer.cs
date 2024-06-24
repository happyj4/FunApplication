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
            panel3 = new Panel();
            buttonToSportsmenRecordForm = new Button();
            buttonMainFormToSearch = new Button();
            panel1 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            buttonToSportsmenRecordForm.Text = "Start looking for record-breaking athletes ";
            buttonToSportsmenRecordForm.UseVisualStyleBackColor = false;
            buttonToSportsmenRecordForm.Click += buttonToSportsmenRecordForm_Click;
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
            buttonMainFormToSearch.Text = "Start looking for athletes ";
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
            panel1.Size = new Size(322, 162);
            panel1.TabIndex = 3;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1206, 661);
            MinimumSize = new Size(1206, 661);
            Name = "MainForm";
            Text = "Fan guide ";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button buttonToSportsmenRecordForm;
        private Button buttonMainFormToSearch;
        private Panel panel1;
    }
}