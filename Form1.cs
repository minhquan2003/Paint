using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Do_An_Paint.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Do_An_Paint
{
    public partial class Form1 : Form
    {
        Graphics gp;
        bool DuongThang = false;
        bool HinhChuNhat = false;
        bool HinhElip = false;
        bool HinhTron = false;
        bool HinhElipCoMau = false;
        bool CungTron = false;
        bool HinhTronCoChu = false;
        bool DaGiac = false;
        bool DaGiacCoChu = false;
        bool HinhChuNhatCoMau = false;
        bool VeBrush = false;
        bool dichuyen;
        int x = -1;
        int y = -1;
        Pen myPen;
        Color myColor;
        Brush myBrush;
        bool isStart = false;
        ColorDialog mauPen = new ColorDialog();
        ColorDialog mauHinh = new ColorDialog();

        List<cLine> lLine = new List<cLine>();
        List<List<Point>> Polygons = new List<List<Point>>();
        List<Point> NewPolygon = null;
        Point NewPoint;
        public Form1()
        {
            InitializeComponent();
            gp = this.plMain.CreateGraphics();
            myColor = Color.Blue;
            myPen = new Pen(myColor, 5);
            maunetve.BackColor = mauPen.Color;
            mauhinh.BackColor = mauHinh.Color;
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
         
        private void plMain_MouseDown(object sender, MouseEventArgs e)
        {
            isStart = true;
            if (this.VeBrush == true)
            {
                x = e.X;
                y = e.Y;
            }
            else if (this.DuongThang == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "DuongThang";
                this.lLine.Add(myLine);
            }
            else if (this.HinhChuNhat == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "HinhChuNhat";
                this.lLine.Add(myLine);
            }
            else if (this.HinhElip == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "HinhElip";
                this.lLine.Add(myLine);
            }
            else if (this.HinhTron == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "HinhTron";
                this.lLine.Add(myLine);
            }
            else if (this.CungTron == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "CungTron";
                this.lLine.Add(myLine);
            }
            else if (this.HinhElipCoMau == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mauhinh = new SolidBrush(mauHinh.Color); ;
                myLine.loai = "HinhElipCoMau";
                this.lLine.Add(myLine);
            }
            else if (this.HinhChuNhatCoMau == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mauhinh = new SolidBrush(mauHinh.Color); ;
                myLine.loai = "HinhChuNhatCoMau";
                this.lLine.Add(myLine);
            }
            else if (this.HinhTronCoChu == true)
            {
                cLine myLine = new cLine();
                myLine.p1 = e.Location;
                myLine.p2 = e.Location;
                myLine.doday = (int)doday.Value;
                myLine.mausac = mauPen.Color;
                myLine.loai = "HinhTronCoChu";
                this.lLine.Add(myLine);
            }
            else if (VeDaGiac.Checked)
            {

                if (NewPolygon != null)
                {
                    // We are already drawing a polygon.
                    // If it's the right mouse button, finish this polygon.
                    if (e.Button == MouseButtons.Right)
                    {
                        // Finish this polygon.
                        if (NewPolygon.Count > 2) Polygons.Add(NewPolygon);
                        NewPolygon = null;
                    }
                    else
                    {
                        // Add a point to this polygon.
                        if (NewPolygon[NewPolygon.Count - 1] != e.Location)
                        {
                            NewPolygon.Add(e.Location);
                        }
                    }
                }
                else
                {
                    // Start a new polygon.
                    NewPolygon = new List<Point>();
                    NewPoint = e.Location;
                    NewPolygon.Add(e.Location);
                }

                // Redraw.
                plMain.Invalidate();
            }

        }
        private void plMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isStart == true)
            {
                if (this.VeBrush == true && x != -1 && y != -1)
                {
                    Pen vebrush1 = new Pen(mauPen.Color,(int)doday.Value);
                    gp.DrawLine(vebrush1, new Point(x, y), e.Location);
                    x = e.X;
                    y = e.Y;
                }
                else if (VeDaGiac.Checked)
                {
                    if (NewPolygon == null) return;
                    NewPoint = e.Location;
                    plMain.Invalidate();
                }
                else if (this.VeBrush == false && this.DaGiac == false)
                {
                    this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                    this.plMain.Refresh();
                }
                
            }
        }

        private void plMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.VeBrush == true)
            {
                this.VeBrush = false;
                x = -1;
                y = -1;
            }
            else if (this.DuongThang == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.DuongThang = false;
            }
            else if (this.HinhChuNhat == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhChuNhat = false;
            }
            else if (this.HinhElip == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhElip = false;
            }
            
            else if (this.HinhTron == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhTron = false;
            }
            
            else if (this.CungTron == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.CungTron = false;
            }

            else if (this.HinhElipCoMau == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhElipCoMau = false;
            }

            else if (this.HinhChuNhatCoMau == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhChuNhatCoMau = false;
            }
            
            else if (this.HinhTronCoChu == true)
            {
                this.lLine[this.lLine.Count - 1].p2 = e.Location;//Cập nhật đỉnh thứ 2
                //this.plMain.Refresh();
                this.HinhTronCoChu = false;
            }
            this.isStart = false;
        }

        
        public class cLine
        {
            public Point p1;
            public Point p2;
            public int doday;
            public Color mausac;
            public Brush mauhinh;
            public string loai;
        }

        private void plMain_Paint(object sender, PaintEventArgs e)
        {
            //if (VeDaGiac.CheckState == 0)
            {
                for (int i = 0; i < this.lLine.Count; i++)
                {
                    if (lLine[i].loai == "DuongThang")
                    {
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        gp.DrawLine(myPen, this.lLine[i].p1, this.lLine[i].p2);
                    }
                    else if (lLine[i].loai == "HinhChuNhat")
                    {
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        Rectangle Hcn = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                       this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.DrawRectangle(myPen, Hcn);
                    }
                    else if (lLine[i].loai == "HinhElip")
                    {
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        Rectangle hElip = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                        this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.DrawEllipse(myPen, hElip);
                    }
                    else if (lLine[i].loai == "HinhTron")
                    {
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        Rectangle hTron = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                       this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.DrawEllipse(myPen, hTron);
                    }
                    else if (lLine[i].loai == "CungTron")
                    {
                        float startAngle = 180.0F;
                        float sweepAngle = 180.0F;
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        Rectangle rect = new Rectangle(lLine[i].p1.X, lLine[i].p1.Y,
                            150,150);
                        gp.DrawArc(myPen, rect, startAngle, sweepAngle);
                       
                    }
                    else if (lLine[i].loai == "HinhElipCoMau")
                    {
                        Rectangle hElipm = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                            this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.FillEllipse(this.lLine[i].mauhinh, hElipm);
                    }
                    else if (lLine[i].loai == "HinhChuNhatCoMau")
                    {
                        Rectangle hCNMAU = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                            this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.FillRectangle(this.lLine[i].mauhinh, hCNMAU);
                    }
                    else if (lLine[i].loai == "HinhTronCoChu")
                    {
                        myPen = new Pen(this.lLine[i].mausac, this.lLine[i].doday);
                        Rectangle hTronChu = new Rectangle(this.lLine[i].p1.X, this.lLine[i].p1.Y,
                        this.lLine[i].p2.X - this.lLine[i].p1.X, this.lLine[i].p2.Y - this.lLine[i].p1.Y);
                        gp.DrawEllipse(myPen, hTronChu);
                        float inX = (this.lLine[i].p2.X - this.lLine[i].p1.X) / 2 +
                            this.lLine[i].p1.X;
                        float inY = (this.lLine[i].p2.Y - this.lLine[i].p1.Y) / 2 +
                                        this.lLine[i].p1.Y;
                        Font drawFont = new Font("Arial", 12);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        gp.DrawString("Sample Text", drawFont, drawBrush, inX, inY);
                    }
                    
                }
            }
            if (VeDaGiac.Checked && this.isStart == true)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //e.Graphics.Clear(plMain.BackColor);

                // Draw the old polygons.
                foreach (List<Point> polygon in Polygons)
                {
                    e.Graphics.FillPolygon(Brushes.White, polygon.ToArray());
                    e.Graphics.DrawPolygon(Pens.Blue, polygon.ToArray());
                }

                // Draw the new polygon.
                if (NewPolygon != null)
                {
                    // Draw the new polygon.
                    if (NewPolygon.Count > 1)
                    {
                        Pen penDaGiac = new Pen(mauPen.Color, (int)doday.Value);
                        e.Graphics.DrawLines(penDaGiac, NewPolygon.ToArray());
                    }

                    // Draw the newest edge.
                    if (NewPolygon.Count > 0)
                    {
                        using (Pen dashed_pen = new Pen(Color.Green))
                        {
                            dashed_pen.DashPattern = new float[] { 3, 3 };
                            e.Graphics.DrawLine(dashed_pen,
                                NewPolygon[NewPolygon.Count - 1],NewPoint);
                        }
                    }
                }
            }
        }

        private void duongThang_Click(object sender, EventArgs e)
        {
            this.DuongThang = true;
        }
        private void HCN_Click(object sender, EventArgs e)
        {
            this.HinhChuNhat = true;
        }

        private void hElip_Click(object sender, EventArgs e)
        {
            this.HinhElip = true;
        }

        private void hTron_Click(object sender, EventArgs e)
        {
            this.HinhTron = true;
        }

        private void cTron_Click(object sender, EventArgs e)
        {
            this.CungTron= true;
        }

        private void daGiac_Click(object sender, EventArgs e)
        {
            this.DaGiac= true;
        }

        private void hElipMau_Click(object sender, EventArgs e)
        {
            this.HinhElipCoMau= true;
        }

        private void HCNMau_Click(object sender, EventArgs e)
        {
            this.HinhChuNhatCoMau = true;
        }

        private void hTroncoChu_Click(object sender, EventArgs e)
        {
            this.HinhTronCoChu = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mauPen.ShowDialog();
            maunetve.BackColor = mauPen.Color;
        }

        private void mauhinh_Click(object sender, EventArgs e)
        {
            mauHinh.ShowDialog();
            mauhinh.BackColor = mauHinh.Color;
        }

        private void btnBrush_Click(object sender, EventArgs e)
        {
            this.VeBrush = true;
        }

    }
}  
