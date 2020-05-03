using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T>:IEnumerable where T: IComparable
    {
        Node<T> start;
        List<int> keys;
        public BinarySearchTree(int key,T data)
        {
            start = new Node<T>(key, data);
            keys = new List<int>() { key };
        }
        public BinarySearchTree(T data)
        {
            start = new Node<T>(0,data);
            keys = new List<int>() { 0 };
        }
        public BinarySearchTree()
        {
            keys = new List<int>();
        }
        public void BinaryAdd(int key,T dataIn)
        {
            
                if (start == null)
                {
                    start = new Node<T>(key, dataIn);
                     keys.Add(key);
                    return;
                }
            if (!keys.Contains(key))
            {
                keys.Add(key);

                Node<T> data = new Node<T>(key, dataIn);
                Node<T> temp = start;
                Node<T> temp2 = start;
                while (temp != null)
                {
                    temp2 = temp;
                    temp = CompareGetNode(data.key, temp);
                }
                temp = data;
                if (temp.key>temp2.key)
                {
                    temp2.links[1] = temp;
                }
                else
                {
                    temp2.links[0] = temp;
                }
            }
            else
            {
                throw new Exception("duplicate key"); 
                //the system can store duplicate data, but how to access behind duplicate keys bamboozled me.
            }
        }
        public Node<T> CompareGetNode(int key, Node<T> temp)
        {
            if (key>temp.key)
            {
                return temp.links[1];
            }
            else
            {
                return temp.links[0];
            }
        }        
        public T BinarySearch(int key)
        {
            T output=default;
            Node<T> temp = start;

            while (temp != null &&temp.key != key)
            {
                temp = CompareGetNode(key, temp);
            }
            if (temp.data==null)
            {
                throw new Exception("key does not exist");
            }
            return temp.data;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < keys.Count; i++)
            {
                yield return BinarySearch(keys[i]);
            }
        }
    }
}
