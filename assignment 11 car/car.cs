using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_11_car
{
    class car
    {
        public string model;
        public string color;
        public int year;

        public engine engine;
        public passenger driver;
        public passenger shotgun;
        public passenger backseat;

        public car(string color, string model, int year, int housepower)
        {
            this.color = color;
            this.model = model;
            this.year = year;

            this.engine = new engine(housepower);
        }
    }
}
