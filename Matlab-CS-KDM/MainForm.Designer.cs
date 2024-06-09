namespace Matlab_CS_KDM
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            filtracjaLiniowaButton = new Button();
            lowerSampleRateButton = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(570, 27);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 0;
            button1.Text = "DCT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(40, 399);
            button2.Name = "button2";
            button2.Size = new Size(142, 39);
            button2.TabIndex = 1;
            button2.Text = "Wybierz plik dźwiękowy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(204, 403);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "Wybrany plik:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label2.Location = new Point(327, 406);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 3;
            label2.Text = "(brak)";
            label2.Click += label2_Click;
            // 
            // filtracjaLiniowaButton
            // 
            filtracjaLiniowaButton.Location = new Point(21, 27);
            filtracjaLiniowaButton.Name = "filtracjaLiniowaButton";
            filtracjaLiniowaButton.Size = new Size(218, 49);
            filtracjaLiniowaButton.TabIndex = 4;
            filtracjaLiniowaButton.Text = "Filtracja liniowa FIR";
            filtracjaLiniowaButton.UseVisualStyleBackColor = true;
            filtracjaLiniowaButton.Click += filtracjaLiniowaButton_Click;
            // 
            // lowerSampleRateButton
            // 
            lowerSampleRateButton.Location = new Point(290, 27);
            lowerSampleRateButton.Name = "lowerSampleRateButton";
            lowerSampleRateButton.Size = new Size(218, 49);
            lowerSampleRateButton.TabIndex = 5;
            lowerSampleRateButton.Text = "Filtracja antyaliasingowa Butterworth i decymacja\r\n";
            lowerSampleRateButton.UseVisualStyleBackColor = true;
            lowerSampleRateButton.Click += lowerSampleRateButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(21, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(218, 277);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(452, 427);
            label3.Name = "label3";
            label3.Size = new Size(349, 25);
            label3.TabIndex = 8;
            label3.Text = "Autor: Bartosz Kłosiński WCY21IG1S1";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(290, 98);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(218, 277);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(570, 98);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(218, 277);
            richTextBox3.TabIndex = 10;
            richTextBox3.Text = "Narzędzie służące do analizy wpływu wybranych parametrów DCT na na sygnał otrzymany po rekonstrukcji. Matlab wykonuje obliczenia, zwraca wykresy i zapisuje otrzymany plik dźwiękowy.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(lowerSampleRateButton);
            Controls.Add(filtracjaLiniowaButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button filtracjaLiniowaButton;
        private Button lowerSampleRateButton;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
    }
}
