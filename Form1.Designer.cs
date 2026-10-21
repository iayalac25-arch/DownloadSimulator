namespace PSP_E1_Ariketa_8_Download_Simulator
{
    partial class Form1
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
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            buttonHasi = new Button();
            labelDeskarga1 = new Label();
            labelDekarga2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(37, 115);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(527, 69);
            progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(37, 236);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(527, 73);
            progressBar2.TabIndex = 1;
            // 
            // buttonHasi
            // 
            buttonHasi.Location = new Point(37, 40);
            buttonHasi.Name = "buttonHasi";
            buttonHasi.Size = new Size(135, 48);
            buttonHasi.TabIndex = 7;
            buttonHasi.Text = "Hasi deskargak";
            buttonHasi.UseVisualStyleBackColor = true;
            buttonHasi.Click += buttonHasi_Click;
            // 
            // labelDeskarga1
            // 
            labelDeskarga1.AutoSize = true;
            labelDeskarga1.Location = new Point(237, 192);
            labelDeskarga1.Name = "labelDeskarga1";
            labelDeskarga1.Size = new Size(0, 20);
            labelDeskarga1.TabIndex = 9;
            // 
            // labelDekarga2
            // 
            labelDekarga2.AutoSize = true;
            labelDekarga2.Location = new Point(246, 329);
            labelDekarga2.Name = "labelDekarga2";
            labelDekarga2.Size = new Size(0, 20);
            labelDekarga2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(602, 115);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 194);
            textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(labelDekarga2);
            Controls.Add(labelDeskarga1);
            Controls.Add(buttonHasi);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Deskarga programa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Button buttonHasi;
        private Label labelDeskarga1;
        private Label labelDekarga2;
        private TextBox textBox1;
    }
}
