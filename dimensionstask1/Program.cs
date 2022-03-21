using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimensionstask1
{
    internal class Program
    {
        public class SHAPE
        {
            public virtual string whoAmI()
            {
                string temp = "I am a shape";
                return temp;
            }
        }
        public class twoDimensional : SHAPE
        {
            public double area;
            public double perimeter;

            public override string whoAmI()
            {
                return base.whoAmI();
            }
        }
        public class threeDimensional : SHAPE
        {
            public double volume;
            public double surfaceArea;

            public override string whoAmI()
            {
                return base.whoAmI();
            }
        }

        public class CIRCLE : twoDimensional
        {
            public double radius;
            public double diameter;
            public CIRCLE(double radius, double diameter)
            {
                this.radius = radius;
                this.diameter = diameter;

                

            }

            public override string whoAmI()
            {
                string temp = "I am a circle";
                return temp;
            }
        }
        public class TRIANGLE : twoDimensional
        {
            public double baseLength;
            public double height;
            public TRIANGLE(double height, double baselength,  double surface, double perimeter)
            {
                this.height = height;
                this.baseLength = baselength;
                
                this.perimeter = perimeter;
                this.area = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a triangle";
                return temp;
            }
        }
        public class SQUARE : twoDimensional
        {
            public double height;
            public double width;
            public SQUARE(double height, double width, double surface, double perimeter)
            {
                this.height = height;
                
                this.width = width;
                this.perimeter = perimeter;
                this.area = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a square";
                return temp;
            }
        }
        public class RECTANGLE : twoDimensional
        {
            public double height;
            public double width;
            public RECTANGLE(double height, double width,  double surface, double perimeter)
            {
                this.height = height;
                
                this.width = width;
                this.area = surface;
                this.perimeter = perimeter;

            }
            public override string whoAmI()
            {
                string temp = "I am a rectangle";
                return temp;
            }
        }

        public class SPHERE : threeDimensional
        {
            public double radius;
            public double diameter;

            public SPHERE(double radius, double diameter,  double surface, double volume)
            {
                this.radius = radius;
                this.diameter = diameter;
                this.volume = volume;
                this.surfaceArea = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a sphere";
                return temp;
            }
        }
        public class PYRAMID : threeDimensional
        {
            public double baseLength;
            public double height;

            public PYRAMID(double height, double baselength, double surface,double volume)
            {
                this.height = height;
                this.baselength = baselength;
                this.volume = volume;
                this.surfaceArea = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a pyramid";
                return temp;
            }
        }
        public class CYLINDER : threeDimensional
        {
            public double height;
            public double radius;
            public CYLINDER(double height, double raidus,double volume,double surface)
            {
                this.height = height;
                this.radius = radius;
                this.volume = volume;
                this.surfaceArea = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a cylinder";
                return temp;
            }
        }
        public class CUBE : threeDimensional
        {
            public double height;
            public double width;
            public double length;
            public CUBE(double height,double width,double length,double surface,double volume)
            {
                this.height = height;
                this.length = length;
                this.width = width;
                this.volume = volume;
                this.surfaceArea = surface;

            }
            public override string whoAmI()
            {
                string temp = "I am a cube";
                return temp;
            }
        }
        static void Main(string[] args)
        {

            PYRAMID pyramid1 = new PYRAMID();
            CIRCLE circle1 = new CIRCLE();
            RECTANGLE rectangle1 = new RECTANGLE();
            SQUARE square1 = new SQUARE();
            TRIANGLE traingle1 = new TRIANGLE();
            CYLINDER cylinder1 = new CYLINDER();
            CUBE cube1 = new CUBE();
            SPHERE sphere1 = new SPHERE();



        }
    }
}
