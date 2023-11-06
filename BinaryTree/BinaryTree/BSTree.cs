using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height()
        //Return the max level of the tree
        {
            return Hheight(root); 
        }

        private int Hheight(Node<T> tree)
        //Return the height of a subtree rooted at tree
        {
            if (tree == null) //base case: empty tree has height 0
                return 0;
            else //recursive case: height is 1 + max of left and right subtree heights
                return 1 + Math.Max(Hheight(tree.Left), Hheight(tree.Right));
        }

        public int Count()
        //Return the number of nodes in the tree
        {
            return Ccount(root);
        }

        private int Ccount(Node<T> tree)
        //Return the number of nodes in the tree
        {
            if (tree == null) //base case: node = null
                return 0;
            else //recursive case: count is 1 + left and right nodes
                return 1 + Ccount(tree.Left) + Ccount(tree.Right);
        }

        public Boolean Contains(T item)
        //Return true if the item is contained in the BSTree
        {
            return Ccontains(item, root);
        }

        private Boolean Ccontains(T item, Node<T> tree)
        //Return true if the item is contained in a subtree rooted at tree, false otherwise.
        {
            if (tree == null) //base case: empty tree does not contain the item
                return false;
            else if (item.CompareTo(tree.Data) == 0) //base case: item matches the current node's value
                return true;
            else if (item.CompareTo(tree.Data) < 0) //recursive case: item is smaller than the current node's value, search in the left subtree
                return Ccontains(item, tree.Left);
            else //recursive case: item is larger than the current node's value, search in the right subtree
                return Ccontains(item, tree.Right);
        }



    }
}
