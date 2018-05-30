using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. unit tests done
 * 
 * 2. To add new figure just add new child class and
 * implement constructor, GetArea() and Exist() functions
 * 
 * 3. uncnown figure area calculation example code:
 *  
 *  //for example we have figure
 *  Triangle triangle = new Triangle(20, 30, 40);
 *  ...
 *  //and Unknown figure
 *  BaseFigure figure;
 *  ...
 *  //assign any figure 
 *  figure = triangle;
 *  //some attions
 *  ...
 *  //here we do not know what kind of figure is instance "figure"
 *  but we can calculate it area
 *  figure.GetArea()  
 *  
 *  4. right checking done
 */

namespace MindboxFigures
{
    public abstract class BaseFigure
    {
        //getting figure area
        public abstract double GetArea();

        //function checking can figure exist or no
        public abstract Boolean Exist();
    }

    /* 
     * To add new figure just add new child class and
     * implement constructor, GetArea() and Exist() functions
    */

    public class Triangle : BaseFigure
    {
        //triangle sides
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        override public Boolean Exist()
        {
            return ((a > 0) && (b > 0) && (c > 0) &&
                    (a + b > c) &&
                    (a + c > b) &&
                    (b + c > a));
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }

        override public double GetArea()
        {
            if (!Exist())
                return -1;
            double Semiperimeter = GetPerimeter() / 2;
            //calculate by Heron's Formula
            return Math.Sqrt(Semiperimeter * (Semiperimeter - a) * (Semiperimeter - b) * (Semiperimeter - c));
        }

        public Boolean IsRight()
        {
            if (!Exist())
                return false;

            double s1 = Math.Max(Math.Max(a, b), Math.Max(a, c));
            double s2;
            double s3;

            if (s1 == a)
            {
                s2 = b;
                s3 = c;
            }
            else if (s1 == b)
            {
                s2 = a;
                s3 = c;
            }
            else
            {
                s2 = a;
                s3 = b;
            }
            return (Math.Pow(s2, 2) + Math.Pow(s3, 2) == Math.Pow(s1, 2));
        }
    }

    public class Circle : BaseFigure
    {
        //circle radius
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override bool Exist()
        {
            return (r >= 0);
        }

        override public double GetArea()
        {
            if (!Exist())
                return -1;
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
