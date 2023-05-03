using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Models
{
	public class PortfolioViewModel
	{
		
		public string Name { get; set; }
		public string Symbol { get; set; }
		public decimal UpAndDown { get; set; }
		public decimal UpAndDownPercentage { get; set; }
		public decimal OpeningPrice { get; set; }
		public decimal BidPrice { get; set; }
		public decimal MarketPrice { get; set; }
		public decimal AskPrice { get; set; }
		public decimal HighestPrice { get; set; }
		public decimal LowestPrice { get; set; }
		public int TradingVolume { get; set; }
		public int? GrossProfit { get; set; }
		public int? NetProfit { get; set; }
		public DateTime LastUpdated { get; set; }
	}
}
