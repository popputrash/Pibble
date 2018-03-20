using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Collections.Generic;

namespace Pibble
{
    class DrawArea : PictureBox {
        private Bitmap bmp;
        private Bitmap tmpBmp;

        int cellSize;
        int numOfCellsX;
        int numOfCellsY;

        Graphics g;

        public int scale = 0;

        public bool Grid { get; set; }

        public DrawArea(int x, int y, int width, int height) {

            this.Width = width;
            this.Height = height;

            numOfCellsX = width;
            numOfCellsY = height;

            scale = 20;

            this.Scale(new SizeF(scale, scale));

            g = this.CreateGraphics();

            this.Location = new Point(x, y);

            this.BackColor = Color.White;

            this.SizeMode = PictureBoxSizeMode.StretchImage;

            bmp = new Bitmap(width, height);
            tmpBmp = bmp;

            cellSize = this.Height / height;

            this.Image = bmp;

            Grid = true;
        }

        public void Draw(int x, int y, Color color) {
            bmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);

            this.Image = bmp;

            Refresh();
        }

        public void DrawToTemp(int x, int y, Color color) {
            tmpBmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);


        }

        public void DrawRectangle(int x1, int y1, int x2, int y2, Color color) {

            if (x1 <= x2 && y1 <= y2) {
                for (int i = x1; i <= x2; i++) {
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y1, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y2, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
                for (int i = y1; i <= y2; i++) {
                    bmp.SetPixel(Util.LimitToRange(x1, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(x2, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
            //Vänster Ner
            else if (x1 >= x2 && y1 <= y2) {
                for (int i = x2; i <= x1; i++) {
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y1, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y2, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
                for (int i = y1; i <= y2; i++) {
                    bmp.SetPixel(Util.LimitToRange(x1, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(x2, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
            //Höger Upp
            else if (x1 <= x2 && y1 >= y2) {
                for (int i = x1; i <= x2; i++) {
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y1, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y2, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
                for (int i = y2; i <= y1; i++) {
                    bmp.SetPixel(Util.LimitToRange(x1, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(x2, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
            //Vänster Upp
            else if (x1 >= x2 && y1 >= y2) {
                for (int i = x2; i <= x1; i++) {
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y1, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(i, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y2, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
                for (int i = y2; i <= y1; i++) {
                    bmp.SetPixel(Util.LimitToRange(x1, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                    bmp.SetPixel(Util.LimitToRange(x2, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(i, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
        }

        public void DrawRectTooltip(int x1, int y1, int x2, int y2, Color color) {

            tmpBmp = new Bitmap(bmp);

            if (x1 <= x2 && y1 <= y2) {
                for (int i = x1; i <= x2; i++) {
                    DrawToTemp(i, y1, color);
                    DrawToTemp(i, y2, color);
                }
                for (int i = y1; i <= y2; i++) {
                    DrawToTemp(x1, i, color);
                    DrawToTemp(x2, i, color);
                }
            }
            //Vänster Ner
            else if (x1 >= x2 && y1 <= y2) {
                for (int i = x2; i <= x1; i++) {
                    DrawToTemp(i, y1, color);
                    DrawToTemp(i, y2, color);
                }
                for (int i = y1; i <= y2; i++) {
                    DrawToTemp(x1, i, color);
                    DrawToTemp(x2, i, color);
                }
            }
            //Höger Upp
            else if (x1 <= x2 && y1 >= y2) {
                for (int i = x1; i <= x2; i++) {
                    DrawToTemp(i, y1, color);
                    DrawToTemp(i, y2, color);
                }
                for (int i = y2; i <= y1; i++) {
                    DrawToTemp(x1, i, color);
                    DrawToTemp(x2, i, color);
                }
            }
            //Vänster Upp
            else if (x1 >= x2 && y1 >= y2) {
                for (int i = x2; i <= x1; i++) {
                    DrawToTemp(i, y1, color);
                    DrawToTemp(i, y2, color);
                }
                for (int i = y2; i <= y1; i++) {
                    DrawToTemp(x1, i, color);
                    DrawToTemp(x2, i, color);
                }
            }

            this.Image = tmpBmp;

        }

        public void DrawLine(int x1, int y1, int x2, int y2, Color color) {

            //Höger Ner
            if (x1 <= x2 && y1 <= y2) {
                int dx = x2 - x1;
                int dy = y2 - y1;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x1; x <= x2; x++) {
                    int y = y1 + dy * (x - x1) / dx;
                    bmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }

            }
           //Vänster Ner
           else if (x1 >= x2 && y1 <= y2) {
                int dx = x1 - x2;
                int dy = y2 - y1;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x2; x <= x1; x++) {
                    int y = y1 - dy * (x - x1) / dx;
                    bmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
           //Höger Upp
           else if (x1 <= x2 && y1 >= y2) {
                int dx = x2 - x1;
                int dy = y1 - y2;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x1; x <= x2; x++) {
                    int y = y1 - dy * (x - x1) / dx;
                    bmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }
            }
           //Vänster Upp
           else if (x1 >= x2 && y1 >= y2) {
                int dx = x1 - x2;
                int dy = y1 - y2;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x2; x <= x1; x++) {
                    int y = y1 + dy * (x - x1) / dx;
                    bmp.SetPixel(Util.LimitToRange(x, 0, Width - 1) / Util.LimitToRange(scale, 1, -1), Util.LimitToRange(y, 0, Height - 1) / Util.LimitToRange(scale, 1, -1), color);
                }



            }
            this.Image = bmp;
            Refresh();
        }

        public void DrawLineTooltip(int x1, int y1, int x2, int y2, Color color) {

            tmpBmp = new Bitmap(bmp);

            //Höger Ner
            if (x1 <= x2 && y1 <= y2) {
                int dx = x2 - x1;
                int dy = y2 - y1;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x1; x <= x2; x++) {
                    int y = y1 + dy * (x - x1) / dx;
                    DrawToTemp(x, y, color);
                }

            }
           //Vänster Ner
           else if (x1 >= x2 && y1 <= y2) {
                int dx = x1 - x2;
                int dy = y2 - y1;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x2; x <= x1; x++) {
                    int y = y1 - dy * (x - x1) / dx;
                    DrawToTemp(x, y, color);
                }
            }
           //Höger Upp
           else if (x1 <= x2 && y1 >= y2) {
                int dx = x2 - x1;
                int dy = y1 - y2;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x1; x <= x2; x++) {
                    int y = y1 - dy * (x - x1) / dx;
                    DrawToTemp(x, y, color);
                }
            }
           //Vänster Upp
           else if (x1 >= x2 && y1 >= y2) {
                int dx = x1 - x2;
                int dy = y1 - y2;

                dx = (dx == 0) ? 1 : dx;
                dy = (dy == 0) ? 1 : dy;

                for (int x = x2; x <= x1; x++) {
                    int y = y1 + dy * (x - x1) / dx;
                    DrawToTemp(x, y, color);
                }
            }
            this.Image = tmpBmp;
            Refresh();
        }

        public void FillStart(int x, int y, Color rColor) {
            x = x / scale;
            y = y / scale;
            Fill(x, y, rColor);
        }

        public void Fill(int x, int y, Color rColor) {

            if (bmp.GetPixel(x, y).ToArgb() != rColor.ToArgb()) {
                Stack<Point> pixels = new Stack<Point>();
                Color tColor = bmp.GetPixel(x, y);
                pixels.Push(new Point(x, y));

                while (pixels.Count > 0) {

                    Point a = pixels.Pop();
                    if (a.X < numOfCellsX && a.X >= 0 && a.Y < numOfCellsY && a.Y >= 0) {
                        if (bmp.GetPixel(a.X, a.Y) == tColor) {
                            bmp.SetPixel(a.X, a.Y, rColor);
                            pixels.Push(new Point(a.X - 1, a.Y));
                            pixels.Push(new Point(a.X + 1, a.Y));
                            pixels.Push(new Point(a.X, a.Y - 1));
                            pixels.Push(new Point(a.X, a.Y + 1));

                        }
                    }

                }

                this.Image = bmp;
            }
        }

        public void DrawCircle(int centerX, int centerY, int radius, Color color) {

            centerX = centerX / scale;
            centerY = centerY / scale;

            int d = (5 - radius * 4) / 4;

            int x = 0;

            int y = radius;

            do {
                if (centerX + x >= 0 && centerX + x <= numOfCellsX - 1 && centerY + y >= 0 && centerY + y <= numOfCellsY - 1)bmp.SetPixel(centerX + x, centerY + y, color);
                if (centerX + x >= 0 && centerX + x <= numOfCellsX - 1 && centerY - y >= 0 && centerY - y <= numOfCellsY - 1)bmp.SetPixel(centerX + x, centerY - y, color);
                if (centerX - x >= 0 && centerX - x <= numOfCellsX - 1 && centerY + y >= 0 && centerY + y <= numOfCellsY - 1)bmp.SetPixel(centerX - x, centerY + y, color);
                if (centerX - x >= 0 && centerX - x <= numOfCellsX - 1 && centerY - y >= 0 && centerY - y <= numOfCellsY - 1)bmp.SetPixel(centerX - x, centerY - y, color);
                if (centerX + y >= 0 && centerX + y <= numOfCellsX - 1 && centerY + x >= 0 && centerY + x <= numOfCellsY - 1)bmp.SetPixel(centerX + y, centerY + x, color);
                if (centerX + y >= 0 && centerX + y <= numOfCellsX - 1 && centerY - x >= 0 && centerY - x <= numOfCellsY - 1)bmp.SetPixel(centerX + y, centerY - x, color);
                if (centerX - y >= 0 && centerX - y <= numOfCellsX - 1 && centerY + x >= 0 && centerY + x <= numOfCellsY - 1)bmp.SetPixel(centerX - y, centerY + x, color);
                if (centerX - y >= 0 && centerX - y <= numOfCellsX - 1 && centerY - x >= 0 && centerY - x <= numOfCellsY - 1)bmp.SetPixel(centerX - y, centerY - x, color);
                if (d < 0) {
                    d += 2 * x + 1;
                } else {
                    d += 2 * (x - y) + 1;
                    y--;
                }
                x++;
            } while (x <= y);

            Refresh();

        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;

            pe.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            base.OnPaint(pe);

            if (Grid) {
                for (int y = 0; y < Height; y++) {

                    pe.Graphics.DrawLine(new Pen(Color.Black), 0, y * cellSize, numOfCellsX * cellSize, y * cellSize);

                }

                for (int x = 0; x < Height; x++) {

                    pe.Graphics.DrawLine(new Pen(Color.Black), x * cellSize, 0, x * cellSize, numOfCellsX * cellSize);

                }

            }

           
        }

        public void Center(int w, int h) {

            this.Location = new Point((w / 2) - Width / 2, (h / 2) - Height / 2);

        } 
    }
}
