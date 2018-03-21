using System;

namespace prg2._2_oop
{
    public static class Swapper<T>
    {
        public static void Swap(Node<T> n1, Node<T> n2)
        {
            Node<T> tempn1 = new Node<T>(n1.data);
            Node<T> tempn2 = new Node<T>(n2.data);
            tempn1 = n1;
            tempn2 = n2;

            if(n1 == n1.root)
            {
                Node<T> iterator = n1;
                while(iterator != null)
                {
                    iterator.root = n2;
                    //iterator++;
                }
            }
            else if (n2 == n2.root)
            {
                //Node iterator = new Node();
                //iterator.root = n1;

            }
        }
    }
}