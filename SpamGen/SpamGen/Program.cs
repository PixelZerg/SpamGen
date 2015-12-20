using System;

namespace SpamGen
{
    class Program
    {
        public static Random r = new Random(Environment.TickCount);
        public static bool done = false;
        public static string spam = "";
        static void Main(string[] args)
        {
            Keyboard k = new Keyboard();
            new System.Threading.Thread(() => doorealistic(k,true)).Start();
            Console.ReadKey();
            done = true;
        }
        static void doo(Keyboard k, bool delay = false, bool doshift=false)
        {
            int curkey = r.Next(1, 49);
            while (!done)
            {
                if (curkey > 48)
                {
                    curkey = 0;
                }
                spam += k.GetKey(curkey);
                Console.Write(k.GetKey(curkey));
                if (r.NextDouble() > 0.9)
                {
                    spam += " ";
                    Console.Write(" ");
                }
                int foo = r.Next(0, 5);
                if (r.NextDouble() < 0.7)
                {
                    foo *= 1; //go backwards
                }
                if (48 - foo > 14)//avoid out of range
                {
                    if (r.NextDouble() < 0.2)
                    {
                        foo += r.Next(10, 14);// go down a row
                    }
                }
                if (r.NextDouble() > 0.99)
                {
                    spam += Environment.NewLine;//new line yoo!
                    Console.WriteLine();
                }
                if (doshift && r.NextDouble() < 0.2)
                {
                    k.shift = !k.shift;
                }
                if (foo < 3)
                {
                    curkey++;
                    if(!Char.IsLetter(k.GetKey(curkey))|| Char.IsNumber(k.GetKey(curkey)) && k.shift==true)
                    {
                        if (r.NextDouble() < 0.3)
                        {
                            curkey += 3;
                        }
                    }
                }
                else if(r.NextDouble() < 0.8)//sometimes repeat the char
                {
                    curkey += foo;
                }
                if (delay)
                {
                    System.Threading.Thread.Sleep(r.Next(0, 10));
                }
            }
        }
        static void doorealistic(Keyboard k, bool delay = false, bool doshift = false)
        {
            bool back = false;
            int curkey = r.Next(1, 49);
            while (!done)
            {
                if (curkey > 48|| curkey < 14)
                {
                    curkey = 15;
                }
                spam += k.GetKey(curkey);
                Console.Write(k.GetKey(curkey));
                if (r.NextDouble() > 0.9)
                {
                    spam += " ";
                    Console.Write(" ");
                }
                int foo = r.Next(0, 3);
                if (r.NextDouble() > 0.8)
                {
                    back = !back; //go backwards
                }
                if (48 - foo > 14)//avoid out of range
                {
                }
                if (r.NextDouble() > 0.99)
                {
                    spam += Environment.NewLine;//new line yoo!
                    Console.WriteLine();
                }
                if (doshift && r.NextDouble() < 0.2)
                {
                    k.shift = !k.shift;
                }
                if (foo <= 2)
                {
                    if (!back)
                        curkey++;
                    else curkey--;
                    if (!Char.IsLetter(k.GetKey(curkey)) || Char.IsNumber(k.GetKey(curkey)) && k.shift == true)
                    {
                        if (r.NextDouble() < 0.3)
                        {
                            if (!back)
                                curkey += 3;
                            else curkey -= 3;
                        }
                    }
                }
                else if (r.NextDouble() < 0.8)//sometimes repeat the char
                {
                    if (!back)
                        curkey += foo;
                    else curkey -= foo;
                }
                if (delay)
                {
                    System.Threading.Thread.Sleep(r.Next(0, 10));
                }
            }
        }
    }
}
