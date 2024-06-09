namespace Matlab_CS_KDM
{
    partial class DCTForm
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
            trackBar1 = new TrackBar();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            trackBar2 = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            playOriginal = new Button();
            playCreated = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(355, 170);
            trackBar1.Maximum = 1000;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(378, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(633, 389);
            button1.Name = "button1";
            button1.Size = new Size(140, 49);
            button1.TabIndex = 1;
            button1.Text = "Uruchom skrypt Matlab";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(739, 170);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "0,001";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(38, 170);
            label2.Name = "label2";
            label2.Size = new Size(320, 28);
            label2.TabIndex = 3;
            label2.Text = "Próg zerowania współczynników";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(38, 256);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 4;
            label3.Text = "Długość bloku";
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 64;
            trackBar2.Location = new Point(355, 256);
            trackBar2.Maximum = 10000;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(378, 45);
            trackBar2.SmallChange = 4;
            trackBar2.TabIndex = 5;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(739, 256);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(204, 9);
            label5.Name = "label5";
            label5.Size = new Size(381, 32);
            label5.TabIndex = 7;
            label5.Text = "Zastosowanie DCT do kompresji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(38, 41);
            label6.Name = "label6";
            label6.Size = new Size(651, 50);
            label6.TabIndex = 8;
            label6.Text = "Analiza wpływu progu zerowania współczynników DCT i długości bloku na \r\nrekonstrukcję sygnału po kompresji transformat DCT";
            // 
            // playOriginal
            // 
            playOriginal.Location = new Point(12, 404);
            playOriginal.Name = "playOriginal";
            playOriginal.Size = new Size(191, 34);
            playOriginal.TabIndex = 9;
            playOriginal.Text = "Odtwórz sygnał oryginalny";
            playOriginal.UseVisualStyleBackColor = true;
            playOriginal.Click += playOriginal_Click;
            // 
            // playCreated
            // 
            playCreated.Location = new Point(209, 404);
            playCreated.Name = "playCreated";
            playCreated.Size = new Size(191, 34);
            playCreated.TabIndex = 10;
            playCreated.Text = "Odtwórz sygnał po rekonstrukcji\r\n";
            playCreated.UseVisualStyleBackColor = true;
            playCreated.Click += playCreated_Click;
            // 
            // DCTForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playCreated);
            Controls.Add(playOriginal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(trackBar2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Name = "DCTForm";
            Text = "DCTForm";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button playOriginal;
        private Button playCreated;
    }
}