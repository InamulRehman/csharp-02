
namespace VolumeConverter
{
    partial class volumeConverter
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
            this.convertClTitleLabel = new System.Windows.Forms.Label();
            this.clTextBox = new System.Windows.Forms.TextBox();
            this.litreTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clLabel = new System.Windows.Forms.Label();
            this.litreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // convertClTitleLabel
            // 
            this.convertClTitleLabel.AutoSize = true;
            this.convertClTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertClTitleLabel.Location = new System.Drawing.Point(187, 54);
            this.convertClTitleLabel.Name = "convertClTitleLabel";
            this.convertClTitleLabel.Size = new System.Drawing.Size(261, 31);
            this.convertClTitleLabel.TabIndex = 0;
            this.convertClTitleLabel.Text = "Convert CL to Litre";
            this.convertClTitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // clTextBox
            // 
            this.clTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clTextBox.Location = new System.Drawing.Point(193, 123);
            this.clTextBox.Multiline = true;
            this.clTextBox.Name = "clTextBox";
            this.clTextBox.Size = new System.Drawing.Size(118, 41);
            this.clTextBox.TabIndex = 1;
            this.clTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // litreTextBox
            // 
            this.litreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreTextBox.Location = new System.Drawing.Point(193, 197);
            this.litreTextBox.Multiline = true;
            this.litreTextBox.Name = "litreTextBox";
            this.litreTextBox.Size = new System.Drawing.Size(118, 41);
            this.litreTextBox.TabIndex = 2;
            this.litreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.litreTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(193, 282);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(90, 35);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(337, 282);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 35);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clLabel
            // 
            this.clLabel.AutoSize = true;
            this.clLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clLabel.Location = new System.Drawing.Point(332, 123);
            this.clLabel.Name = "clLabel";
            this.clLabel.Size = new System.Drawing.Size(45, 29);
            this.clLabel.TabIndex = 5;
            this.clLabel.Text = "CL";
            // 
            // litreLabel
            // 
            this.litreLabel.AutoSize = true;
            this.litreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.litreLabel.Location = new System.Drawing.Point(332, 197);
            this.litreLabel.Name = "litreLabel";
            this.litreLabel.Size = new System.Drawing.Size(65, 29);
            this.litreLabel.TabIndex = 6;
            this.litreLabel.Text = "Litre";
            this.litreLabel.Click += new System.EventHandler(this.litreLabel_Click);
            // 
            // volumeConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.litreLabel);
            this.Controls.Add(this.clLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.litreTextBox);
            this.Controls.Add(this.clTextBox);
            this.Controls.Add(this.convertClTitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "volumeConverter";
            this.Text = "Volume Coverter CL to Litre";
            this.Load += new System.EventHandler(this.volumeConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label convertClTitleLabel;
        private System.Windows.Forms.TextBox clTextBox;
        private System.Windows.Forms.TextBox litreTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label clLabel;
        private System.Windows.Forms.Label litreLabel;
    }
}

