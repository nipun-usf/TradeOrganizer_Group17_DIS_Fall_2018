﻿namespace TradeOrganizer_Group17_DIS_Fall_2018
{
    public class ClientPortfolio
    {
        public StockList StockList { get; set; }

        public decimal PortfolioValue { get; set; }
        public string HolderName { get; set; }
        public string HolderAddress { get; set; }
        public string ContactNumber { get; set; }

        // default constructor
        public ClientPortfolio()
        {
            StockList = new StockList();
            HolderName = null;
            HolderAddress = null;
            ContactNumber = null;
        }

        // Construtor for initialization
        public ClientPortfolio(string holderName, string holderAddress, string contactNumber)
        {
            StockList = new StockList();
            PortfolioValue = 0.0m;
            HolderName = holderName;
            HolderAddress = holderAddress;
            ContactNumber = contactNumber;
        }

        public decimal GetPortfolioValue()
        {
            return this.StockList.Value();
        }
    }
}
