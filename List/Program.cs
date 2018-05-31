using System;
using System.Collections.Generic;

namespace List
{
    class MyList
    {
        //内部数据
        int[] mem;
        int len;

        public MyList()
        {
            mem = new int[8];
            len = 0;
        }
        public void Add(int n)
        {
            if(len >= mem.Length)
            {
                int[] mem_new = new int[mem.Length * 2];
                mem_new.CopyTo(mem_new, 0);
                mem = mem_new;
            }

            mem[len] = n; //len不能-1
            len++;
        }
        public void RemoveAt(int index)
        {
            if (len < 0 || len<= index)
            {
                Console.WriteLine("RemoveAt 下标越界{0} {1}", len, index);
                return;
            }
            for (int i = index+1; i<len; i++)
            {
                mem[i - 1] = mem[i];
            }
            len--;
        }

        public int Count()
        {
            return len;
        }

        public int Get(int i)
        {
            return mem[i];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();  //自带List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.RemoveAt(1);

            for (int i=0;i<list.Count();i++)
            {
                Console.WriteLine(list.Get(i));
            }
            Console.ReadKey();
        }
    }
}
