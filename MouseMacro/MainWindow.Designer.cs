namespace MouseMacro
{
    partial class MainWindow
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
            this.mouseX_label = new System.Windows.Forms.Label();
            this.mouseY_label = new System.Windows.Forms.Label();
            this.AimButton = new System.Windows.Forms.Button();
            this.ClickingButton = new System.Windows.Forms.Button();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CountsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mouseX_label
            // 
            this.mouseX_label.AutoSize = true;
            this.mouseX_label.Location = new System.Drawing.Point(12, 9);
            this.mouseX_label.Name = "mouseX_label";
            this.mouseX_label.Size = new System.Drawing.Size(55, 13);
            this.mouseX_label.TabIndex = 0;
            this.mouseX_label.Text = "Mouse X: ";
            // 
            // mouseY_label
            // 
            this.mouseY_label.AutoSize = true;
            this.mouseY_label.Location = new System.Drawing.Point(12, 32);
            this.mouseY_label.Name = "mouseY_label";
            this.mouseY_label.Size = new System.Drawing.Size(55, 13);
            this.mouseY_label.TabIndex = 1;
            this.mouseY_label.Text = "Mouse Y: ";
            // 
            // AimButton
            // 
            this.AimButton.Location = new System.Drawing.Point(12, 120);
            this.AimButton.Name = "AimButton";
            this.AimButton.Size = new System.Drawing.Size(80, 29);
            this.AimButton.TabIndex = 2;
            this.AimButton.Text = "Set position";
            this.AimButton.UseVisualStyleBackColor = true;
            this.AimButton.Click += new System.EventHandler(this.CaptureMouse);
            // 
            // ClickingButton
            // 
            this.ClickingButton.Location = new System.Drawing.Point(140, 120);
            this.ClickingButton.Name = "ClickingButton";
            this.ClickingButton.Size = new System.Drawing.Size(80, 29);
            this.ClickingButton.TabIndex = 3;
            this.ClickingButton.Text = "Start";
            this.ClickingButton.UseVisualStyleBackColor = true;
            this.ClickingButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartClicker);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(120, 57);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntervalTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval: ";
            // 
            // CountsTextBox
            // 
            this.CountsTextBox.Location = new System.Drawing.Point(120, 85);
            this.CountsTextBox.Name = "CountsTextBox";
            this.CountsTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountsTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Counts: ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.ClickingButton);
            this.Controls.Add(this.AimButton);
            this.Controls.Add(this.mouseY_label);
            this.Controls.Add(this.mouseX_label);
            this.Name = "MainWindow";
            this.Text = "Mouse Clicker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mouseX_label;
        private System.Windows.Forms.Label mouseY_label;
        private System.Windows.Forms.Button AimButton;
        private System.Windows.Forms.Button ClickingButton;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountsTextBox;
        private System.Windows.Forms.Label label2;
    }
}

