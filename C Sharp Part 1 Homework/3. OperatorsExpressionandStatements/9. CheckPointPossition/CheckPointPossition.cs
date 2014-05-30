using System;

class CheckPointPossition
{
    static void Main(string[] args)
    {
        /*  Write an expression that checks for given point (x, y) 
            if it is within the circle K( (1,1), 3) and out of the rectangle 
            R(top=1, left=-1, width=6, height=2).*/
        Console.WriteLine("Please enter range for x: ");
        double rangeX = double.Parse(Console.ReadLine());  
        Console.WriteLine("Please enter range for y: ");
        double rangeY = double.Parse(Console.ReadLine());
        bool withinCircle = false;
        bool withinRectangle = false;
        if (Math.Sqrt(((rangeX - 1) * (rangeX - 1)) + ((rangeY - 1) * (rangeY - 1))) <= 3)  //must substract 1 from x and y, because center of K is (1,1)
        {
            withinCircle = true;
            //Console.WriteLine("Your point is within circle[1.1,3]");
        }
        if ( (rangeX>=-1) && (rangeX<=5) && (rangeY>=-1) && (rangeY<=1))
        {
            withinRectangle = true;
        }

        //There are 4 possible positions of the point
        if (withinRectangle==true && withinCircle==true)
        {
            Console.WriteLine("Your point is within the rectangle and within the circle!");
        }
        else if (withinRectangle == true && withinCircle == false)
        {
            Console.WriteLine("Your point is within the rectangle and out of the circle!");
        }
        else if (withinRectangle == false && withinCircle == true)
        {
            Console.WriteLine("Your point is within the circle and out of the rectangle!");
        }
        else 
        {
            Console.WriteLine("Your point is out of the rectangle and out of the circle!");
        }
    }
}

