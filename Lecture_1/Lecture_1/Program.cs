﻿using System;


namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            //Forth();
            //Fifth();
            //Sixth();
            //seventh();
            //eighth();
            ninth();

            void ninth()
            {
                double pie = 3.141592;

                Console.WriteLine("정수만 출력: {0:F0}", pie);
                Console.WriteLine("소수점 한자리 출력: {0:F1}", pie);
                Console.WriteLine("소수점 두자리 출력: {0:F2}", pie);
                Console.WriteLine("소수점 세자리 출력: {0:F3}", pie);

                string str1 = "안녕하세여";
                string str2 = "C:\\Study";
                string str3 = @"C:\Stydy";

                Console.WriteLine(str1);
                Console.WriteLine("\"" + str1 + "\"");
                Console.WriteLine("경로는 " + str2 + "입니다");
                Console.WriteLine("경로는 " + str3 + "입니다");
            }

            void eighth()
            {
                char a1 = 'a';
                char a2 = 'A';

                Console.WriteLine("a1의 값: " + a1);
                Console.WriteLine("a2의 값: " + a2);

                ushort change_a1, change_a2;
                change_a1 = a1;
                change_a2 = a2;
                Console.WriteLine("change_a1의 값: " + change_a1);
                Console.WriteLine("change_a2의 값: " + change_a2);

                byte ch_byte_a1, ch_byte_a2;
                ch_byte_a1 = (byte)a1;
                ch_byte_a2 = Convert.ToByte(a2);
                Console.WriteLine("ch_byte_a1의 값: " + ch_byte_a1);
                Console.WriteLine("ch_byte_a2의 값: " + ch_byte_a2);
            }

            void seventh()
            {
                /*
                관계 연산자 : <, >, ==, !=, <=, >=
                논리 연산자 : &&, ||, !                 
                 */

                int a = 3;
                if (a == 1)
                {
                    Console.WriteLine("1과 같음");
                }
                else if(a >= 1)
                {
                    Console.WriteLine("1보다 크거나 같음");
                }
                else if(a < 1)
                {
                    Console.WriteLine("1보다 작음");
                }
                else
                {
                    Console.WriteLine("해당없음");
                }

                int b, c;
                b = 100;
                c = 200;

                if(b == 100 && c == 300)
                {
                    Console.WriteLine("1");
                }
                else if(b == 100 || c == 300)
                {
                    Console.WriteLine("2");
                }
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




