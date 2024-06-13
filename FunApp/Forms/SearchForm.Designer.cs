namespace FunApplication.Forms
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            searchButton = new Button();
            panel1 = new Panel();
            sportBox = new TextBox();
            label23 = new Label();
            clubBox = new TextBox();
            label7 = new Label();
            countryBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            опрограммеToolStripMenuItem = new ToolStripMenuItem();
            козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem = new ToolStripMenuItem();
            додатиСпортсменаToolStripMenuItem = new ToolStripMenuItem();
            sportsmanBindingSource = new BindingSource(components);
            panel2 = new Panel();
            label1 = new Label();
            resultList = new ListBox();
            sportsmanListBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            label4 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            pictureBoxFace = new PictureBox();
            label18 = new Label();
            label22 = new Label();
            label24 = new Label();
            label26 = new Label();
            pictureBoxFlag = new PictureBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            buttonGoBackMainForm = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.PaleGreen;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(464, 239);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(120, 42);
            searchButton.TabIndex = 5;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(sportBox);
            panel1.Controls.Add(label23);
            panel1.Controls.Add(clubBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(countryBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(surnameBox);
            panel1.Controls.Add(nameBox);
            panel1.Location = new Point(12, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 299);
            panel1.TabIndex = 6;
            // 
            // sportBox
            // 
            sportBox.Location = new Point(261, 98);
            sportBox.Name = "sportBox";
            sportBox.Size = new Size(335, 23);
            sportBox.TabIndex = 2;
            sportBox.Validating += sportBox_Validating;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label23.Location = new Point(16, 90);
            label23.Name = "label23";
            label23.Size = new Size(239, 37);
            label23.TabIndex = 16;
            label23.Text = "Введіть вид спорту";
            // 
            // clubBox
            // 
            clubBox.Location = new Point(296, 189);
            clubBox.Name = "clubBox";
            clubBox.Size = new Size(300, 23);
            clubBox.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label7.Location = new Point(13, 180);
            label7.Name = "label7";
            label7.Size = new Size(284, 37);
            label7.TabIndex = 14;
            label7.Text = " Введіть Клуб\\Команда";
            // 
            // countryBox
            // 
            countryBox.Location = new Point(406, 146);
            countryBox.Name = "countryBox";
            countryBox.Size = new Size(190, 23);
            countryBox.TabIndex = 11;
            countryBox.Validating += countryBox_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 9);
            label2.Name = "label2";
            label2.Size = new Size(152, 37);
            label2.TabIndex = 1;
            label2.Text = "Введіть ім'я";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label5.Location = new Point(13, 134);
            label5.Name = "label5";
            label5.Size = new Size(387, 37);
            label5.TabIndex = 10;
            label5.Text = "Введіть рідну країну спортсмена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(16, 53);
            label3.Name = "label3";
            label3.Size = new Size(205, 37);
            label3.TabIndex = 2;
            label3.Text = "Введіть фамілію";
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(224, 60);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(372, 23);
            surnameBox.TabIndex = 5;
            surnameBox.Validating += surnameBox_Validating;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(187, 21);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(409, 23);
            nameBox.TabIndex = 1;
            nameBox.Validating += nameBox_Validating;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem, додатиСпортсменаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, toolStripSeparator, сохранитьToolStripMenuItem, toolStripSeparator1, toolStripSeparator2, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Image = (Image)resources.GetObject("открытьToolStripMenuItem.Image");
            открытьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            открытьToolStripMenuItem.Size = new Size(165, 22);
            открытьToolStripMenuItem.Text = "&Відкрити";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(162, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Image = (Image)resources.GetObject("сохранитьToolStripMenuItem.Image");
            сохранитьToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            сохранитьToolStripMenuItem.Size = new Size(165, 22);
            сохранитьToolStripMenuItem.Text = "&Зберегти";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(162, 6);
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(165, 22);
            выходToolStripMenuItem.Text = "Ви&хід";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator5, опрограммеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "&Справка";
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
            // додатиСпортсменаToolStripMenuItem
            // 
            додатиСпортсменаToolStripMenuItem.Name = "додатиСпортсменаToolStripMenuItem";
            додатиСпортсменаToolStripMenuItem.Size = new Size(127, 20);
            додатиСпортсменаToolStripMenuItem.Text = "Додати спортсмена";
            додатиСпортсменаToolStripMenuItem.Click += додатиСпортсменаToolStripMenuItem_Click;
            // 
            // sportsmanBindingSource
            // 
            sportsmanBindingSource.DataSource = typeof(Models.SportsmanList);
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(resultList);
            panel2.Location = new Point(28, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 210);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(200, 28);
            label1.TabIndex = 1;
            label1.Text = "Знайдені спортсмени :";
            // 
            // resultList
            // 
            resultList.BackColor = Color.MediumAquamarine;
            resultList.DataSource = sportsmanListBindingSource;
            resultList.DisplayMember = "Name";
            resultList.FormattingEnabled = true;
            resultList.ItemHeight = 15;
            resultList.Location = new Point(15, 46);
            resultList.Name = "resultList";
            resultList.Size = new Size(336, 154);
            resultList.TabIndex = 0;
            resultList.ValueMember = "Name";
            resultList.Click += resultList_Click;
            resultList.DoubleClick += resultList_DoubleClick_1;
            // 
            // sportsmanListBindingSource
            // 
            sportsmanListBindingSource.DataSource = typeof(Models.SportsmanList);
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(31, 46);
            label17.Name = "label17";
            label17.Size = new Size(63, 37);
            label17.TabIndex = 24;
            label17.Text = "Ім'я:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(31, 86);
            label16.Name = "label16";
            label16.Size = new Size(123, 37);
            label16.TabIndex = 25;
            label16.Text = "Прізвище:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(31, 132);
            label15.Name = "label15";
            label15.Size = new Size(57, 37);
            label15.TabIndex = 26;
            label15.Text = "Вік:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(31, 177);
            label14.Name = "label14";
            label14.Size = new Size(89, 37);
            label14.TabIndex = 27;
            label14.Text = "Зріст:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(31, 262);
            label13.Name = "label13";
            label13.Size = new Size(155, 37);
            label13.TabIndex = 28;
            label13.Text = "Рідна країна:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(31, 214);
            label12.Name = "label12";
            label12.Size = new Size(73, 37);
            label12.TabIndex = 29;
            label12.Text = "Вага:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(31, 313);
            label11.Name = "label11";
            label11.Size = new Size(187, 37);
            label11.TabIndex = 30;
            label11.Text = "Клуб\\Команда:";
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
            // label20
            // 
            label20.AutoSize = true;
            label20.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Surname", true));
            label20.Font = new Font("Times New Roman", 14.25F);
            label20.Location = new Point(149, 97);
            label20.Name = "label20";
            label20.Size = new Size(16, 21);
            label20.TabIndex = 33;
            label20.Text = "-";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.DataBindings.Add(new Binding("Text", sportsmanListBindingSource, "Club", true));
            label6.Font = new Font("Times New Roman", 14.25F);
            label6.Location = new Point(224, 324);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 38;
            label6.Text = "NON";
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Times New Roman", 14.25F);
            label18.Location = new Point(135, 225);
            label18.Name = "label18";
            label18.Size = new Size(38, 21);
            label18.TabIndex = 40;
            label18.Text = "- кг";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Times New Roman", 14.25F);
            label22.Location = new Point(149, 188);
            label22.Name = "label22";
            label22.Size = new Size(42, 21);
            label22.TabIndex = 41;
            label22.Text = "- см";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Times New Roman", 14.25F);
            label24.Location = new Point(111, 143);
            label24.Name = "label24";
            label24.Size = new Size(36, 21);
            label24.TabIndex = 42;
            label24.Text = "- р.";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold);
            label26.ForeColor = SystemColors.ControlLightLight;
            label26.Location = new Point(31, 367);
            label26.Name = "label26";
            label26.Size = new Size(176, 37);
            label26.TabIndex = 43;
            label26.Text = "Особисті дані:";
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Location = new Point(292, 253);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(62, 55);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.TabIndex = 45;
            pictureBoxFlag.TabStop = false;
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
            // panel3
            // 
            panel3.BackColor = Color.MediumAquamarine;
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
            panel3.Location = new Point(652, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(513, 562);
            panel3.TabIndex = 12;
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
            buttonGoBackMainForm.Location = new Point(0, 27);
            buttonGoBackMainForm.Name = "buttonGoBackMainForm";
            buttonGoBackMainForm.Size = new Size(57, 56);
            buttonGoBackMainForm.TabIndex = 18;
            buttonGoBackMainForm.UseVisualStyleBackColor = false;
            buttonGoBackMainForm.Click += buttonGoBackMainForm_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1200, 617);
            Controls.Add(buttonGoBackMainForm);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1216, 656);
            MinimumSize = new Size(1216, 656);
            Name = "SearchForm";
            Text = "Пошук спортсмена";
            FormClosing += SearchForm_FormClosing_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sportsmanListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchButton;
        private Panel panel1;
        private TextBox surnameBox;
        private TextBox nameBox;
        private Label label3;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private TextBox countryBox;
        private Label label5;
        private TextBox clubBox;
        private Label label7;
        private BindingSource sportsmanBindingSource;
        private Panel panel2;
        private Label label1;
        private ListBox resultList;
        private TextBox sportBox;
        private Label label23;
        private BindingSource bindingSource1;
        private Label label4;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private PictureBox pictureBoxFace;
        private Label label18;
        private Label label22;
        private Label label24;
        private Label label26;
        private PictureBox pictureBoxFlag;
        private TextBox textBox1;
        private Panel panel3;
        private Button buttonGoBackMainForm;
        private BindingSource sportsmanListBindingSource;
        private ToolStripMenuItem козловСергійПЗПІ238ДовідникФанатаToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem додатиСпортсменаToolStripMenuItem;
    }
}