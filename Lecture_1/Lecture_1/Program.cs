using System;

namespace study
{
    class Program
    {

        static string name = "bbb";

        enum Enemy { Attack, Dead, Sleep, Run };

        struct person
        {
            public string name;
            public int age;
            public int empld;

            public person(string name, int age, int empld)
            {
                this.name = name;
                this.age = age;
                this.empld = empld;
            }
        }

        static void Main(string[] args)
        {
            #region 1-9강
            //Forth();
            //Fifth();
            //Sixth();
            //seventh();
            //eighth();
            //ninth();

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
                else if (a >= 1)
                {
                    Console.WriteLine("1보다 크거나 같음");
                }
                else if (a < 1)
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

                if (b == 100 && c == 300)
                {
                    Console.WriteLine("1");
                }
                else if (b == 100 || c == 300)
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
            #endregion

            #region 10강 : 메소드, For문

            //string ten_name = tenth_str();
            //Console.WriteLine(ten_name);

            ////int ten_age = tenth_int();
            ////Console.WriteLine(ten_age);

            ////tenth_param("철수", 10);
            //string ten_param = tenth_param2("영희", 20);
            //Console.WriteLine(ten_param);

            //tenth_array("영희", "철수", "민수", "호철", "기양", "영철");




            string tenth_str()
            {
                return "park";
            }

            int tenth_int()
            {
                Console.WriteLine("나이를 입력하세요.");
                int age = Convert.ToInt32(Console.ReadLine());
                return age;
            }

            void tenth_param(string name, int age)
            {
                Console.WriteLine("이름은 " + name);
                Console.WriteLine("나이는 " + age);
            }

            string tenth_param2(string name, int age)
            {
                return "입력한 이름은 " + name + " 나이는 " + age + "입니다";
            }

            void tenth_array(params string[] names)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
            #endregion

            #region 11강 : 전역변수 지역변수 열거형 Enum
            //eleventh("CCC");

            void eleventh(string name)
            {
                //string name = "AAA";
                Console.WriteLine(name);

                Enemy _status;
                _status = Enemy.Sleep;
                Console.WriteLine(_status);

                _status = (Enemy)Enum.Parse(typeof(Enemy), "Run");
                Console.WriteLine("변경된 상태는 : " + _status);

                _status = Enemy.Attack;
                Console.WriteLine("두번째 상태는 : " + _status);
            }


            #endregion

            #region 12강 : 구조체 struct
            //twelfth();

            void twelfth()
            {
                person _person = new person("철수", 25, 20210401);
                Console.WriteLine("이름 : {0} 나이 : {1}    사번 : {2}", _person.name, _person.age, _person.empld);
            }


            #endregion

            #region 13강 : 스위치문

            //thirteenth();

            void thirteenth()
            {
                //int number;
                //number = Convert.ToInt32(Console.ReadLine());

                //switch (number)
                //{
                //    case 1: Console.WriteLine("1번이 입력되었습니다."); break;
                //    case 2: Console.WriteLine("2번이 입력되었습니다."); break;
                //    case 3: Console.WriteLine("3번이 입력되었습니다."); break;
                //    default: Console.WriteLine("알수없습니다."); break;

                //}


                Enemy enemy = new Enemy();
                enemy = Enemy.Run;
                switch (enemy)
                {
                    case Enemy.Run: Console.WriteLine("적이 도망갔습니다."); break;
                    case Enemy.Attack: Console.WriteLine("적이 공격했습니다."); break;
                    case Enemy.Dead: Console.WriteLine("적이 죽었습니다."); break;
                    default: Console.WriteLine("입력 오류"); break;
                }

                
            }
            #endregion

            #region 14강 : While, do While문

            //fourteenth();

            void fourteenth()
            {
                int i = 0;

                //while (true)
                //{
                //    Console.WriteLine(i++);
                //}

                while (i < 10)
                {
                    Console.WriteLine(i++);
                    i++;
                }

                Console.WriteLine("반복문종료: " + i);

                do
                {
                    Console.WriteLine("do: " + i);
                    i += 1;
                }
                while (i > 10 && i < 20);
            }

            #endregion

            #region 15강 : foreach문

            //fifteenth();

            void fifteenth()
            {
                string[] str = { "사과", "배", "오렌지", "포도", "딸기" };
                foreach(string a in str)
                {
                    Console.WriteLine("과일의 종류는 : " + a);
                }
            }

            #endregion

            #region 16강 : class
            
            sixteenth();

            void sixteenth()
            {
                Ch_16 staff1 = new Ch_16();
                staff1.name = "봄버맨";
                Console.WriteLine(staff1.name);

                Ch_16 staff2 = new Ch_16();
                staff2.name = "배트맨";
                staff2.age = 10;
                Console.WriteLine("이름은:" + staff2.name + " 나이는:" + staff2.age);

            }

            #endregion
        }
    }

}




