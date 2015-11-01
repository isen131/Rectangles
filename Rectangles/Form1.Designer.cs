namespace Rectangles
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateRectangle_Button = new System.Windows.Forms.Button();
            this.ClearAll_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxCrossings_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreateRectangle_Button
            // 
            this.CreateRectangle_Button.Location = new System.Drawing.Point(12, 526);
            this.CreateRectangle_Button.Name = "CreateRectangle_Button";
            this.CreateRectangle_Button.Size = new System.Drawing.Size(216, 32);
            this.CreateRectangle_Button.TabIndex = 1;
            this.CreateRectangle_Button.Text = "Создать рандомный прямоугольник";
            this.CreateRectangle_Button.UseVisualStyleBackColor = true;
            this.CreateRectangle_Button.Click += new System.EventHandler(this.CreateRectangle_Button_Click);
            // 
            // ClearAll_Button
            // 
            this.ClearAll_Button.Location = new System.Drawing.Point(234, 526);
            this.ClearAll_Button.Name = "ClearAll_Button";
            this.ClearAll_Button.Size = new System.Drawing.Size(90, 31);
            this.ClearAll_Button.TabIndex = 5;
            this.ClearAll_Button.Text = "Очистить";
            this.ClearAll_Button.UseVisualStyleBackColor = true;
            this.ClearAll_Button.Click += new System.EventHandler(this.ClearAll_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Максимальное число пересечений:";
            // 
            // MaxCrossings_Label
            // 
            this.MaxCrossings_Label.AutoSize = true;
            this.MaxCrossings_Label.Location = new System.Drawing.Point(532, 536);
            this.MaxCrossings_Label.Name = "MaxCrossings_Label";
            this.MaxCrossings_Label.Size = new System.Drawing.Size(0, 13);
            this.MaxCrossings_Label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 570);
            this.Controls.Add(this.MaxCrossings_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearAll_Button);
            this.Controls.Add(this.CreateRectangle_Button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateRectangle_Button;
        private System.Windows.Forms.Button ClearAll_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaxCrossings_Label;
    }
}

