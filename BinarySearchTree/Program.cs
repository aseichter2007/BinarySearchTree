﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {

            //so I'm not sure if this is exatly what we were supposed to be building toward.
            //its also most of the way to a full search tree but I got a little lazy
            //So for now it is only a binary tree, but open to expansion later if I want.
            BinarySearchTree<string> test = new BinarySearchTree<string>();
            test.BinaryAdd(1,"I ");
            test.BinaryAdd(5,"think ");
            test.BinaryAdd(15,"its ");
            test.BinaryAdd(-6,"working ");
            test.BinaryAdd(-8,"!!!!!!");
            test.BinaryAdd(-5,"11111");

            BinarySearchTree<string> test2 = new BinarySearchTree<string>("Um ");
            test2.BinaryAdd(1, "I ");
            test2.BinaryAdd(10, "think ");
            test2.BinaryAdd(7, "this  ");
            test2.BinaryAdd(5, "might  ");
            test2.BinaryAdd(2, "break. ");
            test2.BinaryAdd(17, "Yay ");
            test2.BinaryAdd(105, "it ");
            test2.BinaryAdd(3, "works!");


            Console.WriteLine(tester(test));
            Console.WriteLine(tester(test2));
            Console.ReadLine();
        }
        public static string tester(BinarySearchTree<string> test)
        {
            string output = "";
            foreach (string line in test)
            {
                output += line;
            }
            return output;
        }
    }
}
