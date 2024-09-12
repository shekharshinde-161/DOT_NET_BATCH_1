using System;
using System.Collections.Generic;

namespace DataStructure
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List list = new List();
            list.InsertAtBegin(10);
            list.InsertAtBegin(20);
            list.InsertAtBegin(30);

            list.PrintList();

            list.InsertAtPos(50, 3);

            list.InsertAtEnd(40);
            list.PrintList();

            list.RemoveAtBegin();
            list.PrintList();
        }
    }
}


//insert after   data,ref

//remove end 

//remove data

//length -- counter 0  

//find  -- return bool 