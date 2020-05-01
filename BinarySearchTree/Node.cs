using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node<T> where T: IComparable
    {
        T data;
        int? linkOne;
        int? linkTwo;
        public Node(T data)
        {
            this.data = data;
            this.linkOne = null;
            this.linkTwo = null;
        }
    }
}
