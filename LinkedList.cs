using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace data_structures
{
    internal class LinkedList
    {

        Node Head;

    public LinkedList()
            {

            }

            public LinkedList(Node data)
            {

            }

            // Method to add to  the end of the list
            public void Add(int data)
            {
            if (Head == null)
            {
                Head = new Node(data);
            }
            Node Data = new Node(data);
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.GetNext();
            }
            temp.SetNext(Data);
            }


            public string Display()
            {
            Node temp = Head;
            string str = "";
            while(temp.Next != null)
            {
                str += temp.GetValue() + "->";
                temp = temp.GetNext();
            }
            str += temp.GetValue() + "->";

            return str;
            }

            public int Length()
        {
            Node temp = Head;
            int cnt = 0;
            while(temp.Next != null)
            {
                cnt++;
                temp = temp.GetNext();
            }
            return cnt;
        }

    // Method to remove the first value
    public void RemoveValue(int data)
            {
            Node pointer = Head;

            Node temp = Head;
            while (temp.Next != null)
            {
                if (temp.GetValue() == data)
                {
                   pointer = temp.GetNext();
                    temp.SetNext(pointer);
                    return;
                }
                temp = temp.GetNext();
            }
        }

            // Method to remove the first value
            public void RemoveAllValues(int data)
            {
            Node pointer = Head;

            Node temp = Head;
            while (temp.Next != null)
            {
                if (temp.GetValue() == data)
                {
                    pointer = temp.GetNext();
                    temp.SetNext(pointer);
                }
                temp = temp.GetNext();
            }
        }

            // Method to remove the value in an index
            public void RemoveIndex(int data)
            {
            int cnt = 0;
            Node pointer = Head;

            Node temp = Head;
            if (temp.Next != null)
            {
                Console.WriteLine("אין כזה אינדקס");
            }
            while (Head.Next != null)
            {
               
                if (cnt==data)
                {
                    pointer = temp.GetNext();
                    temp.SetNext(pointer);
                    return ;
                }
                temp = temp.GetNext();

                cnt++;
                
            }
        }

            // Method to find by value
            public int Find(int data)
            {
            int cnt = 0;
         

            Node temp = Head;
            
            while (temp.Next != null)
            {

                if (cnt == data)
                {
                  break;

                }
                temp = temp.GetNext();

                cnt++;
                
            }
            return cnt;
        }

            // Method to get a value by  index
            public int Get(int data)
            {
            int num = 0;


            Node temp = Head;

            while (temp.Next != null)
            {

                if (temp.GetValue() == data)
                {
                    
                    break;

                }
                temp = temp.GetNext();


            }
            return temp.GetValue();

        }
        }
}
