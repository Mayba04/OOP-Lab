using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2
{
    public class QuadraticEquation
    {
        private float a;
        private float b;
        private float c;

        public QuadraticEquation(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public float HasRealSolutions()
        {
            float discriminant = b * b - 4 * a * c;
            return discriminant >= 0 ? discriminant : float.NaN;
        }

      
    }
}
