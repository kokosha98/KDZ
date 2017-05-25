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
        uint pressure;
        uint capacity;
        uint power;
        uint length;
        uint width;
        uint height;

        public Kompr(string model, uint pressure, uint capacity, uint power, uint length, uint width, uint height)
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

        public uint Pressure
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

        public uint Capacity
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

        public uint Power
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

        public uint Length
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

        public uint Width
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

        public uint Height
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
