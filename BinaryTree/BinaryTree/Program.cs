using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string buffer = "";
            //right=r
            //left=l
            /////////////////////// BinTree ///////////////////////
            Node<int> rootnode = new Node<int>(1);
            Node<int> lchild = new Node<int>(2);
            Node<int> rchild = new Node<int>(3);
            Node<int> lchild_l = new Node<int>(4);
            Node<int> lchild_r = new Node<int>(5);
            Node<int> rchild_l = new Node<int>(6);
            Node<int> rchild_r = new Node<int>(7);
            Node<int> lchild_r_r = new Node<int>(8);

            rootnode.Left = lchild; //2
            rootnode.Right = rchild; //3
            rootnode.Left.Left = lchild_l; //4
            rootnode.Left.Right = lchild_r; //5
            rootnode.Right.Left = rchild_l; //6
            rootnode.Right.Right = rchild_r; //7
            rootnode.Left.Right.Right = lchild_r_r; //8

            //creates a BinTree with root = rootnode
            BinTree<int> mytree = new BinTree<int>(rootnode);

            //InOrder
            buffer = "";
            mytree.InOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("in-order visit of BinTree " + buffer);
            Console.ReadLine();
            //PreOrder
            buffer = "";
            mytree.PreOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("pre-order visit of BinTree " + buffer);
            Console.ReadLine();
            //PostOrder
            buffer = "";
            mytree.PostOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("post-order visit of BinTree " + buffer);
            Console.ReadLine();


            /////////////////////// BSTree //////////////////////s

            //creates a BinTree that only contains strings
            BSTree<string> bstree = new BSTree<string>();

            //inserting/creating the strings/nodes
            bstree.InsertItem("e");
            bstree.InsertItem("b");
            bstree.InsertItem("g");
            bstree.InsertItem("a");
            bstree.InsertItem("c");
            bstree.InsertItem("f");
            bstree.InsertItem("h");
            bstree.InsertItem("d");

            //InOrder
            buffer = "";
            bstree.InOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("in-order visit of BinSearchTree " + buffer);
            Console.ReadLine();
            //PreOrder
            buffer = "";
            bstree.PreOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("pre-order visit of BinSearchTree " + buffer);
            Console.ReadLine();
            //PostOrder
            buffer = "";
            bstree.PostOrder(ref buffer); ;
            //displays the content of the tree
            Console.WriteLine("post-order visit of BinSearchTree " + buffer);
            Console.ReadLine();


            //displays the height of the tree
            Console.WriteLine("Height of BinSearchTree = {0} ", bstree.Height());
            Console.ReadLine();

            //displays the number of nodes in the tree
            Console.WriteLine("Number of nodes in the BinSearchTree = {0} ", bstree.Count());
            Console.ReadLine();

            //displays whether or not the tree contains "e"
            Console.WriteLine("Is 'e' BinSearchTree = {0} ", bstree.Contains("e"));
            Console.ReadLine();

            //displays whether or not the tree contains "z"
            Console.WriteLine("Is 'z' BinSearchTree = {0} ", bstree.Contains("z"));
            Console.ReadLine();

            //displays whether or not the tree contains "5"
            Console.WriteLine("Is '5' BinSearchTree = {0} ", bstree.Contains("5"));
            Console.ReadLine();
        }
    }
}
