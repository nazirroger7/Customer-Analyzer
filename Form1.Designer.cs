namespace Roger_That
{
    partial class Customer_Analyzer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Analyzer));
            this.Refreshs = new System.Windows.Forms.Button();
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.CamList_Box = new System.Windows.Forms.ComboBox();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Timer_Loop = new System.Windows.Forms.Timer(this.components);
            this.Frams = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Gender_TextBox = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.timer_Loop_2 = new System.Windows.Forms.Timer(this.components);
            this.timer_Loop_3 = new System.Windows.Forms.Timer(this.components);
            this.Fps = new System.Windows.Forms.Label();
            this.Default_Camera = new System.Windows.Forms.CheckBox();
            this.Webcam_Panel = new System.Windows.Forms.Panel();
            this.Gender_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cam_List = new System.Windows.Forms.Label();
            this.Frames_Panel = new System.Windows.Forms.Panel();
            this.Open_Img = new System.Windows.Forms.Button();
            this.Image_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Select_Webcam_Radio_Button = new System.Windows.Forms.RadioButton();
            this.timer_Loop_4 = new System.Windows.Forms.Timer(this.components);
            this.Mood_TextBox = new System.Windows.Forms.TextBox();
            this.Mood = new System.Windows.Forms.Label();
            this.Eyes_Box = new System.Windows.Forms.PictureBox();
            this.RightEye_Box = new System.Windows.Forms.PictureBox();
            this.Lips_Box = new System.Windows.Forms.PictureBox();
            this.Nose_Box = new System.Windows.Forms.PictureBox();
            this.LeftEye_Box = new System.Windows.Forms.PictureBox();
            this.E_Feature = new System.Windows.Forms.Button();
            this.Eyes = new System.Windows.Forms.Label();
            this.Lips = new System.Windows.Forms.Label();
            this.RightEye = new System.Windows.Forms.Label();
            this.LeftEye = new System.Windows.Forms.Label();
            this.Nose = new System.Windows.Forms.Label();
            this.Mood_Panel = new System.Windows.Forms.Panel();
            this.chart_button = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.results = new System.Windows.Forms.Button();
            this.Person_Count_Panel = new System.Windows.Forms.Panel();
            this.total_person = new System.Windows.Forms.Label();
            this.data_set_count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.Webcam_Panel.SuspendLayout();
            this.Gender_Panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Frames_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eyes_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lips_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye_Box)).BeginInit();
            this.Mood_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.Person_Count_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refreshs
            // 
            this.Refreshs.Location = new System.Drawing.Point(6, 58);
            this.Refreshs.Name = "Refreshs";
            this.Refreshs.Size = new System.Drawing.Size(75, 23);
            this.Refreshs.TabIndex = 0;
            this.Refreshs.Text = "refresh";
            this.Refreshs.UseVisualStyleBackColor = true;
            this.Refreshs.Click += new System.EventHandler(this.Refresh);
            // 
            // Picture_Box
            // 
            this.Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture_Box.Location = new System.Drawing.Point(12, 10);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(494, 374);
            this.Picture_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_Box.TabIndex = 1;
            this.Picture_Box.TabStop = false;
            // 
            // CamList_Box
            // 
            this.CamList_Box.FormattingEnabled = true;
            this.CamList_Box.Location = new System.Drawing.Point(6, 31);
            this.CamList_Box.Name = "CamList_Box";
            this.CamList_Box.Size = new System.Drawing.Size(121, 21);
            this.CamList_Box.TabIndex = 2;
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Location = new System.Drawing.Point(3, 16);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 3;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Streaming);
            // 
            // Timer_Loop
            // 
            this.Timer_Loop.Interval = 1;
            this.Timer_Loop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frams
            // 
            this.Frams.AutoSize = true;
            this.Frams.Location = new System.Drawing.Point(31, 5);
            this.Frams.Name = "Frams";
            this.Frams.Size = new System.Drawing.Size(19, 13);
            this.Frams.TabIndex = 5;
            this.Frams.Text = "00";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(3, 9);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(45, 13);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender:";
            // 
            // Gender_TextBox
            // 
            this.Gender_TextBox.Location = new System.Drawing.Point(6, 25);
            this.Gender_TextBox.Name = "Gender_TextBox";
            this.Gender_TextBox.Size = new System.Drawing.Size(75, 20);
            this.Gender_TextBox.TabIndex = 10;
            // 
            // Stop
            // 
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(3, 45);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 11;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Streaming);
            // 
            // timer_Loop_2
            // 
            this.timer_Loop_2.Interval = 1;
            this.timer_Loop_2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer_Loop_3
            // 
            this.timer_Loop_3.Interval = 1000;
            this.timer_Loop_3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Fps
            // 
            this.Fps.AutoSize = true;
            this.Fps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fps.Location = new System.Drawing.Point(3, 5);
            this.Fps.Name = "Fps";
            this.Fps.Size = new System.Drawing.Size(31, 13);
            this.Fps.TabIndex = 12;
            this.Fps.Text = "Fps:";
            // 
            // Default_Camera
            // 
            this.Default_Camera.AutoSize = true;
            this.Default_Camera.Checked = true;
            this.Default_Camera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Default_Camera.Location = new System.Drawing.Point(3, 74);
            this.Default_Camera.Name = "Default_Camera";
            this.Default_Camera.Size = new System.Drawing.Size(118, 17);
            this.Default_Camera.TabIndex = 13;
            this.Default_Camera.Text = "Use default camera";
            this.Default_Camera.UseVisualStyleBackColor = true;
            // 
            // Webcam_Panel
            // 
            this.Webcam_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Webcam_Panel.Controls.Add(this.Start_Button);
            this.Webcam_Panel.Controls.Add(this.Default_Camera);
            this.Webcam_Panel.Controls.Add(this.Stop);
            this.Webcam_Panel.Location = new System.Drawing.Point(516, 152);
            this.Webcam_Panel.Name = "Webcam_Panel";
            this.Webcam_Panel.Size = new System.Drawing.Size(123, 102);
            this.Webcam_Panel.TabIndex = 14;
            // 
            // Gender_Panel
            // 
            this.Gender_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gender_Panel.Controls.Add(this.Gender);
            this.Gender_Panel.Controls.Add(this.Gender_TextBox);
            this.Gender_Panel.Location = new System.Drawing.Point(516, 302);
            this.Gender_Panel.Name = "Gender_Panel";
            this.Gender_Panel.Size = new System.Drawing.Size(122, 56);
            this.Gender_Panel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Cam_List);
            this.panel3.Controls.Add(this.CamList_Box);
            this.panel3.Controls.Add(this.Refreshs);
            this.panel3.Location = new System.Drawing.Point(12, 390);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 90);
            this.panel3.TabIndex = 16;
            // 
            // Cam_List
            // 
            this.Cam_List.AutoSize = true;
            this.Cam_List.Location = new System.Drawing.Point(3, 15);
            this.Cam_List.Name = "Cam_List";
            this.Cam_List.Size = new System.Drawing.Size(58, 13);
            this.Cam_List.TabIndex = 3;
            this.Cam_List.Text = "Camera list";
            // 
            // Frames_Panel
            // 
            this.Frames_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Frames_Panel.Controls.Add(this.Fps);
            this.Frames_Panel.Controls.Add(this.Frams);
            this.Frames_Panel.Location = new System.Drawing.Point(175, 390);
            this.Frames_Panel.Name = "Frames_Panel";
            this.Frames_Panel.Size = new System.Drawing.Size(115, 35);
            this.Frames_Panel.TabIndex = 17;
            // 
            // Open_Img
            // 
            this.Open_Img.Location = new System.Drawing.Point(516, 55);
            this.Open_Img.Name = "Open_Img";
            this.Open_Img.Size = new System.Drawing.Size(75, 23);
            this.Open_Img.TabIndex = 18;
            this.Open_Img.Text = "Open image";
            this.Open_Img.UseVisualStyleBackColor = true;
            this.Open_Img.Click += new System.EventHandler(this.Open_Image);
            // 
            // Image_Radio_Button
            // 
            this.Image_Radio_Button.AutoSize = true;
            this.Image_Radio_Button.Location = new System.Drawing.Point(516, 32);
            this.Image_Radio_Button.Name = "Image_Radio_Button";
            this.Image_Radio_Button.Size = new System.Drawing.Size(111, 17);
            this.Image_Radio_Button.TabIndex = 19;
            this.Image_Radio_Button.Text = "Detect from image";
            this.Image_Radio_Button.UseVisualStyleBackColor = true;
            this.Image_Radio_Button.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Select_Webcam_Radio_Button
            // 
            this.Select_Webcam_Radio_Button.AutoSize = true;
            this.Select_Webcam_Radio_Button.Checked = true;
            this.Select_Webcam_Radio_Button.Location = new System.Drawing.Point(516, 129);
            this.Select_Webcam_Radio_Button.Name = "Select_Webcam_Radio_Button";
            this.Select_Webcam_Radio_Button.Size = new System.Drawing.Size(123, 17);
            this.Select_Webcam_Radio_Button.TabIndex = 20;
            this.Select_Webcam_Radio_Button.TabStop = true;
            this.Select_Webcam_Radio_Button.Text = "Detect from webcam";
            this.Select_Webcam_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // timer_Loop_4
            // 
            this.timer_Loop_4.Interval = 1;
            // 
            // Mood_TextBox
            // 
            this.Mood_TextBox.Location = new System.Drawing.Point(7, 25);
            this.Mood_TextBox.Name = "Mood_TextBox";
            this.Mood_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Mood_TextBox.TabIndex = 21;
            // 
            // Mood
            // 
            this.Mood.AutoSize = true;
            this.Mood.Location = new System.Drawing.Point(4, 8);
            this.Mood.Name = "Mood";
            this.Mood.Size = new System.Drawing.Size(37, 13);
            this.Mood.TabIndex = 22;
            this.Mood.Text = "Mood:";
            // 
            // Eyes_Box
            // 
            this.Eyes_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eyes_Box.Location = new System.Drawing.Point(677, 32);
            this.Eyes_Box.Name = "Eyes_Box";
            this.Eyes_Box.Size = new System.Drawing.Size(120, 50);
            this.Eyes_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Eyes_Box.TabIndex = 23;
            this.Eyes_Box.TabStop = false;
            // 
            // RightEye_Box
            // 
            this.RightEye_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RightEye_Box.Location = new System.Drawing.Point(677, 194);
            this.RightEye_Box.Name = "RightEye_Box";
            this.RightEye_Box.Size = new System.Drawing.Size(120, 50);
            this.RightEye_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightEye_Box.TabIndex = 24;
            this.RightEye_Box.TabStop = false;
            // 
            // Lips_Box
            // 
            this.Lips_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lips_Box.Location = new System.Drawing.Point(677, 111);
            this.Lips_Box.Name = "Lips_Box";
            this.Lips_Box.Size = new System.Drawing.Size(120, 50);
            this.Lips_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lips_Box.TabIndex = 25;
            this.Lips_Box.TabStop = false;
            // 
            // Nose_Box
            // 
            this.Nose_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nose_Box.Location = new System.Drawing.Point(677, 359);
            this.Nose_Box.Name = "Nose_Box";
            this.Nose_Box.Size = new System.Drawing.Size(120, 50);
            this.Nose_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nose_Box.TabIndex = 26;
            this.Nose_Box.TabStop = false;
            // 
            // LeftEye_Box
            // 
            this.LeftEye_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftEye_Box.Location = new System.Drawing.Point(677, 275);
            this.LeftEye_Box.Name = "LeftEye_Box";
            this.LeftEye_Box.Size = new System.Drawing.Size(120, 50);
            this.LeftEye_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftEye_Box.TabIndex = 27;
            this.LeftEye_Box.TabStop = false;
            // 
            // E_Feature
            // 
            this.E_Feature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.E_Feature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.E_Feature.Location = new System.Drawing.Point(315, 390);
            this.E_Feature.Name = "E_Feature";
            this.E_Feature.Size = new System.Drawing.Size(109, 35);
            this.E_Feature.TabIndex = 28;
            this.E_Feature.Text = "Clear Text Box";
            this.E_Feature.UseVisualStyleBackColor = true;
            this.E_Feature.Click += new System.EventHandler(this.Extract_Feature);
            // 
            // Eyes
            // 
            this.Eyes.AutoSize = true;
            this.Eyes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eyes.Location = new System.Drawing.Point(820, 55);
            this.Eyes.Name = "Eyes";
            this.Eyes.Size = new System.Drawing.Size(34, 13);
            this.Eyes.TabIndex = 29;
            this.Eyes.Text = "Eyes";
            // 
            // Lips
            // 
            this.Lips.AutoSize = true;
            this.Lips.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lips.Location = new System.Drawing.Point(820, 129);
            this.Lips.Name = "Lips";
            this.Lips.Size = new System.Drawing.Size(30, 13);
            this.Lips.TabIndex = 30;
            this.Lips.Text = "Lips";
            // 
            // RightEye
            // 
            this.RightEye.AutoSize = true;
            this.RightEye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightEye.Location = new System.Drawing.Point(820, 208);
            this.RightEye.Name = "RightEye";
            this.RightEye.Size = new System.Drawing.Size(62, 13);
            this.RightEye.TabIndex = 31;
            this.RightEye.Text = "Right Eye";
            // 
            // LeftEye
            // 
            this.LeftEye.AutoSize = true;
            this.LeftEye.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftEye.Location = new System.Drawing.Point(820, 302);
            this.LeftEye.Name = "LeftEye";
            this.LeftEye.Size = new System.Drawing.Size(54, 13);
            this.LeftEye.TabIndex = 32;
            this.LeftEye.Text = "Left Eye";
            // 
            // Nose
            // 
            this.Nose.AutoSize = true;
            this.Nose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nose.Location = new System.Drawing.Point(820, 371);
            this.Nose.Name = "Nose";
            this.Nose.Size = new System.Drawing.Size(36, 13);
            this.Nose.TabIndex = 33;
            this.Nose.Text = "Nose";
            // 
            // Mood_Panel
            // 
            this.Mood_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mood_Panel.Controls.Add(this.Mood_TextBox);
            this.Mood_Panel.Controls.Add(this.Mood);
            this.Mood_Panel.Location = new System.Drawing.Point(516, 364);
            this.Mood_Panel.Name = "Mood_Panel";
            this.Mood_Panel.Size = new System.Drawing.Size(122, 55);
            this.Mood_Panel.TabIndex = 34;
            // 
            // chart_button
            // 
            this.chart_button.Location = new System.Drawing.Point(522, 524);
            this.chart_button.Name = "chart_button";
            this.chart_button.Size = new System.Drawing.Size(75, 23);
            this.chart_button.TabIndex = 36;
            this.chart_button.Text = "Pie Chart";
            this.chart_button.UseVisualStyleBackColor = true;
            this.chart_button.Click += new System.EventHandler(this.chart_button_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TextWrapThreshold = 20;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(677, 422);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Customer";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(300, 215);
            this.chart.TabIndex = 37;
            this.chart.Text = "chart";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(516, 84);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(82, 23);
            this.results.TabIndex = 38;
            this.results.Text = "Generate Log";
            this.results.UseVisualStyleBackColor = true;
            this.results.Click += new System.EventHandler(this.results_Click);
            // 
            // Person_Count_Panel
            // 
            this.Person_Count_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Person_Count_Panel.Controls.Add(this.total_person);
            this.Person_Count_Panel.Controls.Add(this.data_set_count);
            this.Person_Count_Panel.Location = new System.Drawing.Point(516, 438);
            this.Person_Count_Panel.Name = "Person_Count_Panel";
            this.Person_Count_Panel.Size = new System.Drawing.Size(122, 53);
            this.Person_Count_Panel.TabIndex = 39;
            this.Person_Count_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.DataSet_Count_Panel);
            // 
            // total_person
            // 
            this.total_person.AutoSize = true;
            this.total_person.Location = new System.Drawing.Point(4, 10);
            this.total_person.Name = "total_person";
            this.total_person.Size = new System.Drawing.Size(74, 13);
            this.total_person.TabIndex = 1;
            this.total_person.Text = "Person Count:";
            // 
            // data_set_count
            // 
            this.data_set_count.AutoSize = true;
            this.data_set_count.Location = new System.Drawing.Point(39, 28);
            this.data_set_count.Name = "data_set_count";
            this.data_set_count.Size = new System.Drawing.Size(35, 13);
            this.data_set_count.TabIndex = 0;
            this.data_set_count.Text = "Count";
            // 
            // Customer_Analyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1039, 649);
            this.Controls.Add(this.Person_Count_Panel);
            this.Controls.Add(this.results);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.chart_button);
            this.Controls.Add(this.Mood_Panel);
            this.Controls.Add(this.Nose);
            this.Controls.Add(this.LeftEye);
            this.Controls.Add(this.RightEye);
            this.Controls.Add(this.Lips);
            this.Controls.Add(this.Eyes);
            this.Controls.Add(this.E_Feature);
            this.Controls.Add(this.LeftEye_Box);
            this.Controls.Add(this.Nose_Box);
            this.Controls.Add(this.Lips_Box);
            this.Controls.Add(this.RightEye_Box);
            this.Controls.Add(this.Eyes_Box);
            this.Controls.Add(this.Select_Webcam_Radio_Button);
            this.Controls.Add(this.Image_Radio_Button);
            this.Controls.Add(this.Open_Img);
            this.Controls.Add(this.Frames_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Gender_Panel);
            this.Controls.Add(this.Webcam_Panel);
            this.Controls.Add(this.Picture_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Customer_Analyzer";
            this.Text = "Customer Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Customer_Analyzer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.Webcam_Panel.ResumeLayout(false);
            this.Webcam_Panel.PerformLayout();
            this.Gender_Panel.ResumeLayout(false);
            this.Gender_Panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Frames_Panel.ResumeLayout(false);
            this.Frames_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eyes_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightEye_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lips_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nose_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftEye_Box)).EndInit();
            this.Mood_Panel.ResumeLayout(false);
            this.Mood_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.Person_Count_Panel.ResumeLayout(false);
            this.Person_Count_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refreshs;
        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.ComboBox CamList_Box;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Timer Timer_Loop;
        private System.Windows.Forms.Label Frams;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.TextBox Gender_TextBox;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer_Loop_2;
        private System.Windows.Forms.Timer timer_Loop_3;
        private System.Windows.Forms.Label Fps;
        private System.Windows.Forms.CheckBox Default_Camera;
        private System.Windows.Forms.Panel Webcam_Panel;
        private System.Windows.Forms.Panel Gender_Panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Cam_List;
        private System.Windows.Forms.Panel Frames_Panel;
        private System.Windows.Forms.Button Open_Img;
        private System.Windows.Forms.RadioButton Image_Radio_Button;
        private System.Windows.Forms.RadioButton Select_Webcam_Radio_Button;
        private System.Windows.Forms.Timer timer_Loop_4;
        private System.Windows.Forms.TextBox Mood_TextBox;
        private System.Windows.Forms.Label Mood;
        private System.Windows.Forms.PictureBox Eyes_Box;
        private System.Windows.Forms.PictureBox RightEye_Box;
        private System.Windows.Forms.PictureBox Lips_Box;
        private System.Windows.Forms.PictureBox Nose_Box;
        private System.Windows.Forms.PictureBox LeftEye_Box;
        private System.Windows.Forms.Button E_Feature;
        private System.Windows.Forms.Label Eyes;
        private System.Windows.Forms.Label Lips;
        private System.Windows.Forms.Label RightEye;
        private System.Windows.Forms.Label LeftEye;
        private System.Windows.Forms.Label Nose;
        private System.Windows.Forms.Panel Mood_Panel;
        private System.Windows.Forms.Button chart_button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Panel Person_Count_Panel;
        private System.Windows.Forms.Label data_set_count;
        private System.Windows.Forms.Label total_person;
    }
}

