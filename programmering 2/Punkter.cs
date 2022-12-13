using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programmering2
{
    public class Punkter
    {
        private int xkoordinat;
        private int ykoordinat;

        public int getX() { return this.xkoordinat; }
        public int getY() { return this.ykoordinat; }
        public void setX(int x) { this.xkoordinat = x; }
        public void setY(int y) { this.ykoordinat = y; }

        public void increaseX()
        {
            this.xkoordinat += 1;
        }

    }
}
