using System;

namespace TradeOrganizer_Group17_DIS_Fall_2018
{
    public partial class StockList
    {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;

            //assign head of the list to StockNode object
            StockNode current = head;

            //Traverse Linked list till we reach end
            while (current != null)
            {
                //keep adding value of each node by multiplying holdings with price, and returns the total value
                value = value + (current.StockHolding.Holdings * current.StockHolding.CurrentPrice);

                //set current to be Next node
                current = current.Next;
            }

            return value;
        }

        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;

            //assign head of the listToCompare to StockNode object
            StockNode current = listToCompare.head;

            //Traverse first list till we reach end
            while (head != null)
            {

                //Traverse listToCompare list till we reach end
                while (current != null)
                {
                    //Check for similarity in name and increment similarityIndex
                    if (current.StockHolding.Name.Equals(head.StockHolding.Name))
                    {
                        similarityIndex++;
                        break;
                    }

                    //set current to be Next node
                    current = current.Next;
                }

                //move heads of both the linked lists
                head = head.Next;
                current = listToCompare.head;
            }

            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            //assign head of the list to StockNode object
            StockNode current = head;

            //Traverse Linked list till we reach end
            while (current != null)
            {
                //Print list to console
                Console.WriteLine(current.StockHolding);

                //set current to be Next node
                current = current.Next;
            }

        }
    }
}