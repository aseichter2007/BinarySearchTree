using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T> where T: IComparable
    {
        public T data;
        public int key;
        public List<Node<T>> links;
        public Node(int key,T data)
        {
            this.key = key;
            this.data = data;
            links = new List<Node<T>>() { null,null};
        }
        
    }
}
