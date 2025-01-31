namespace FunApplication.Forms
{
    partial class SportsmenRecordForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportsmenRecordForm));
            panel1 = new Panel();
            label1 = new Label();
            sportBox = new TextBox();
            label23 = new Label();
            resultListRecord = new ListBox();
            sportsmanListBindingSource = new BindingSource(components);
            searchButton = new Button();
            panel3 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBoxFlag = new PictureBox();
            label26 = new Label();
            label24 = new Label();
            label22 = new Label();
            label18 = new Label();
            pictureBoxFace = new PictureBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label4 = new Label();
            buttonGoBackMainForm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanListBindingSource).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sportBox);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(resultListRecord);
            panel1.Controls.Add(searchButton);
            panel1.Location = new Point(12, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 308);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 75);
            label1.Name = "label1";
            label1.Size = new Size(166, 28);
            label1.TabIndex = 33;
            label1.Text = "Знайдені атлети :";
            // 
            // sportBox
            // 
            sportBox.Location = new Point(190, 33);
            sportBox.Name = "sportBox";
            sportBox.Size = new Size(187, 23);
            sportBox.TabIndex = 32;
            sportBox.Validating += sportBox_Validating;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label23.Location = new Point(15, 21);
            label23.Name = "label23";
            label23.Size = new Size(170, 37);
            label23.TabIndex = 31;
            label23.Text = "Вид спорту -";
            // 
            // resultListRecord
            // 
            resultListRecord.BackColor = Color.MediumAquamarine;
            resultListRecord.BorderStyle = BorderStyle.FixedSingle;
            resultListRecord.DataSource = sportsmanListBindingSource;
            resultListRecord.DisplayMember = "Name";
            resultListRecord.FormattingEnabled = true;
            resultListRecord.ItemHeight = 15;
            resultListRecord.Location = new Point(15, 110);
            resultListRecord.Name = "resultListRecord";
            resultListRecord.Size = new Size(367, 152);
            resultListRecord.TabIndex = 22;
            resultListRecord.ValueMember = "Name";
            resultListRecord.DoubleClick += resultListRecord_DoubleClick;
            // 
            // sportsmanListBindingSource
            // 
            sportsmanListBindingSource.DataSource = typeof(Models.SportsmanList);
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.PaleGreen;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(432, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(120, 42);
            searchButton.TabIndex = 20;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumAquamarine;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBoxFlag);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(pictureBoxFace);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(669, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(513, 562);
            panel3.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(313, 338);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 49;
            label5.Text = "Point";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "sportsRecord", true));
            label2.Font = new Font("Times New Roman", 14.25F);
            label2.Location = new Point(264, 342);
            label2.Name = "label2";
            label2.Size = new Size(16, 21);
            label2.TabIndex = 48;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(31, 334);
            label3.Name = "label3";
            label3.Size = new Size(102, 33);
            label3.TabIndex = 47;
            label3.Text = "Рекорд -";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "aboutSportsman", true));
            textBox1.Enabled = false;
            textBox1.Location = new Point(42, 406);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 131);
            textBox1.TabIndex = 46;
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Location = new Point(292, 240);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(62, 55);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.TabIndex = 45;
            pictureBoxFlag.TabStop = false;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label26.ForeColor = SystemColors.ControlLightLight;
            label26.Location = new Point(31, 367);
            label26.Name = "label26";
            label26.Size = new Size(276, 33);
            label26.TabIndex = 43;
            label26.Text = "Персональна інформація -";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 14.25F);
            label24.Location = new Point(111, 143);
            label24.Name = "label24";
            label24.Size = new Size(70, 21);
            label24.TabIndex = 42;
            label24.Text = "- years .";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 14.25F);
            label22.Location = new Point(149, 188);
            label22.Name = "label22";
            label22.Size = new Size(44, 21);
            label22.TabIndex = 41;
            label22.Text = "- cm";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 14.25F);
            label18.Location = new Point(135, 225);
            label18.Name = "label18";
            label18.Size = new Size(39, 21);
            label18.TabIndex = 40;
            label18.Text = "- kg";
            // 
            // pictureBoxFace
            // 
            pictureBoxFace.ImageLocation = "";
            pictureBoxFace.Location = new Point(292, 21);
            pictureBoxFace.Name = "pictureBoxFace";
            pictureBoxFace.Size = new Size(179, 164);
            pictureBoxFace.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFace.TabIndex = 39;
            pictureBoxFace.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Club", true));
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(236, 303);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 38;
            label6.Text = "NON";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Weight", true));
            label8.Font = new Font("Times New Roman", 14.25F);
            label8.Location = new Point(101, 225);
            label8.Name = "label8";
            label8.Size = new Size(16, 21);
            label8.TabIndex = 37;
            label8.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Country", true));
            label9.Font = new Font("Times New Roman", 14.25F);
            label9.Location = new Point(192, 273);
            label9.Name = "label9";
            label9.Size = new Size(16, 21);
            label9.TabIndex = 36;
            label9.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Height", true));
            label10.Font = new Font("Times New Roman", 14.25F);
            label10.Location = new Point(111, 188);
            label10.Name = "label10";
            label10.Size = new Size(16, 21);
            label10.TabIndex = 35;
            label10.Text = "-";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Age", true));
            label19.Font = new Font("Times New Roman", 14.25F);
            label19.Location = new Point(79, 143);
            label19.Name = "label19";
            label19.Size = new Size(16, 21);
            label19.TabIndex = 34;
            label19.Text = "-";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Surname", true));
            label20.Font = new Font("Times New Roman", 14.25F);
            label20.Location = new Point(145, 94);
            label20.Name = "label20";
            label20.Size = new Size(16, 21);
            label20.TabIndex = 33;
            label20.Text = "-";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Name", true));
            label21.Font = new Font("Times New Roman", 14.25F);
            label21.Location = new Point(91, 57);
            label21.Name = "label21";
            label21.Size = new Size(16, 21);
            label21.TabIndex = 32;
            label21.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(31, 295);
            label11.Name = "label11";
            label11.Size = new Size(211, 33);
            label11.TabIndex = 30;
            label11.Text = "Клуб \\ Команада -";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(31, 214);
            label12.Name = "label12";
            label12.Size = new Size(81, 33);
            label12.TabIndex = 29;
            label12.Text = "Вага -";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(31, 262);
            label13.Name = "label13";
            label13.Size = new Size(154, 33);
            label13.TabIndex = 28;
            label13.Text = "Рідна країна -";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(31, 177);
            label14.Name = "label14";
            label14.Size = new Size(93, 33);
            label14.TabIndex = 27;
            label14.Text = "Зріст -";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(31, 132);
            label15.Name = "label15";
            label15.Size = new Size(66, 33);
            label15.TabIndex = 26;
            label15.Text = "Вік -";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(31, 86);
            label16.Name = "label16";
            label16.Size = new Size(126, 33);
            label16.TabIndex = 25;
            label16.Text = "Прізвище -";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(31, 46);
            label17.Name = "label17";
            label17.Size = new Size(52, 33);
            label17.TabIndex = 24;
            label17.Text = "Ім'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label4.Location = new Point(16, 9);
            label4.Name = "label4";
            label4.Size = new Size(145, 37);
            label4.TabIndex = 11;
            label4.Text = "Спортсмен";
            // 
            // buttonGoBackMainForm
            // 
            buttonGoBackMainForm.BackColor = Color.Transparent;
            buttonGoBackMainForm.BackgroundImage = (Image)resources.GetObject("buttonGoBackMainForm.BackgroundImage");
            buttonGoBackMainForm.BackgroundImageLayout = ImageLayout.Center;
            buttonGoBackMainForm.Cursor = Cursors.Hand;
            buttonGoBackMainForm.FlatAppearance.BorderSize = 0;
            buttonGoBackMainForm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonGoBackMainForm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonGoBackMainForm.FlatStyle = FlatStyle.Flat;
            buttonGoBackMainForm.Location = new Point(12, -11);
            buttonGoBackMainForm.Name = "buttonGoBackMainForm";
            buttonGoBackMainForm.Size = new Size(63, 54);
            buttonGoBackMainForm.TabIndex = 14;
            buttonGoBackMainForm.UseVisualStyleBackColor = false;
            buttonGoBackMainForm.Click += buttonGoBackMainForm_Click;
            // 
            // SportsmenRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 680);
            Controls.Add(buttonGoBackMainForm);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1210, 719);
            MinimumSize = new Size(1210, 719);
            Name = "SportsmenRecordForm";
            Text = "Пошук рекордсменів";
            FormClosing += SportsmenRecordForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanListBindingSource).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button searchButton;
        private Panel panel3;
        private TextBox textBox1;
        private PictureBox pictureBoxFlag;
        private Label label26;
        private Label label24;
        private Label label22;
        private Label label18;
        private PictureBox pictureBoxFace;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label4;
        private Button buttonGoBackMainForm;
        private BindingSource sportsmanlistBindingSource;
        private Label label2;
        private Label label3;
        private ListBox resultListRecord;
        private BindingSource sportsmanListBindingSource;
        private TextBox sportBox;
        private Label label23;
        private Label label1;
        private Label label5;
    }
}