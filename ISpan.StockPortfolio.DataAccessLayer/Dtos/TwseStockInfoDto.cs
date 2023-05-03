using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class TwseStockInfoDto
	{
		public string Symbol { get; set; }
		public string Name { get; set; }
		public decimal OpeningPrice { get; set; }
		public decimal HighestPrice { get; set; }
		public decimal LowestPrice { get; set; }
		public decimal MarketPrice { get; set; }
		public decimal BidPrice { get; set; }
		public decimal AskPrice { get; set; }
		public int TradingVolume { get; set; }
		public DateTime LastUpdated { get; set; }
	}
}
