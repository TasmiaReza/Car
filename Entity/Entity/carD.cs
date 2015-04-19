using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing;

namespace Entity
{
    public class carD
    {
        public int speed;

        Pen drawPen = new Pen(Color.Black, 1);
        Brush brBLK = new SolidBrush(Color.Black);
        Brush brBLU = new SolidBrush(Color.Blue);
        Brush brLSG = new SolidBrush(Color.LightSlateGray);
        Brush brDKG = new SolidBrush(Color.DarkGray);
        Brush brDMG = new SolidBrush(Color.DimGray);
        Brush brCRB = new SolidBrush(Color.CornflowerBlue);

        Brush brGrass = new SolidBrush(Color.MediumSeaGreen);
        Brush brRoad = new SolidBrush(Color.LightSteelBlue);
        Brush brMid = new SolidBrush(Color.Gray);
        //
        Brush br1 = new SolidBrush(Color.Orchid);
        Brush br2 = new SolidBrush(Color.DarkGray);
        Brush br3 = new SolidBrush(Color.LightSlateGray);
        Brush br4 = new SolidBrush(Color.DimGray);
        Brush br5 = new SolidBrush(Color.DimGray);
        Brush br6 = new SolidBrush(Color.DimGray);





        public void drawRect0(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 0);
            Point r1p2 = new Point(800, 0);
            Point r1p3 = new Point(800, 600);
            Point r1p4 = new Point(0, 600);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brRoad, p);
        }
        public void drawRect1(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 0);
            Point r1p2 = new Point(450, 0);
            Point r1p3 = new Point(450, 80);
            Point r1p4 = new Point(0, 80);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect2(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(0, 250);
            Point r1p2 = new Point(50, 250);
            Point r1p3 = new Point(50, 600);
            Point r1p4 = new Point(0, 600);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect3(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(770, 250);
            Point r1p2 = new Point(800, 250);
            Point r1p3 = new Point(800, 600);
            Point r1p4 = new Point(770, 600);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect4(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(50, 500);
            Point r1p2 = new Point(770, 500);
            Point r1p3 = new Point(770, 600);
            Point r1p4 = new Point(50, 600);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect5(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p1 = new Point(450, 0);
            Point r1p2 = new Point(800, 0);
            Point r1p3 = new Point(800, 250);
            Point r1p4 = new Point(450, 250);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brGrass, p);
        }
        public void drawRect6(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Point r1p5 = new Point(180, 250);
            Point r1p6 = new Point(480, 250);
            Point r1p7 = new Point(480, 320);
            Point r1p8 = new Point(180, 320);
            Point[] p2 = { r1p5, r1p6, r1p7, r1p8 };
            e.Graphics.FillPolygon(brMid, p2);

            Point r1p1 = new Point(180, 320);
            Point r1p2 = new Point(500, 320);
            Point r1p3 = new Point(500, 370);
            Point r1p4 = new Point(180, 370);
            Point[] p = { r1p1, r1p2, r1p3, r1p4 };
            e.Graphics.FillPolygon(brMid, p);
        }

        public void drawLoop(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillEllipse(brRoad, 370, -5, 450, 350);
            e.Graphics.FillEllipse(new SolidBrush(Color.DarkSlateGray), 590, 140, 50, 50);
            e.Graphics.FillEllipse(new SolidBrush(Color.LightSlateGray), 593, 143, 44, 44);
            e.Graphics.FillEllipse(new SolidBrush(Color.Black), 613, 163, 5, 5);
        
        }


        public void carDrawUp_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            //outer body
            Point P1 = new Point(25, 8);
            Point P2 = new Point(33, 3);
            Point P3 = new Point(48, 3);
            Point P4 = new Point(55, 8);
            Point P5 = new Point(55, 18);
            Point P6 = new Point(57, 20);
            Point P7 = new Point(57, 25);
            Point P8 = new Point(55, 28);
            Point P9 = new Point(55, 53);
            Point P10 = new Point(57, 55);
            Point P11 = new Point(57, 60);
            Point P12 = new Point(55, 63);
            Point P13 = new Point(55, 66);
            Point P14 = new Point(48, 69);
            Point P15 = new Point(33, 69);
            Point P16 = new Point(25, 66);
            Point P17 = new Point(25, 63);
            Point P18 = new Point(23, 60);
            Point P19 = new Point(23, 55);
            Point P20 = new Point(25, 50);
            Point P21 = new Point(25, 28);
            Point P22 = new Point(23, 25);
            Point P23 = new Point(23, 20);
            Point P24 = new Point(25, 18);


            //roof
            Point aP1 = new Point(27, 10);
            Point aP2 = new Point(33, 6);
            Point aP3 = new Point(46, 6);
            Point aP4 = new Point(53, 10);
            Point aP5 = new Point(53, 60);
            Point aP6 = new Point(49, 63);
            Point aP7 = new Point(30, 63);
            Point aP8 = new Point(27, 60);
            Point aP9 = new Point(33, 55);
            Point aP10 = new Point(47, 55);
            Point aP11 = new Point(47, 30);
            Point aP12 = new Point(46, 28);
            Point aP13 = new Point(34, 28);
            Point aP14 = new Point(33, 30);
            Point aP15 = new Point(27, 20);
            Point aP16 = new Point(36, 15);
            Point aP17 = new Point(43, 15);
            Point aP18 = new Point(53, 20);
            Point aP19 = new Point(24, 55);
            Point aP20 = new Point(25, 58);
            Point aP21 = new Point(25, 28);
            Point aP22 = new Point(24, 25);
            Point aP23 = new Point(24, 20);
            Point aP24 = new Point(25, 18);

            //color

            var p = sender as Panel;
            var g = e.Graphics;

            Point[] cPA1 = { P1, P2, P3, P4, P5, P8, P9, P12, P13, P14, P15, P16, P17, P20, P21, P24, P1 };
            g.FillPolygon(brBLU, cPA1);

            Point[] cPA2 = { aP1, aP2, aP3, aP4, aP18, aP17, aP16, aP15, aP1 };
            g.FillPolygon(brCRB, cPA2);

            Point[] cPA3 = { aP15, aP16, aP17, aP18, aP11, aP12, aP13, aP14, aP15 };
            g.FillPolygon(brLSG, cPA3);
            Point[] cPA4 = { aP9, aP10, aP6, aP7 };
            g.FillPolygon(brLSG, cPA4);

            Point[] cPA5 = { aP18, aP11, aP10, aP6, aP5 };
            g.FillPolygon(brDMG, cPA5);
            Point[] cPA6 = { aP15, aP14, aP9, aP7, aP8 };
            g.FillPolygon(brDMG, cPA6);


            Point[] cPA7 = { P5, P6, P7, P8 };
            g.FillPolygon(brBLK, cPA7);
            Point[] cPA8 = { P9, P10, P11, P12 };
            g.FillPolygon(brBLK, cPA8);
            Point[] cPA9 = { P17, P18, P19, P20 };
            g.FillPolygon(brBLK, cPA9);
            Point[] cPA0 = { P21, P22, P23, P24 };
            g.FillPolygon(brBLK, cPA0);


            Point[] cPAr = { aP12, aP11, aP10, aP9, aP14, aP13 };
            g.FillPolygon(brCRB, cPAr);

            //skeleton
            Point[] PA = { P1, P2, P3, P4, P5, P6, P7, P8, P5, P8, P9, P10, P11, P12,
                            P9, P12, P13, P14, P15, P16, P17, P18, P19, P20, P17, P20, P17,
                                P21, P22, P23, P24, P21, P1 };

            e.Graphics.DrawLines(drawPen, PA);




            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP7, aP8, aP1, aP8, aP7, aP9, aP10, aP6, aP10,
                                aP11, aP12, aP13, aP14, aP9, aP14, aP15, aP16, aP17, aP18, aP11 };

            e.Graphics.DrawLines(drawPen, PA2);

            //two doors
            e.Graphics.DrawLine(drawPen, 26, 38, 33, 38);
            e.Graphics.DrawLine(drawPen, 47, 38, 53, 38);

            //text
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Teal);
            PointF PF = new PointF(31.0f, 33.0f);
            e.Graphics.DrawString("O", drawFont, drawBrush, PF);

        }


        public void carDrawDown_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            //outer body
            Point P1 = new Point(25, 72);
            Point P2 = new Point(33, 77);
            Point P3 = new Point(48, 77);
            Point P4 = new Point(55, 72);
            Point P5 = new Point(55, 62);
            Point P6 = new Point(57, 60);
            Point P7 = new Point(57, 55);
            Point P8 = new Point(55, 52);
            Point P9 = new Point(55, 27);
            Point P10 = new Point(57, 25);
            Point P11 = new Point(57, 20);
            Point P12 = new Point(55, 17);
            Point P13 = new Point(55, 14);
            Point P14 = new Point(48, 11);
            Point P15 = new Point(33, 11);
            Point P16 = new Point(25, 14);
            Point P17 = new Point(25, 17);
            Point P18 = new Point(23, 20);
            Point P19 = new Point(23, 25);
            Point P20 = new Point(25, 30);
            Point P21 = new Point(25, 52);
            Point P22 = new Point(23, 55);
            Point P23 = new Point(23, 60);
            Point P24 = new Point(25, 62);


            //roof
            Point aP1 = new Point(27, 70);
            Point aP2 = new Point(33, 74);
            Point aP3 = new Point(46, 74);
            Point aP4 = new Point(53, 70);
            Point aP5 = new Point(53, 20);
            Point aP6 = new Point(49, 17);
            Point aP7 = new Point(30, 17);
            Point aP8 = new Point(27, 20);
            Point aP9 = new Point(33, 25);
            Point aP10 = new Point(47, 25);
            Point aP11 = new Point(47, 50);
            Point aP12 = new Point(46, 52);
            Point aP13 = new Point(34, 52);
            Point aP14 = new Point(33, 50);
            Point aP15 = new Point(27, 60);
            Point aP16 = new Point(36, 65);
            Point aP17 = new Point(43, 65);
            Point aP18 = new Point(53, 60);
            Point aP19 = new Point(24, 25);
            Point aP20 = new Point(25, 22);
            Point aP21 = new Point(25, 52);
            Point aP22 = new Point(24, 55);
            Point aP23 = new Point(24, 60);
            Point aP24 = new Point(25, 62);

            //color

            var p = sender as Panel;
            var g = e.Graphics;

            Point[] cPA1 = { P1, P2, P3, P4, P5, P8, P9, P12, P13, P14, P15, P16, P17, P20, P21, P24, P1 };
            g.FillPolygon(brBLU, cPA1);

            Point[] cPA2 = { aP1, aP2, aP3, aP4, aP18, aP17, aP16, aP15, aP1 };
            g.FillPolygon(brCRB, cPA2);

            Point[] cPA3 = { aP15, aP16, aP17, aP18, aP11, aP12, aP13, aP14, aP15 };
            g.FillPolygon(brLSG, cPA3);
            Point[] cPA4 = { aP9, aP10, aP6, aP7 };
            g.FillPolygon(brLSG, cPA4);

            Point[] cPA5 = { aP18, aP11, aP10, aP6, aP5 };
            g.FillPolygon(brDMG, cPA5);
            Point[] cPA6 = { aP15, aP14, aP9, aP7, aP8 };
            g.FillPolygon(brDMG, cPA6);


            Point[] cPA7 = { P5, P6, P7, P8 };
            g.FillPolygon(brBLK, cPA7);
            Point[] cPA8 = { P9, P10, P11, P12 };
            g.FillPolygon(brBLK, cPA8);
            Point[] cPA9 = { P17, P18, P19, P20 };
            g.FillPolygon(brBLK, cPA9);
            Point[] cPA0 = { P21, P22, P23, P24 };
            g.FillPolygon(brBLK, cPA0);


            Point[] cPAr = { aP12, aP11, aP10, aP9, aP14, aP13 };
            g.FillPolygon(brCRB, cPAr);

            //skeleton
            Point[] PA = { P1, P2, P3, P4, P5, P6, P7, P8, P5, P8, P9, P10, P11, P12,
                            P9, P12, P13, P14, P15, P16, P17, P18, P19, P20, P17, P20, P17,
                                P21, P22, P23, P24, P21, P1 };

            e.Graphics.DrawLines(drawPen, PA);




            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP7, aP8, aP1, aP8, aP7, aP9, aP10, aP6, aP10,
                                aP11, aP12, aP13, aP14, aP9, aP14, aP15, aP16, aP17, aP18, aP11 };

            e.Graphics.DrawLines(drawPen, PA2);

            //two doors
            e.Graphics.DrawLine(drawPen, 26, 42, 33, 42);
            e.Graphics.DrawLine(drawPen, 47, 42, 53, 42);

            //text
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Teal);
            PointF PF = new PointF(31.0f, 29.0f);
            e.Graphics.DrawString("O", drawFont, drawBrush, PF);

        }

        public void carDrawLeft_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            //outer body
            Point P1 = new Point(8, 25);
            Point P2 = new Point(3, 33);
            Point P3 = new Point(3, 48);
            Point P4 = new Point(8, 55);
            Point P5 = new Point(18, 55);
            Point P6 = new Point(20, 57);
            Point P7 = new Point(25, 57);
            Point P8 = new Point(28, 55);
            Point P9 = new Point(53, 55);
            Point P10 = new Point(55, 57);
            Point P11 = new Point(60, 57);
            Point P12 = new Point(63, 55);
            Point P13 = new Point(66, 55);
            Point P14 = new Point(69, 48);
            Point P15 = new Point(69, 33);
            Point P16 = new Point(66, 25);
            Point P17 = new Point(63, 25);
            Point P18 = new Point(60, 23);
            Point P19 = new Point(55, 23);
            Point P20 = new Point(50, 25);
            Point P21 = new Point(28, 25);
            Point P22 = new Point(25, 23);
            Point P23 = new Point(20, 23);
            Point P24 = new Point(18, 25);


            //roof
            Point aP1 = new Point(10, 27);
            Point aP2 = new Point(6, 33);
            Point aP3 = new Point(6, 46);
            Point aP4 = new Point(10, 53);
            Point aP5 = new Point(60, 53);
            Point aP6 = new Point(63, 49);
            Point aP7 = new Point(63, 30);
            Point aP8 = new Point(60, 27);
            Point aP9 = new Point(55, 33);
            Point aP10 = new Point(55, 47);
            Point aP11 = new Point(30, 47);
            Point aP12 = new Point(28, 46);
            Point aP13 = new Point(28, 34);
            Point aP14 = new Point(30, 33);
            Point aP15 = new Point(20, 27);
            Point aP16 = new Point(15, 36);
            Point aP17 = new Point(15, 43);
            Point aP18 = new Point(20, 53);
            Point aP19 = new Point(55, 24);
            Point aP20 = new Point(58, 25);
            Point aP21 = new Point(28, 25);
            Point aP22 = new Point(25, 24);
            Point aP23 = new Point(20, 24);
            Point aP24 = new Point(18, 25);

            //color

            var p = sender as Panel;
            var g = e.Graphics;

            Point[] cPA1 = { P1, P2, P3, P4, P5, P8, P9, P12, P13, P14, P15, P16, P17, P20, P21, P24, P1 };
            g.FillPolygon(brBLU, cPA1);

            Point[] cPA2 = { aP1, aP2, aP3, aP4, aP18, aP17, aP16, aP15, aP1 };
            g.FillPolygon(brCRB, cPA2);

            Point[] cPA3 = { aP15, aP16, aP17, aP18, aP11, aP12, aP13, aP14, aP15 };
            g.FillPolygon(brLSG, cPA3);
            Point[] cPA4 = { aP9, aP10, aP6, aP7 };
            g.FillPolygon(brLSG, cPA4);

            Point[] cPA5 = { aP18, aP11, aP10, aP6, aP5 };
            g.FillPolygon(brDMG, cPA5);
            Point[] cPA6 = { aP15, aP14, aP9, aP7, aP8 };
            g.FillPolygon(brDMG, cPA6);


            Point[] cPA7 = { P5, P6, P7, P8 };
            g.FillPolygon(brBLK, cPA7);
            Point[] cPA8 = { P9, P10, P11, P12 };
            g.FillPolygon(brBLK, cPA8);
            Point[] cPA9 = { P17, P18, P19, P20 };
            g.FillPolygon(brBLK, cPA9);
            Point[] cPA0 = { P21, P22, P23, P24 };
            g.FillPolygon(brBLK, cPA0);


            Point[] cPAr = { aP12, aP11, aP10, aP9, aP14, aP13 };
            g.FillPolygon(brCRB, cPAr);

            //skeleton
            Point[] PA = { P1, P2, P3, P4, P5, P6, P7, P8, P5, P8, P9, P10, P11, P12,
                            P9, P12, P13, P14, P15, P16, P17, P18, P19, P20, P17, P20, P17,
                                P21, P22, P23, P24, P21, P1 };

            e.Graphics.DrawLines(drawPen, PA);




            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP7, aP8, aP1, aP8, aP7, aP9, aP10, aP6, aP10,
                                aP11, aP12, aP13, aP14, aP9, aP14, aP15, aP16, aP17, aP18, aP11 };

            e.Graphics.DrawLines(drawPen, PA2);

            //two doors
            e.Graphics.DrawLine(drawPen, 38 ,26, 38, 33);
            e.Graphics.DrawLine(drawPen, 38, 47, 38, 53);

            //text
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Teal);
            PointF PF = new PointF(33.0f, 30.0f);
            e.Graphics.DrawString("O", drawFont, drawBrush, PF);

        }




        public void carDrawRight_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

            //outer body
            Point P1 = new Point(72, 25);
            Point P2 = new Point(77, 33);
            Point P3 = new Point(77, 48);
            Point P4 = new Point(72, 55);
            Point P5 = new Point(62, 55);
            Point P6 = new Point(60, 57);
            Point P7 = new Point(55, 57);
            Point P8 = new Point(52, 55);
            Point P9 = new Point(27, 55);
            Point P10 = new Point(25, 57);
            Point P11 = new Point(20, 57);
            Point P12 = new Point(17, 55);
            Point P13 = new Point(14, 55);
            Point P14 = new Point(11, 48);
            Point P15 = new Point(11, 33);
            Point P16 = new Point(14, 25);
            Point P17 = new Point(17, 25);
            Point P18 = new Point(20, 23);
            Point P19 = new Point(25, 23);
            Point P20 = new Point(30, 25);
            Point P21 = new Point(52, 25);
            Point P22 = new Point(55, 23);
            Point P23 = new Point(60, 23);
            Point P24 = new Point(62, 25);


            //roof
            Point aP1 = new Point(70, 27);
            Point aP2 = new Point(74, 33);
            Point aP3 = new Point(74, 46);
            Point aP4 = new Point(70, 53);
            Point aP5 = new Point(20, 53);
            Point aP6 = new Point(17, 49);
            Point aP7 = new Point(17, 30);
            Point aP8 = new Point(20, 27);
            Point aP9 = new Point(25, 33);
            Point aP10 = new Point(25, 47);
            Point aP11 = new Point(50, 47);
            Point aP12 = new Point(52, 46);
            Point aP13 = new Point(52, 34);
            Point aP14 = new Point(50, 33);
            Point aP15 = new Point(60, 27);
            Point aP16 = new Point(65, 36);
            Point aP17 = new Point(65, 43);
            Point aP18 = new Point(60, 53);
            Point aP19 = new Point(25, 24);
            Point aP20 = new Point(22, 25);
            Point aP21 = new Point(52, 25);
            Point aP22 = new Point(55, 24);
            Point aP23 = new Point(60, 24);
            Point aP24 = new Point(62, 25);

            //color

            var p = sender as Panel;
            var g = e.Graphics;

            Point[] cPA1 = { P1, P2, P3, P4, P5, P8, P9, P12, P13, P14, P15, P16, P17, P20, P21, P24, P1 };
            g.FillPolygon(brBLU, cPA1);

            Point[] cPA2 = { aP1, aP2, aP3, aP4, aP18, aP17, aP16, aP15, aP1 };
            g.FillPolygon(brCRB, cPA2);

            Point[] cPA3 = { aP15, aP16, aP17, aP18, aP11, aP12, aP13, aP14, aP15 };
            g.FillPolygon(brLSG, cPA3);
            Point[] cPA4 = { aP9, aP10, aP6, aP7 };
            g.FillPolygon(brLSG, cPA4);

            Point[] cPA5 = { aP18, aP11, aP10, aP6, aP5 };
            g.FillPolygon(brDMG, cPA5);
            Point[] cPA6 = { aP15, aP14, aP9, aP7, aP8 };
            g.FillPolygon(brDMG, cPA6);


            Point[] cPA7 = { P5, P6, P7, P8 };
            g.FillPolygon(brBLK, cPA7);
            Point[] cPA8 = { P9, P10, P11, P12 };
            g.FillPolygon(brBLK, cPA8);
            Point[] cPA9 = { P17, P18, P19, P20 };
            g.FillPolygon(brBLK, cPA9);
            Point[] cPA0 = { P21, P22, P23, P24 };
            g.FillPolygon(brBLK, cPA0);


            Point[] cPAr = { aP12, aP11, aP10, aP9, aP14, aP13 };
            g.FillPolygon(brCRB, cPAr);

            //skeleton
            Point[] PA = { P1, P2, P3, P4, P5, P6, P7, P8, P5, P8, P9, P10, P11, P12,
                            P9, P12, P13, P14, P15, P16, P17, P18, P19, P20, P17, P20, P17,
                                P21, P22, P23, P24, P21, P1 };

            e.Graphics.DrawLines(drawPen, PA);




            Point[] PA2 = { aP1, aP2, aP3, aP4, aP5, aP6, aP7, aP8, aP1, aP8, aP7, aP9, aP10, aP6, aP10,
                                aP11, aP12, aP13, aP14, aP9, aP14, aP15, aP16, aP17, aP18, aP11 };

            e.Graphics.DrawLines(drawPen, PA2);

            //two doors
            e.Graphics.DrawLine(drawPen, 42, 26, 42, 33);
            e.Graphics.DrawLine(drawPen, 42, 47, 42, 53);

            //text
            Font drawFont = new Font("Arial", 13);
            SolidBrush drawBrush = new SolidBrush(Color.Teal);
            PointF PF = new PointF(29.0f, 30.0f);
            e.Graphics.DrawString("O", drawFont, drawBrush, PF);

        }
    }
}
