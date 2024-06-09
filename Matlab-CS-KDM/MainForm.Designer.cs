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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            filtracjaLiniowaButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(541, 196);
            button1.Name = "button1";
            button1.Size = new Size(186, 66);
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
            filtracjaLiniowaButton.Location = new Point(541, 29);
            filtracjaLiniowaButton.Name = "filtracjaLiniowaButton";
            filtracjaLiniowaButton.Size = new Size(186, 65);
            filtracjaLiniowaButton.TabIndex = 4;
            filtracjaLiniowaButton.Text = "Filtracja liniowa FIR";
            filtracjaLiniowaButton.UseVisualStyleBackColor = true;
            filtracjaLiniowaButton.Click += filtracjaLiniowaButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
