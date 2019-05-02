//Omar Munoz-Rocha ASSIGNMENT 5 BUS ADM 432
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public abstract class Circular_Shape_3D //base class
    {
        public double radius; //to be used in our sub classes

        //constructor with double radius
        public Circular_Shape_3D(double radius)
        {
            this.radius = radius;
        }
        //set/get methods
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public abstract double computeSurfaceArea();
        public abstract double computeVolume();

        public override String ToString()
        {
            return "Radius: " + getRadius() + ", Surface Area: " + computeSurfaceArea() + "," + " Volume: " + computeVolume();
        }

    }
    //cylinder class which inherits from base/super class
    class Cylinder : Circular_Shape_3D
    {
        private double height;

        public Cylinder(double radius, double height) : base(radius) //radius inherited from Circular_Shape_3D
        {
            this.height = height;
        }
        //set/get for height
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }

        //computation method of our surface area
        public override double computeSurfaceArea()
        {
            double area = (2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius); //2(pi)rh + 2(pi)r^2
            area = Math.Round(area, 2);
            return area;
        }

        //computation method of our volume
        public override double computeVolume()
        {
            double volume = Math.PI * radius * radius * height; //(pi)r^2h.
            volume = Math.Round(volume, 2);
            return volume;
        }
        public override String ToString()
        {
            return "Radius: " + getRadius() + ", Height:" + getHeight() +", Surface Area: " + computeSurfaceArea() + "," +" Volume: " + computeVolume();
        }
    }

    //sphere class which inherits from base/super class
    class Sphere : Circular_Shape_3D
    {
        public Sphere(double radius) : base(radius) { } //constructor which inherits radius from base class

        public override double computeSurfaceArea()
        {
            double area = 4 * Math.PI * radius * radius; //4(pi)r^2
            area = Math.Round(area, 2);
            return area;
        }

        public override double computeVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius; //(4/3)(pi)r^3
            volume = Math.Round(volume, 2);
            return volume;
        }

        public override String ToString()
        {
            return "Radius: " + getRadius() + ", Surface Area: " + computeSurfaceArea() + "," + " Volume: " + computeVolume();
        }
    }
    //Testing class
    class testShapes
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder(5, 10); //create obj cylinder and set radius to 5, height of 10
            Sphere sphere = new Sphere(7); //create obj sphere and set radius to 7

            //Display to user via calling methods from locally created objects
            Console.WriteLine(cylinder.computeVolume()); //call computevolume method for cylinder
            Console.WriteLine(cylinder.computeSurfaceArea()); //call computeSurfaceArea method for cylinder
            Console.WriteLine(cylinder); //call ToString method for cylinder

            Console.WriteLine();
            Console.WriteLine(sphere.computeSurfaceArea()); //call computeSurfaceArea method for sphere
            Console.WriteLine(sphere.computeVolume());//call computevolume method for sphere
            Console.WriteLine(sphere);//call ToString method for sphere


            Console.WriteLine();

            //create array  circularShape from type Circular_Shape_3D
            Circular_Shape_3D[] circularShape = new Circular_Shape_3D[2];
            //assign cylinder and sphere to array
            circularShape[0] = cylinder;
            circularShape[1] = sphere;


            //Display to user via calling methods from locally created arrays
            Console.WriteLine(circularShape[0].computeSurfaceArea()); //call computeVolume of Cylinder
            Console.WriteLine(circularShape[0].computeVolume()); //call computeVolume of Cylinder
            Console.WriteLine(circularShape[0]);  //call To String method of cylinder

            Console.WriteLine();
            Console.WriteLine(circularShape[1].computeSurfaceArea()); //call computeSurfaceArea of Sphere
            Console.WriteLine(circularShape[1].computeVolume()); //call computeVolume of Sphere
            Console.WriteLine(circularShape[1]); //call To String method of sphere

            Console.WriteLine("Using the method of having local variables call on the computations and their classes gave us the same results when using the array elements to call upon the methods");

            Console.ReadLine();
        }
    }
}

