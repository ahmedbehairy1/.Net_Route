using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02
{
    internal class Rectangle
    {
        //read only property example Q2
        public double lenght { get; set; }
        public double Width {  get; set; }
        public double area
        { 
            get { return lenght * Width; }
        }
    }
}
