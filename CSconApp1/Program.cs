using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSconApp1
{
    internal class Program
    {
        static void PrintArray()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            foreach (int x in a)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        //객체화 되기 전에 이미 메모리 차지하고 있음. 
        static void Main(string[] args)//Program클래스에서 인스턴스 생성 전에 main이 호출이 된다 
        {
            //int max = int.MaxValue;
            //int min = int.MinValue; 

            Console.WriteLine($"int type 크기 {sizeof(int)} 최대값: {int.MaxValue} 최소값: {int.MinValue}\n");
            Console.WriteLine("int type 크기" +sizeof(int)+" 최대값:"+int.MaxValue+" 최소값:"+ int.MinValue+"\n");
            Console.WriteLine("int type 크기 {0} 최대값: {1} 최소값: {2}\n", sizeof(int), int.MaxValue, int.MinValue);
            Console.WriteLine($"char type 크기 {sizeof(char)} 최대값: {char.MaxValue} 최소값: {char.MinValue}\n");
            Console.WriteLine($"long type 크기 {sizeof(long)} 최대값: {long.MaxValue} 최소값: {long.MinValue}\n");
            Console.WriteLine($"float type 크기 {sizeof(float)} 최대값: {float.MaxValue} 최소값: {float.MinValue}\n");
            Console.WriteLine($"double type 크기 {sizeof(double)} 최대값: {double.MaxValue} 최소값: {double.MinValue}\n");

            char a = 'A';
            Console.WriteLine("char a = " +a);//A
            Console.WriteLine("char a+1 = " + a+1);//A1
            Console.WriteLine("char a+1 = " + (a + 1));//66

            Console.WriteLine("char a+2 = " + a + 2);//A2
            Console.WriteLine("char a+2 = " + (a + 2));//67
            Console.WriteLine(32 + 32);//64
            Console.WriteLine((32 + 32));//64

            PrintArray();

            Test test  = new Test();
            test.Main();

        }
    }

    class Test {
        void func1()             // Vehicle method 
        {
            Console.WriteLine("func1: aaa");
        }

        void func2()             // Vehicle method 
        {
            Console.WriteLine("func2: bbb");
        }

        void func3() {
            //var a = "A"; //한번 char 변수로 선언되면, 
            //a = 10; // error int 값을 저장할 수 없다 
            var a = 20;
            Console.WriteLine($"func3: var a = {a}");//20
            a = 10;
            Console.WriteLine($"func3: var a = {a}");//10
            Object o = a;
            Console.WriteLine($"func3: Object o = {o}");//20

            //처리되지 않은 예외: System.InvalidCastException: 'System.Int32' 형식 개체를 'System.String' 형식으로 캐스팅할 수 없습니 다.
            //string s = (string)o;//에러남 
            o = "I AM STRING";
            Console.WriteLine($"func3: Object o = {o}");//I AM STRING
            //string s = o; data type 불일치 에러남 
            string s = (string)o;//type casting 진행 
            Console.WriteLine($"func3: string s = {o}");//I AM STRING

        }

        void func4() {
            //int[] arr = new int[100];//100 element 
            int[] arr = { 1, 2, 3, 4, 5 };
       
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }

            char[] ch_arr = {'안','녕','하','세','요','?'};
            for (int i = 0; i < ch_arr.Length; i++)
            {
                Console.WriteLine(ch_arr[i]);
            }

            string s = new string(ch_arr);
            Console.WriteLine(s);
            s = new string(ch_arr, 1, 2);
            Console.WriteLine(s);   
            
        }

        public void Main() {//대부분 무한 루프 안에서 이벤트 처리를 하는 구조
            func1();
            func2();
            func3();
            func4();
        }
    }
}
