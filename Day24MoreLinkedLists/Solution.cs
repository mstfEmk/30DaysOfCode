using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24MoreLinkedLists
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Solution
    {
        /* Alternatif bir yaklaşım
             public static Node removeDuplicates(Node head){
               //Write your code here
                 Node curr = head;
                 while (curr != null) {
                     Node next = curr.next;
                     while (next != null && curr.data == next.data) {
                         next = next.next;
                     }
                     curr.next = next;
                     curr = next;
                 }
                 return head;
             }    

               // En kısa alternatif 
               for (var node = head; node != null && node.next != null; ) {
               if (node.data == node.next.data) node.next = node.next.next;
               else node = node.next;
           }

           return head;

       */
       // List e ihtiyaç duymadan yapılan çözümler de var. node.data == node.next.data ile karşılaştırılabilir.

        public static Node removeDuplicates(Node head)
        {

            List<int> list = new List<int>();
            Node start = head;

            list.Add(start.data);
            Node linkedList = new Node(start.data);

            while (start.next != null)
            {
                start = start.next;
                if (!list.Contains(start.data))
                {
                    list.Add(start.data);
                    head = insert(linkedList, start.data);
                }

            }

            return linkedList;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
