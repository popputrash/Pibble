﻿namespace Pibble
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.circleButton = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.penButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.rectButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.toolTipRect = new System.Windows.Forms.ToolTip(this.components);
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(81)))));
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Controls.Add(this.btnSave);
            this.topPanel.Controls.Add(this.newBtn);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(841, 20);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 7F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(70, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Open";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Roboto", 7F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(35, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 20);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSave_MouseClick);
            // 
            // newBtn
            // 
            this.newBtn.FlatAppearance.BorderSize = 0;
            this.newBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Roboto", 7F);
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.Location = new System.Drawing.Point(0, 0);
            this.newBtn.Margin = new System.Windows.Forms.Padding(0);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(35, 20);
            this.newBtn.TabIndex = 2;
            this.newBtn.Text = "New";
            this.newBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = global::Pibble.Properties.Resources.MinimizeIcon;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(801, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::Pibble.Properties.Resources.CloseIcon;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(821, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolPanel
            // 
            this.toolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.toolPanel.Controls.Add(this.zoomOutButton);
            this.toolPanel.Controls.Add(this.circleButton);
            this.toolPanel.Controls.Add(this.zoomInButton);
            this.toolPanel.Controls.Add(this.penButton);
            this.toolPanel.Controls.Add(this.fillButton);
            this.toolPanel.Controls.Add(this.lineButton);
            this.toolPanel.Controls.Add(this.rectButton);
            this.toolPanel.Controls.Add(this.colorButton);
            this.toolPanel.Controls.Add(this.eraserButton);
            this.toolPanel.Location = new System.Drawing.Point(0, 20);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(841, 30);
            this.toolPanel.TabIndex = 4;
            // 
            // circleButton
            // 
            this.circleButton.FlatAppearance.BorderSize = 0;
            this.circleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton.ForeColor = System.Drawing.Color.White;
            this.circleButton.Location = new System.Drawing.Point(240, 0);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(40, 30);
            this.circleButton.TabIndex = 15;
            this.circleButton.Text = "Circ";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackgroundImage = global::Pibble.Properties.Resources.ZoomInIcon;
            this.zoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomInButton.FlatAppearance.BorderSize = 0;
            this.zoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomInButton.Location = new System.Drawing.Point(280, 0);
            this.zoomInButton.Margin = new System.Windows.Forms.Padding(0);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(40, 30);
            this.zoomInButton.TabIndex = 14;
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // penButton
            // 
            this.penButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.penButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penButton.BackgroundImage")));
            this.penButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.penButton.FlatAppearance.BorderSize = 0;
            this.penButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penButton.Location = new System.Drawing.Point(0, 0);
            this.penButton.Margin = new System.Windows.Forms.Padding(0);
            this.penButton.Name = "penButton";
            this.penButton.Size = new System.Drawing.Size(40, 30);
            this.penButton.TabIndex = 8;
            this.penButton.UseVisualStyleBackColor = false;
            this.penButton.Click += new System.EventHandler(this.penButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.FlatAppearance.BorderSize = 0;
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillButton.ForeColor = System.Drawing.Color.White;
            this.fillButton.Location = new System.Drawing.Point(200, 0);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(40, 30);
            this.fillButton.TabIndex = 13;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.FlatAppearance.BorderSize = 0;
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineButton.ForeColor = System.Drawing.Color.White;
            this.lineButton.Location = new System.Drawing.Point(160, 0);
            this.lineButton.Margin = new System.Windows.Forms.Padding(0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(40, 30);
            this.lineButton.TabIndex = 12;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // rectButton
            // 
            this.rectButton.FlatAppearance.BorderSize = 0;
            this.rectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectButton.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectButton.ForeColor = System.Drawing.Color.White;
            this.rectButton.Location = new System.Drawing.Point(120, 0);
            this.rectButton.Name = "rectButton";
            this.rectButton.Size = new System.Drawing.Size(40, 30);
            this.rectButton.TabIndex = 11;
            this.rectButton.Text = "Rect";
            this.rectButton.UseVisualStyleBackColor = true;
            this.rectButton.Click += new System.EventHandler(this.rectButton_Click);
            this.rectButton.MouseHover += new System.EventHandler(this.rectButton_MouseHover);
            // 
            // colorButton
            // 
            this.colorButton.FlatAppearance.BorderSize = 0;
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorButton.Font = new System.Drawing.Font("Roboto", 8F);
            this.colorButton.ForeColor = System.Drawing.Color.White;
            this.colorButton.Location = new System.Drawing.Point(80, 0);
            this.colorButton.Margin = new System.Windows.Forms.Padding(0);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(40, 30);
            this.colorButton.TabIndex = 10;
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
            this.eraserButton.TabIndex = 9;
            this.eraserButton.UseVisualStyleBackColor = false;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // paintPanel
            // 
            this.paintPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paintPanel.BackColor = System.Drawing.Color.White;
            this.paintPanel.Location = new System.Drawing.Point(2, 50);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(836, 458);
            this.paintPanel.TabIndex = 5;
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintPanel_Paint);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.BackgroundImage = global::Pibble.Properties.Resources.ZoomOutIcon;
            this.zoomOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zoomOutButton.FlatAppearance.BorderSize = 0;
            this.zoomOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoomOutButton.Location = new System.Drawing.Point(320, 0);
            this.zoomOutButton.Margin = new System.Windows.Forms.Padding(0);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(40, 30);
            this.zoomOutButton.TabIndex = 16;
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(840, 510);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.toolPanel);
            this.Controls.Add(this.topPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.topPanel.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button penButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button rectButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip toolTipRect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button zoomOutButton;
    }
}

