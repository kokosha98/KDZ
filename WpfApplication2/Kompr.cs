using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Kompr
    {
        string model;
        double pressure;
        double capacity;
        double power;
        double length;
        double width;
        double height;

        public Kompr(string model, double pressure, double capacity, double power, double length, double width, double height)
        {
            this.model = model;
            this.pressure = pressure;
            this.capacity = capacity;
            this.power = power;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public double Pressure
        {
            get
            {
                return pressure;
            }
            set
            {
                pressure = value;
            }
        }

        public double Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }

        public double Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
}
