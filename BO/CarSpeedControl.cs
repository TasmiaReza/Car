using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace BO
{
    public class CarSpeedControl
    {
        DataAccess b = new DataAccess();

        public void saveSpeed(int speed)
        {
            int temp = speed;
             b.saveSpeed(temp);
        }
        public int getSpeed()
        {
            return b.getSpeed();
        }


        Rectangle rect1 = new Rectangle(-100, -100, 560, 190);
        Rectangle rect2 = new Rectangle(-100, 410, 150, 450);
        Rectangle rect3 = new Rectangle(1440, 410, 50, 350);
        Rectangle rect4 = new Rectangle(0, 910, 770, 50);

        Rectangle rect61 = new Rectangle(260, 430, 170, -100);
        Rectangle rect62 = new Rectangle(260, 550, 250, -180);

        Point loopCircle = new Point(575, 125);

        public int detCollison(int x1, int y1, int x2, int y2)
        {
            Rectangle carPanel = new Rectangle(x1, y1, x2, y2);
            Point carMiddle = new Point(x1 + 80, x2 + 80);

            double dx = (loopCircle.X - x1) * (loopCircle.X - x1);
            double dy = (loopCircle.Y - y1) * (loopCircle.Y - y1);
            double dis = Math.Pow((dx + dy), .5);



            if (dis <= 70)
            {
                return 1;
            }
            if (carPanel.IntersectsWith(rect1))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect2))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect3))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect4))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect61))
            {
                return 1;
            }
            else if (carPanel.IntersectsWith(rect62))
            {
                return 1;
            }
            return 0;
        }
    }
}
