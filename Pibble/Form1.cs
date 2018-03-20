using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pibble
{
    public partial class Form1 : Form
    {
        DrawArea drawArea;

        int circleRadius;

        bool mouseDown;

        bool drawRectTooltip;

        Color selectedColor;

        int rectX1, rectX2, rectY1, rectY2;

        enum Tools {
            Pen,
            Eraser,
            Brush,
            Rectangle,
            Line,
            Fill,
            Circle
        }

        int selectedTool;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            drawArea = new DrawArea(200, 200, 16, 16);

            initDrawArea();
             
            selectedColor = Color.Black;

            drawArea.Center(Width, Height);

        }       

        private void drawArea_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;

            switch (selectedTool) {
                case (int)Tools.Rectangle:
                    drawRectTooltip = true;
                    rectX1 = e.X;
                    rectY1 = e.Y;
                    break;
                case (int)Tools.Line:
                    rectX1 = e.X;
                    rectY1 = e.Y;
                    break;
                case (int)Tools.Circle:

                    break;
            }

        }

        private void drawArea_MouseUp(object sender, MouseEventArgs e)
        {
            switch (selectedTool) {
                case (int)Tools.Rectangle:

                    drawRectTooltip = false;
                    rectX2 = e.X;
                    rectY2 = e.Y;

                    drawArea.DrawRectangle(rectX1, rectY1, rectX2, rectY2, selectedColor);

                    break;
                case (int)Tools.Line:
                    rectX2 = e.X;
                    rectY2 = e.Y;

                    drawArea.DrawLine(rectX1, rectY1, rectX2, rectY2, selectedColor);

                    break;
                case (int)Tools.Circle:

                    break;

            }

            mouseDown = false;
        }

        private void drawArea_MouseMove(object sender, MouseEventArgs e)
        {
            switch (selectedTool) {
                case (int)Tools.Pen:
                    if (mouseDown) {
                        drawArea.Draw(e.X, e.Y, selectedColor);
                    }
                    break;
                case (int)Tools.Eraser:
                    if (mouseDown) {

                        drawArea.Draw(e.X, e.Y, Color.Transparent);
                    }
                    break;
                case (int)Tools.Rectangle:
                    if (mouseDown) {

                        drawArea.DrawRectTooltip(rectX1, rectY1, e.X, e.Y, selectedColor);

                    }
                    break;
                case (int)Tools.Line:

                    if (mouseDown) {

                        drawArea.DrawLineTooltip(rectX1, rectY1, e.X, e.Y, selectedColor);

                    }

                    break;
                
            }
        }

        private void drawArea_Click(object sender, MouseEventArgs e) {
            switch (selectedTool) {
                case (int)Tools.Pen:
                    drawArea.Draw(e.X, e.Y, selectedColor);              
                    break;

                case (int)Tools.Eraser:
                    drawArea.Draw(e.X, e.Y, Color.Transparent);
                    break;

                case (int)Tools.Fill:
                    drawArea.FillStart(e.X, e.Y, selectedColor);
                    break;

                case (int)Tools.Circle:
                    drawArea.DrawCircle(e.X, e.Y, 7, selectedColor);
                    break;
                
            }
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.Pen;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.Eraser;
        }

        private void rectButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.Rectangle;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.Line;
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.Fill;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            selectedTool = (int)Tools.Circle;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                selectedColor = colorDialog.Color;
                colorButton.BackColor = selectedColor;
            }

        }

        private void initDrawArea()
        {
            this.Controls.Add(drawArea);

            drawArea.Parent = paintPanel;

            

            drawArea.MouseDown += new MouseEventHandler(drawArea_MouseDown);
            drawArea.MouseUp += new MouseEventHandler(drawArea_MouseUp);
            drawArea.MouseClick += new MouseEventHandler(drawArea_Click);
            drawArea.MouseMove += new MouseEventHandler(drawArea_MouseMove);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            drawArea.Center(paintPanel.Width, paintPanel.Height);
        }


    }
}
