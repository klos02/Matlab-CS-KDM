namespace Matlab_CS_KDM
{
    partial class FIRForm
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
            filterOrderBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            cutoffFreqBar = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            playCreated = new Button();
            playOriginal = new Button();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)filterOrderBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cutoffFreqBar).BeginInit();
            SuspendLayout();
            // 
            // filterOrderBar
            // 
            filterOrderBar.Location = new Point(325, 167);
            filterOrderBar.Maximum = 100;
            filterOrderBar.Minimum = 1;
            filterOrderBar.Name = "filterOrderBar";
            filterOrderBar.Size = new Size(417, 45);
            filterOrderBar.TabIndex = 0;
            filterOrderBar.Value = 1;
            filterOrderBar.Scroll += filterOrderBar_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(748, 167);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 1;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(44, 167);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 4;
            label2.Text = "Rząd filtru FIR";
            // 
            // cutoffFreqBar
            // 
            cutoffFreqBar.Location = new Point(325, 259);
            cutoffFreqBar.Maximum = 3999;
            cutoffFreqBar.Minimum = 1;
            cutoffFreqBar.Name = "cutoffFreqBar";
            cutoffFreqBar.Size = new Size(417, 45);
            cutoffFreqBar.TabIndex = 5;
            cutoffFreqBar.Value = 1;
            cutoffFreqBar.Scroll += cutoffFreqBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 259);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "1Hz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(44, 259);
            label4.Name = "label4";
            label4.Size = new Size(225, 28);
            label4.TabIndex = 7;
            label4.Text = "Częstotliwość odcięcia";
            // 
            // button1
            // 
            button1.Location = new Point(635, 389);
            button1.Name = "button1";
            button1.Size = new Size(140, 49);
            button1.TabIndex = 8;
            button1.Text = "Uruchom skrypt Matlab";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // playCreated
            // 
            playCreated.Location = new Point(209, 404);
            playCreated.Name = "playCreated";
            playCreated.Size = new Size(191, 34);
            playCreated.TabIndex = 12;
            playCreated.Text = "Odtwórz sygnał po rekonstrukcji\r\n";
            playCreated.UseVisualStyleBackColor = true;
            playCreated.Click += playCreated_Click;
            // 
            // playOriginal
            // 
            playOriginal.Location = new Point(12, 404);
            playOriginal.Name = "playOriginal";
            playOriginal.Size = new Size(191, 34);
            playOriginal.TabIndex = 11;
            playOriginal.Text = "Odtwórz sygnał oryginalny";
            playOriginal.UseVisualStyleBackColor = true;
            playOriginal.Click += playOriginal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(44, 41);
            label6.Name = "label6";
            label6.Size = new Size(705, 50);
            label6.TabIndex = 14;
            label6.Text = "Analiza wpływu rzędu filtru oraz częstotliwości odcięcia na rekonstrukcję sygnału\r\npo filtracji dolnoprzepustowej";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(267, 9);
            label5.Name = "label5";
            label5.Size = new Size(237, 32);
            label5.TabIndex = 13;
            label5.Text = "Filtracja liniowa FIR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(451, 105);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 15;
            // 
            // FIRForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(playCreated);
            Controls.Add(playOriginal);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cutoffFreqBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(filterOrderBar);
            Name = "FIRForm";
            Text = "FIRForm";
            ((System.ComponentModel.ISupportInitialize)filterOrderBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)cutoffFreqBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar filterOrderBar;
        private Label label1;
        private Label label2;
        private TrackBar cutoffFreqBar;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button playCreated;
        private Button playOriginal;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}