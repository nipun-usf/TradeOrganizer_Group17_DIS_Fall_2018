using System;
using System.Collections.Generic;
using System.Text;

namespace TradeOrganizer_Group17_DIS_Fall_2018
{
    public partial class StockList
    {
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            // Instantiate a new object - resultList
            StockList resultList = new StockList();
            // assign head of the list to StockNode object 
            StockNode current;

            // Add first 
            current = head;
            // Traverse till we reach the end of Linked List
            while (current != null)
            {
                // Add stock to the resultList
                resultList.AddStock(current.StockHolding);
                // set next node as current
                current = current.Next;
            }

            //Add second
            current = listToMerge.head;
            // Traverse till we reach the end of Linked List
            while (current != null)
            {
                resultList.AddStock(current.StockHolding);
                // set next node as current 
                current = current.Next;
            }
            // return value of resultList variable
            return resultList;
        }

        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {
            // Initialize mostShareStock as null
            Stock mostShareStock = null;

            StockNode current = head;
            // storing the stock holding value of current node
            mostShareStock = current.StockHolding;
            // Traverse till we reach the end of Linked List
            while (current != null)
            {
                // if current stock  holdings is maximum, set it as most stock
                if (current.StockHolding.Holdings > mostShareStock.Holdings)
                    mostShareStock = current.StockHolding;
                // set next node as current
                current = current.Next;
            }
            // return the value of mostShareStck for each client
            return mostShareStock;
        }

        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;

            StockNode current = head;
            // Traverse till we reach the end of Linked List
            while (current != null)
            {
                //Increment value of length by 1
                length++;
                // set next node as current
                current = current.Next;
            }
            // return the value of length
            return length;
        }
    }
}