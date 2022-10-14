using System;


namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forth();
            //Fifth();
            //Sixth();
            seventh();

            void seventh()
            {

            }

            void Sixth()
            {
                int a = 1;
                int b = 2;
                int c;

                c = ++a;
                Console.WriteLine("선행연산자 a의 값{0} c의 값{1}", a, c); //2,2

                a = 1;
                c = a++;
                Console.WriteLine("후행연산자 a의 값{0} c의 값{1}", a, c); //2,1

                Console.WriteLine("나머지 값 {0}", 5 % 2); //1
            }

            void Fifth()
            {
                //object aa = 11;
                ////aa = "a";
                //int a = Convert.ToInt32(aa);
                //object aaa = "a";
                //Console.WriteLine("a값은: {0}", a);

                //var bb = 22;
                ////bb = "b";
                //int b = bb;
                //var bbb = "b";
                //Console.WriteLine("b의 값은: {0}", b);

                //dynamic cc = 33;
                ////cc = "한글";
                //int c = cc;
                //Console.WriteLine("c의 값은: {0}", c);
                //Console.ReadLine();

                int a = 10;
                int b = 5;
                int c = a + b;
                Console.WriteLine("a+b={0}", c);
                Console.WriteLine("a+b={0}", a + b);

                Console.WriteLine("a-b={0}", a - b);
                Console.WriteLine("a*b={0}", a * b);
                Console.WriteLine("a/b={0}", a / b);

                Console.ReadLine();

                int d;
                d = 5 / 2; //2
                Console.WriteLine("d의 값:{0}", d);

                double e;
                e = 5 / 2; //2
                Console.WriteLine("d의 값:{0}", e);

                double f;
                f = 5.0 / 2; //2.5
                Console.WriteLine("d의 값:{0}", f);

                float g;
                g = 5.5f; //5.5
                //g = 5f / 2f; //2.5
                Console.WriteLine("g의 값:{0}", g);

                Console.ReadLine();





            }

            void Forth()
            {
                string name = "박기태";
                name = "1";
                name = "0.5";
                char letter = 'A';
                int price = 100;
                double b = 0.05;
                decimal sale = 1;
                decimal sale2 = Convert.ToDecimal(0.25);
                decimal sale_price;
                sale_price = price - (price * sale2);
                Console.WriteLine("할인 가격은 {0}", sale_price);
                Console.WriteLine(name);
                Console.ReadLine();
                const string str = "박기태";
            }
        }
    }
}




