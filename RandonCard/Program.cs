using System;

namespace RandonCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(0,100);

            string s = "";

            if(r<10)//r>=0 && r<10
            {
                s = "关羽";
            }
            else if(r<30)//r>=10 && r<30
            {
                s = "张飞";
            }
            else if(r<60)//r>=10 && r<60
            {
                s = "赵云";
            }
            else if(r<100)//r>=60 && r<100
            {
                s = "黄忠";
            }
            Console.WriteLine("您抽到了卡牌 " + s +"(" + r + ")");
            Console.ReadKey();
        }
    }
}
