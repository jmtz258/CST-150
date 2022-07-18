namespace S2M_WinFormsApp2
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.s2m_radioButton1 = new System.Windows.Forms.RadioButton();
            this.inputOfSecs = new System.Windows.Forms.TextBox();
            this.numOfSecs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(309, 277);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 13;
            // 
            // conversionButton
            // 
            this.conversionButton.Location = new System.Drawing.Point(309, 235);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(163, 23);
            this.conversionButton.TabIndex = 12;
            this.conversionButton.Text = "Get Minutes, Hours or Days";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // s2m_radioButton1
            // 
            this.s2m_radioButton1.AutoSize = true;
            this.s2m_radioButton1.Location = new System.Drawing.Point(258, 139);
            this.s2m_radioButton1.Name = "s2m_radioButton1";
            this.s2m_radioButton1.Size = new System.Drawing.Size(326, 19);
            this.s2m_radioButton1.TabIndex = 10;
            this.s2m_radioButton1.TabStop = true;
            this.s2m_radioButton1.Text = "Convert how many seconds are in a minute, hour or day?";
            this.s2m_radioButton1.UseVisualStyleBackColor = true;
            this.s2m_radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // inputOfSecs
            // 
            this.inputOfSecs.Location = new System.Drawing.Point(378, 193);
            this.inputOfSecs.Name = "inputOfSecs";
            this.inputOfSecs.Size = new System.Drawing.Size(138, 23);
            this.inputOfSecs.TabIndex = 9;
            // 
            // numOfSecs
            // 
            this.numOfSecs.AutoSize = true;
            this.numOfSecs.Location = new System.Drawing.Point(264, 196);
            this.numOfSecs.Name = "numOfSecs";
            this.numOfSecs.Size = new System.Drawing.Size(81, 15);
            this.numOfSecs.TabIndex = 8;
            this.numOfSecs.Text = "Enter Seconds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.s2m_radioButton1);
            this.Controls.Add(this.inputOfSecs);
            this.Controls.Add(this.numOfSecs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label outputLabel;
        private Button conversionButton;
        private RadioButton s2m_radioButton1;
        private TextBox inputOfSecs;
        private Label numOfSecs;
    }
}