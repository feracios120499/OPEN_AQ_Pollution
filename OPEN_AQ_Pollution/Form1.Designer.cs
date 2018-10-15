namespace OPEN_AQ_Pollution
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.line = new System.Windows.Forms.Panel();
            this.panelPanels = new System.Windows.Forms.Panel();
            this.panelCity = new System.Windows.Forms.Panel();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxPollution = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPollution = new System.Windows.Forms.Panel();
            this.panelCountry = new System.Windows.Forms.Panel();
            this.buttonPollution = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCountry = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.comboBoxCountryPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxCountryPollution = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPollutionPeriod = new System.Windows.Forms.ComboBox();
            this.comboBoxPollutionCities = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartCountry1 = new OPEN_AQ_Pollution.ChartCountry();
            this.chartPollution1 = new OPEN_AQ_Pollution.ChartPollution();
            this.chartPollutionCity1 = new OPEN_AQ_Pollution.ChartPollutionCity();
            this.panelPanels.SuspendLayout();
            this.panelCity.SuspendLayout();
            this.panelPollution.SuspendLayout();
            this.panelCountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.White;
            this.line.ForeColor = System.Drawing.Color.White;
            this.line.Location = new System.Drawing.Point(-3, 140);
            this.line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(11, 66);
            this.line.TabIndex = 3;
            // 
            // panelPanels
            // 
            this.panelPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPanels.BackColor = System.Drawing.Color.Transparent;
            this.panelPanels.Controls.Add(this.panelPollution);
            this.panelPanels.Controls.Add(this.panelCountry);
            this.panelPanels.Controls.Add(this.panelCity);
            this.panelPanels.Location = new System.Drawing.Point(277, 71);
            this.panelPanels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPanels.Name = "panelPanels";
            this.panelPanels.Size = new System.Drawing.Size(1113, 839);
            this.panelPanels.TabIndex = 2;
            // 
            // panelCity
            // 
            this.panelCity.Controls.Add(this.chartPollution1);
            this.panelCity.Controls.Add(this.comboBoxPeriod);
            this.panelCity.Controls.Add(this.comboBoxCity);
            this.panelCity.Controls.Add(this.comboBoxPollution);
            this.panelCity.Controls.Add(this.label3);
            this.panelCity.Controls.Add(this.label1);
            this.panelCity.Controls.Add(this.label2);
            this.panelCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCity.Location = new System.Drawing.Point(0, 0);
            this.panelCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCity.Name = "panelCity";
            this.panelCity.Size = new System.Drawing.Size(1113, 839);
            this.panelCity.TabIndex = 0;
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Неделя",
            "Месяц"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(683, 18);
            this.comboBoxPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(193, 24);
            this.comboBoxPeriod.TabIndex = 5;
            this.comboBoxPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(93, 18);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(193, 24);
            this.comboBoxCity.TabIndex = 5;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxPollution
            // 
            this.comboBoxPollution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPollution.FormattingEnabled = true;
            this.comboBoxPollution.Location = new System.Drawing.Point(413, 18);
            this.comboBoxPollution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPollution.Name = "comboBoxPollution";
            this.comboBoxPollution.Size = new System.Drawing.Size(193, 24);
            this.comboBoxPollution.TabIndex = 5;
            this.comboBoxPollution.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(613, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Период:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Загрязнение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Города:";
            // 
            // panelPollution
            // 
            this.panelPollution.Controls.Add(this.chartPollutionCity1);
            this.panelPollution.Controls.Add(this.comboBoxPollutionPeriod);
            this.panelPollution.Controls.Add(this.comboBoxPollutionCities);
            this.panelPollution.Controls.Add(this.label7);
            this.panelPollution.Controls.Add(this.label9);
            this.panelPollution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPollution.Location = new System.Drawing.Point(0, 0);
            this.panelPollution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPollution.Name = "panelPollution";
            this.panelPollution.Size = new System.Drawing.Size(1113, 839);
            this.panelPollution.TabIndex = 1;
            // 
            // panelCountry
            // 
            this.panelCountry.Controls.Add(this.chartCountry1);
            this.panelCountry.Controls.Add(this.comboBoxCountryPeriod);
            this.panelCountry.Controls.Add(this.comboBoxCountry);
            this.panelCountry.Controls.Add(this.comboBoxCountryPollution);
            this.panelCountry.Controls.Add(this.label4);
            this.panelCountry.Controls.Add(this.label5);
            this.panelCountry.Controls.Add(this.label6);
            this.panelCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCountry.Location = new System.Drawing.Point(0, 0);
            this.panelCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCountry.Name = "panelCountry";
            this.panelCountry.Size = new System.Drawing.Size(1113, 839);
            this.panelCountry.TabIndex = 1;
            this.panelCountry.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCountry_Paint);
            // 
            // buttonPollution
            // 
            this.buttonPollution.Activecolor = System.Drawing.Color.Blue;
            this.buttonPollution.BackColor = System.Drawing.Color.Transparent;
            this.buttonPollution.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPollution.BorderRadius = 0;
            this.buttonPollution.ButtonText = "Загрязнители";
            this.buttonPollution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPollution.DisabledColor = System.Drawing.Color.Gray;
            this.buttonPollution.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonPollution.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonPollution.Iconimage")));
            this.buttonPollution.Iconimage_right = null;
            this.buttonPollution.Iconimage_right_Selected = null;
            this.buttonPollution.Iconimage_Selected = null;
            this.buttonPollution.IconMarginLeft = 30;
            this.buttonPollution.IconMarginRight = 0;
            this.buttonPollution.IconRightVisible = true;
            this.buttonPollution.IconRightZoom = 0D;
            this.buttonPollution.IconVisible = true;
            this.buttonPollution.IconZoom = 90D;
            this.buttonPollution.IsTab = false;
            this.buttonPollution.Location = new System.Drawing.Point(0, 340);
            this.buttonPollution.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPollution.Name = "buttonPollution";
            this.buttonPollution.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonPollution.OnHovercolor = System.Drawing.Color.Blue;
            this.buttonPollution.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonPollution.selected = false;
            this.buttonPollution.Size = new System.Drawing.Size(349, 66);
            this.buttonPollution.TabIndex = 1;
            this.buttonPollution.Text = "Загрязнители";
            this.buttonPollution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonPollution.Textcolor = System.Drawing.Color.White;
            this.buttonPollution.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPollution.Click += new System.EventHandler(this.buttonPollution_Click);
            // 
            // buttonCountry
            // 
            this.buttonCountry.Activecolor = System.Drawing.Color.Blue;
            this.buttonCountry.BackColor = System.Drawing.Color.Transparent;
            this.buttonCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCountry.BorderRadius = 0;
            this.buttonCountry.ButtonText = "Страны";
            this.buttonCountry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCountry.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCountry.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCountry.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCountry.Iconimage")));
            this.buttonCountry.Iconimage_right = null;
            this.buttonCountry.Iconimage_right_Selected = null;
            this.buttonCountry.Iconimage_Selected = null;
            this.buttonCountry.IconMarginLeft = 30;
            this.buttonCountry.IconMarginRight = 0;
            this.buttonCountry.IconRightVisible = true;
            this.buttonCountry.IconRightZoom = 0D;
            this.buttonCountry.IconVisible = true;
            this.buttonCountry.IconZoom = 90D;
            this.buttonCountry.IsTab = false;
            this.buttonCountry.Location = new System.Drawing.Point(0, 240);
            this.buttonCountry.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCountry.Name = "buttonCountry";
            this.buttonCountry.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCountry.OnHovercolor = System.Drawing.Color.Blue;
            this.buttonCountry.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCountry.selected = false;
            this.buttonCountry.Size = new System.Drawing.Size(349, 66);
            this.buttonCountry.TabIndex = 1;
            this.buttonCountry.Text = "Страны";
            this.buttonCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCountry.Textcolor = System.Drawing.Color.White;
            this.buttonCountry.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCountry.Click += new System.EventHandler(this.buttonCountry_Click);
            // 
            // buttonCity
            // 
            this.buttonCity.Activecolor = System.Drawing.Color.Blue;
            this.buttonCity.BackColor = System.Drawing.Color.Transparent;
            this.buttonCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCity.BorderRadius = 0;
            this.buttonCity.ButtonText = "Города";
            this.buttonCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCity.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCity.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCity.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonCity.Iconimage")));
            this.buttonCity.Iconimage_right = null;
            this.buttonCity.Iconimage_right_Selected = null;
            this.buttonCity.Iconimage_Selected = null;
            this.buttonCity.IconMarginLeft = 30;
            this.buttonCity.IconMarginRight = 0;
            this.buttonCity.IconRightVisible = true;
            this.buttonCity.IconRightZoom = 0D;
            this.buttonCity.IconVisible = true;
            this.buttonCity.IconZoom = 90D;
            this.buttonCity.IsTab = false;
            this.buttonCity.Location = new System.Drawing.Point(0, 140);
            this.buttonCity.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCity.Name = "buttonCity";
            this.buttonCity.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonCity.OnHovercolor = System.Drawing.Color.Blue;
            this.buttonCity.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCity.selected = false;
            this.buttonCity.Size = new System.Drawing.Size(349, 66);
            this.buttonCity.TabIndex = 1;
            this.buttonCity.Text = "Города";
            this.buttonCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCity.Textcolor = System.Drawing.Color.White;
            this.buttonCity.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCity.Click += new System.EventHandler(this.buttonCity_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageActive = null;
            this.buttonClose.Location = new System.Drawing.Point(1357, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(45, 43);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            this.buttonClose.Zoom = 10;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // comboBoxCountryPeriod
            // 
            this.comboBoxCountryPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountryPeriod.FormattingEnabled = true;
            this.comboBoxCountryPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Неделя",
            "Месяц"});
            this.comboBoxCountryPeriod.Location = new System.Drawing.Point(683, 18);
            this.comboBoxCountryPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCountryPeriod.Name = "comboBoxCountryPeriod";
            this.comboBoxCountryPeriod.Size = new System.Drawing.Size(193, 24);
            this.comboBoxCountryPeriod.TabIndex = 9;
            this.comboBoxCountryPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(93, 18);
            this.comboBoxCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(193, 24);
            this.comboBoxCountry.TabIndex = 10;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxCountryPollution
            // 
            this.comboBoxCountryPollution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountryPollution.FormattingEnabled = true;
            this.comboBoxCountryPollution.Location = new System.Drawing.Point(413, 18);
            this.comboBoxCountryPollution.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCountryPollution.Name = "comboBoxCountryPollution";
            this.comboBoxCountryPollution.Size = new System.Drawing.Size(193, 24);
            this.comboBoxCountryPollution.TabIndex = 11;
            this.comboBoxCountryPollution.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(613, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Период:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Загрязнение:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Страны:";
            // 
            // comboBoxPollutionPeriod
            // 
            this.comboBoxPollutionPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPollutionPeriod.FormattingEnabled = true;
            this.comboBoxPollutionPeriod.Items.AddRange(new object[] {
            "Сегодня",
            "Неделя",
            "Месяц"});
            this.comboBoxPollutionPeriod.Location = new System.Drawing.Point(367, 15);
            this.comboBoxPollutionPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPollutionPeriod.Name = "comboBoxPollutionPeriod";
            this.comboBoxPollutionPeriod.Size = new System.Drawing.Size(193, 24);
            this.comboBoxPollutionPeriod.TabIndex = 15;
            this.comboBoxPollutionPeriod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPollutionCities_SelectedIndexChanged);
            // 
            // comboBoxPollutionCities
            // 
            this.comboBoxPollutionCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPollutionCities.FormattingEnabled = true;
            this.comboBoxPollutionCities.Location = new System.Drawing.Point(93, 15);
            this.comboBoxPollutionCities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPollutionCities.Name = "comboBoxPollutionCities";
            this.comboBoxPollutionCities.Size = new System.Drawing.Size(193, 24);
            this.comboBoxPollutionCities.TabIndex = 16;
            this.comboBoxPollutionCities.SelectedIndexChanged += new System.EventHandler(this.comboBoxPollutionCities_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(297, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Период:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Города:";
            // 
            // chartCountry1
            // 
            this.chartCountry1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCountry1.Location = new System.Drawing.Point(14, 47);
            this.chartCountry1.Name = "chartCountry1";
            this.chartCountry1.Size = new System.Drawing.Size(1054, 774);
            this.chartCountry1.TabIndex = 12;
            // 
            // chartPollution1
            // 
            this.chartPollution1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPollution1.BackColor = System.Drawing.Color.Transparent;
            this.chartPollution1.Location = new System.Drawing.Point(14, 69);
            this.chartPollution1.Name = "chartPollution1";
            this.chartPollution1.Size = new System.Drawing.Size(1077, 767);
            this.chartPollution1.TabIndex = 6;
            // 
            // chartPollutionCity1
            // 
            this.chartPollutionCity1.Location = new System.Drawing.Point(30, 47);
            this.chartPollutionCity1.Name = "chartPollutionCity1";
            this.chartPollutionCity1.Size = new System.Drawing.Size(1054, 767);
            this.chartPollutionCity1.TabIndex = 18;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1402, 921);
            this.Controls.Add(this.line);
            this.Controls.Add(this.panelPanels);
            this.Controls.Add(this.buttonPollution);
            this.Controls.Add(this.buttonCountry);
            this.Controls.Add(this.buttonCity);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPanels.ResumeLayout(false);
            this.panelCity.ResumeLayout(false);
            this.panelCity.PerformLayout();
            this.panelPollution.ResumeLayout(false);
            this.panelPollution.PerformLayout();
            this.panelCountry.ResumeLayout(false);
            this.panelCountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton buttonClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonPollution;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCountry;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCity;
        private System.Windows.Forms.Panel panelPanels;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel panelPollution;
        private System.Windows.Forms.Panel panelCountry;
        private System.Windows.Forms.Panel panelCity;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.ComboBox comboBoxPollution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private ChartPollution chartPollution1;
        private System.Windows.Forms.ComboBox comboBoxCountryPeriod;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxCountryPollution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ChartCountry chartCountry1;
        private System.Windows.Forms.ComboBox comboBoxPollutionPeriod;
        private System.Windows.Forms.ComboBox comboBoxPollutionCities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private ChartPollutionCity chartPollutionCity1;
    }
}

