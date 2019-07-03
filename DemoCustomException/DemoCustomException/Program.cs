using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入1~4的数");

            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 1 || num > 4)
                    throw new MyException("数不在范围内");
            }
            catch (MyException me)
            {
                Console.WriteLine(me.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("我在Finally中");
            }

            Console.ReadLine();
            return;
        }
        class MyException : Exception
        {
            public MyException(string message) : base(message) { }

            public override string Message
            {
                get
                {
                    return base.Message;
                }
            }
        }
    }
}
