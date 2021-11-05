using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishlist = new List<string>();

            Console.WriteLine(mywishlist.Count);

            mywishlist.Add("coffe machine");
            mywishlist.Add("New pair of socks");
            mywishlist.Add("Box of chocolates");
            mywishlist.Add("New pillow");

            Console.WriteLine(mywishlist.Count);

            foreach(string wish in mywishlist)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
