using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Input;

namespace Pibble
{
    public partial class Form1 : Form
    {
        DrawArea drawArea;

        int circleRadius;

        bool mouseDown;

        string fileName;

        bool saved;

        bool drawRectTooltip;

        Color selectedColor;

        int tempX1, tempX2, tempY1, tempY2;

        private const int cGrip = 16;
        private const int cCaption = 32;

        enum Tools {
            Pen,
            Eraser,
            Brush,
            Rectangle,
            Line,
            Fill,
            Circle,
            ZoomOut,
            ZoomIn,

        }

        int selectedTool;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            selectedColor = Color.Black;

            drawArea = new DrawArea();

            createNewFile();

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void drawArea_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {

            mouseDown = true;

            switch (selectedTool) {
                case (int)Tools.Rectangle:
                    
                    drawRectTooltip = true;
                    tempX1 = e.X;
                    tempY1 = e.Y;
                    saved = false;
                    break;
                case (int)Tools.Line:
                    tempX1 = e.X;
                    tempY1 = e.Y;
                    saved = false;
                    break;
                case (int)Tools.Circle:

                    tempX1 = e.X;
                    tempY1 = e.Y;
                    saved = false;
                    break;
            }

        }

        private void drawArea_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (selectedTool) {
                case (int)Tools.Rectangle:

                    drawRectTooltip = false;
                    tempX2 = e.X;
                    tempY2 = e.Y;

                    drawArea.DrawRectangle(tempX1, tempY1, tempX2, tempY2, selectedColor);

                    break;
                case (int)Tools.Line:
                    tempX2 = e.X;
                    tempY2 = e.Y;

                    drawArea.DrawLine(tempX1, tempY1, tempX2, tempY2, selectedColor);

                    break;
                case (int)Tools.Circle:

                    tempX2 = e.X;
                    tempY2 = e.Y;

                    drawArea.DrawCircle(tempX1,tempY1,tempX2, tempY2, selectedColor);

                    break;

            }

            mouseDown = false;
        }

        private void drawArea_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            switch (selectedTool) {
                case (int)Tools.Pen:
                    if (mouseDown) {
                        drawArea.Draw(e.X, e.Y, selectedColor);
                        saved = false;
                    }
                    break;
                case (int)Tools.Eraser:
                    if (mouseDown) {

                        drawArea.Draw(e.X, e.Y, Color.Transparent);
                        saved = false;
                    }
                    break;
                case (int)Tools.Rectangle:
                    if (mouseDown) {

                        drawArea.DrawRectTooltip(tempX1, tempY1, e.X, e.Y, selectedColor);

                    }
                    break;
                case (int)Tools.Line:

                    if (mouseDown) {

                        drawArea.DrawLineTooltip(tempX1, tempY1, e.X, e.Y, selectedColor);

                    }

                    break;
               
                case (int)Tools.Circle:

                    if (mouseDown) {

                        drawArea.DrawCircleTooltip(tempX1, tempY1, e.X, e.Y, selectedColor);

                    }

                    break;

            }
        }

        private void drawArea_Click(object sender, System.Windows.Forms.MouseEventArgs e) {
            switch (selectedTool) {
                case (int)Tools.Pen:
                    drawArea.Draw(e.X, e.Y, selectedColor);
                    saved = false;
                    break;

                case (int)Tools.Eraser:
                    drawArea.Draw(e.X, e.Y, Color.Transparent);
                    saved = false;
                    break;

                case (int)Tools.Fill:
                    drawArea.FillStart(e.X, e.Y, selectedColor);
                    saved = false;
                    break;

                case (int)Tools.ZoomOut:

                    drawArea.ZoomOut(e.X, e.Y);

                    break;
                case (int)Tools.ZoomIn:

                    drawArea.ZoomIn(e.X, e.Y);

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

        private void button5_Click(object sender, EventArgs e) {

            selectedTool = (int)Tools.Circle;

        }

        private void toolPanel_Paint(object sender, PaintEventArgs e)
        {

        }

#region Move handler

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
#endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {

            createNewFile();
            
        }

        private void rectButton_MouseHover(object sender, EventArgs e)
        {
            toolTipRect.Show("Draws a rectangle, click and drag", rectButton);
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

        private void btnSave_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

        }

        private void initDrawArea()
        {
            this.Controls.Add(drawArea);

            drawArea.Parent = paintPanel;

            drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(drawArea_MouseDown);
            drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(drawArea_MouseUp);
            drawArea.MouseClick += new System.Windows.Forms.MouseEventHandler(drawArea_Click);
            drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(drawArea_MouseMove);

            drawArea.Center(paintPanel.Width, paintPanel.Height);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveNewFile();
        }

        private void zoomOutbBtn_Click(object sender, EventArgs e) {

            selectedTool = (int)Tools.ZoomOut;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open imaeg";
            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {

                if(drawArea.Image == null && !saved) {

                    if (MessageBox.Show("The open image is not saved, would you like to save?", "Pibble", MessageBoxButtons.OKCancel) == DialogResult.OK) {

                        saveNewFile();

                    };                 

                }

                drawArea.Dispose();

                drawArea = new DrawArea(0, 0, new Bitmap(openFileDialog.FileName).Width, new Bitmap(openFileDialog.FileName).Height);

                drawArea.SetBitmap(new Bitmap(openFileDialog.FileName));

                initDrawArea();

            }

        }

        private void paintPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.ZoomIn;
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            selectedTool = (int)Tools.ZoomOut;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Console.WriteLine("resize");
            if(drawArea != null)drawArea.Center(Width, Height);

        }

        private void createNewFile() { 
            saved = true;

            NewFile newFile = new NewFile();
            newFile.ShowDialog();

            if (newFile.DialogResult == DialogResult.OK) {

                drawArea.Dispose();

                drawArea = new DrawArea(0, 0, newFile.width, newFile.height);

                initDrawArea();

            }

        }

        private void saveNewFile() {

            saved = true;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "unknown.bmp";

            saveFileDialog.Filter = "Bitmap Image (.bmp)|*.bmp";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                drawArea.GetBitmap().Save(saveFileDialog.FileName, ImageFormat.Bmp);
                fileName = saveFileDialog.FileName;
            }

        }
    }
}
