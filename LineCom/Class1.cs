using System;
    public class length
    {
        public void findlen()
        {

            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double Length = ((Math.Pow(x2, 2)) - (Math.Pow(x1, 2))) + ((Math.Pow(y2, 2)) - (Math.Pow(y1, 2)));
            Console.WriteLine(Math.Sqrt(Length));

        }
    }
class Length
{
    static void Main(string[] args)
    {
        Console.WriteLine("Length of one line");
        length find1= new length();
        find1.findlen();
        Console.WriteLine("Length of Second line");
        length find2 = new length();
        find2.findlen();


    }
}
