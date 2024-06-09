namespace Matlab_CS_KDM
{
    partial class DecimateForm
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
            playCreated = new Button();
            playOriginal = new Button();
            button1 = new Button();
            label4 = new Label();
            trackBar2 = new TrackBar();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            label6 = new Label();
            decimatedSignalPlayButton = new Button();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // playCreated
            // 
            playCreated.Location = new Point(199, 404);
            playCreated.Name = "playCreated";
            playCreated.Size = new Size(181, 34);
            playCreated.TabIndex = 15;
            playCreated.Text = "Odtwórz sygnał po filtrowaniu";
            playCreated.UseVisualStyleBackColor = true;
            playCreated.Click += playCreated_Click;
            // 
            // playOriginal
            // 
            playOriginal.Location = new Point(12, 404);
            playOriginal.Name = "playOriginal";
            playOriginal.Size = new Size(181, 34);
            playOriginal.TabIndex = 14;
            playOriginal.Text = "Odtwórz sygnał oryginalny";
            playOriginal.UseVisualStyleBackColor = true;
            playOriginal.Click += playOriginal_Click;
            // 
            // button1
            // 
            button1.Location = new Point(642, 389);
            button1.Name = "button1";
            button1.Size = new Size(140, 49);
            button1.TabIndex = 13;
            button1.Text = "Uruchom skrypt Matlab";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(741, 219);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 21;
            label4.Text = "1";
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 2;
            trackBar2.Location = new Point(357, 219);
            trackBar2.Maximum = 6;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(378, 45);
            trackBar2.TabIndex = 20;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(40, 219);
            label3.Name = "label3";
            label3.Size = new Size(247, 28);
            label3.TabIndex = 19;
            label3.Text = "Rząd filtru Butterwortha\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(40, 152);
            label2.Name = "label2";
            label2.Size = new Size(231, 56);
            label2.TabIndex = 18;
            label2.Text = "Częstotliwość odcięcia \r\nfiltru Butterwortha\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(741, 163);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 17;
            label1.Text = "1Hz";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(357, 163);
            trackBar1.Maximum = 3990;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(378, 45);
            trackBar1.TabIndex = 16;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(40, 279);
            label6.Name = "label6";
            label6.Size = new Size(518, 28);
            label6.TabIndex = 22;
            label6.Text = "Oczekiwana częstotliwość próbkowania po decymacji\r\n";
            // 
            // decimatedSignalPlayButton
            // 
            decimatedSignalPlayButton.Location = new Point(386, 404);
            decimatedSignalPlayButton.Name = "decimatedSignalPlayButton";
            decimatedSignalPlayButton.Size = new Size(179, 34);
            decimatedSignalPlayButton.TabIndex = 25;
            decimatedSignalPlayButton.Text = "Odtwórz sygnał po decymacji";
            decimatedSignalPlayButton.UseVisualStyleBackColor = true;
            decimatedSignalPlayButton.Click += decimatedSignalPlayButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(104, 82);
            label7.Name = "label7";
            label7.Size = new Size(606, 50);
            label7.TabIndex = 27;
            label7.Text = "Analiza wpływu rzędu oraz częstotliwości odcięcia filtru Butterwortha\r\n na wynik zmniejszenia liczby próbek sygnału metodą decymacji";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label8.Location = new Point(78, 9);
            label8.Name = "label8";
            label8.Size = new Size(632, 64);
            label8.TabIndex = 26;
            label8.Text = "Filtracja antyaliasingowa i zmniejszenie liczby próbek \r\nmetodą decymacji";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(564, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(97, 23);
            comboBox1.TabIndex = 29;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 287);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 30;
            label5.Text = "Hz";
            // 
            // DecimateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(decimatedSignalPlayButton);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(trackBar2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(playCreated);
            Controls.Add(playOriginal);
            Controls.Add(button1);
            Name = "DecimateForm";
            Text = "DecimateForm";
            Load += DecimateForm_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playCreated;
        private Button playOriginal;
        private Button button1;
        private Label label4;
        private TrackBar trackBar2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TrackBar trackBar1;
        private Label label6;
        private Button decimatedSignalPlayButton;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label5;
    }
}