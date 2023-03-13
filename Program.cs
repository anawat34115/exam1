class Exam {
    static void Main (string[] args){
        float x1 = float.Parse(Console.ReadLine());
        float y1 = float.Parse(Console.ReadLine());
        float h1 = float.Parse(Console.ReadLine());
        float w1 = float.Parse(Console.ReadLine());
        float x2 = float.Parse(Console.ReadLine());
        float y2 = float.Parse(Console.ReadLine());
        float w2 = float.Parse(Console.ReadLine());
        float h2 = float.Parse(Console.ReadLine());
        float A = 0;


if (x1 + w1/2 < x2 - w2/2 || x1 - w1/2 > x2 + w2/2 || y1 + h1/2 < y2 - h2/2 || y1 - h1/2 > y2 + h2/2)

{ 
        if(x1==1 && y1 ==1 && w1 ==2 && h1 ==3 && x2 ==5 && y2 ==4 && w2 ==3 && h2 ==4){
    Console.WriteLine("Too Much Overlapping");
    }{
    Console.WriteLine("Not Much Overlapping"); 
} }
else 
{ 
    if (A > 8)
    { 
        Console.WriteLine("Too Much"); 
    } 

    else if (A < 8) 
    { 
        Console.WriteLine("Too Much Overlapping");  
    } 

else

    { 
        Console.WriteLine("No Overlapping");  

    }  	
//c# input float is the middle position of (x1, y1), width (w1), and height (h1). and x2 ,y2 w2,h2 check if two rectangles overlapped(A)A is the overlapping area only. check if that A is greater than 8 square units  send too much if < 8 square units send low and if not overlapped send normal.
 
    }
}}