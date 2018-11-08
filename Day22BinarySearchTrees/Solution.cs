using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22BinarySearchTrees
{
    class Node
    {

        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }

    }

    class Solution
    {
        /* Adamlar dal saymak yerine yine node sayıp ilki için 0 yerine -1 dönüyorlar.
        if(root == null)
            return -1;
        return Math.Max(1+ getHeight(root.left),1+getHeight(root.right));
        */

        static int getHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = 0;
            int rightHeight = 0;

            if (root.left == null && root.right == null)
                return 0;

            if (root.left != null)
            {
                leftHeight = getHeight(root.left);
            }
            if (root.right != null)
            {
                rightHeight = getHeight(root.right);
            }

            return Math.Max(leftHeight, rightHeight) + 1;

        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            // int[] arr = { 3, 5, 2, 1, 4, 6, 7 };
            //            { 20, 50, 35, 44, 9, 15, 62, 11, 13 };
            // { 3, 5, 2, 1, 4, 6, 7 };
            // { 20, 50, 35, 44, 9, 15, 62, 11, 13 };

            // int T = arr.Length;

            // for (int i = 0; i < T; i++)
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
                // root = insert(root, arr[i]);
            }
            root = null;
            int height = getHeight(root);
            Console.WriteLine(height);

        }
    }
}
