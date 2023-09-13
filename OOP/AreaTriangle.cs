using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class AreaTriangle
    {

        private float A;
        private float B;
        private float C;
        private float P;
        private float S;

        public AreaTriangle(float a, float b, float c)
        {
            this.A = a; 
            this.B = b; 
            this.C = c;
            P = (A + B + C) / 2;
            this.S = 0;
        }

        public float Calcilation()
        {
            double sqr = P * (P - A) * (P - B) * (P - C);
            S = (float)Math.Sqrt(sqr);
            return S;
        }
    }
}
