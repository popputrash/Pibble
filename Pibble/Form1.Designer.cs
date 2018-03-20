namespace Pibble
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.rectButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolPanel.Controls.Add(this.button5);
            this.toolPanel.Controls.Add(this.button6);
            this.toolPanel.Controls.Add(this.penButton);
            this.toolPanel.Controls.Add(this.fillButton);
            this.toolPanel.Controls.Add(this.lineButton);
            this.toolPanel.Controls.Add(this.rectButton);
            this.toolPanel.Controls.Add(this.colorButton);
            this.toolPanel.Controls.Add(this.eraserButton);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolPanel.Location = new System.Drawing.Point(0, 0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(839, 27);
            this.toolPanel.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(280, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(240, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // penButton
            // 
            this.penButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.penButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penButton.BackgroundImage")));
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.penButton.FlatAppearance.BorderSize = 0;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penButton.Location = new System.Drawing.Point(0, 0);
            this.penButton.Margin = new System.Windows.Forms.Padding(0);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(40, 30);
            this.penButton.TabIndex = 0;
            this.penButton.UseVisualStyleBackColor = false;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.FlatAppearance.BorderSize = 0;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Location = new System.Drawing.Point(200, 0);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(40, 30);
            this.fillButton.TabIndex = 5;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Location = new System.Drawing.Point(160, 0);
            this.lineButton.Margin = new System.Windows.Forms.Padding(0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(40, 30);
            this.lineButton.TabIndex = 4;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.FlatAppearance.BorderSize = 0;
            this.rectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectButton.Location = new System.Drawing.Point(120, 0);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(40, 30);
            this.rectButton.TabIndex = 3;
            this.rectButton.Text = "Rect";
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.FlatAppearance.BorderSize = 0;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Location = new System.Drawing.Point(80, 0);
            this.colorButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(40, 30);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraserButton.BackgroundImage")));
            this.eraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eraserButton.FlatAppearance.BorderSize = 0;
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Location = new System.Drawing.Point(40, 0);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(40, 30);
            this.eraserButton.TabIndex = 1;
            this.eraserButton.UseVisualStyleBackColor = false;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // paintPanel
            // 
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintPanel.Location = new System.Drawing.Point(0, 27);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(839, 484);
            this.paintPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(839, 511);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.toolPanel);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Panel paintPanel;
    }
}

