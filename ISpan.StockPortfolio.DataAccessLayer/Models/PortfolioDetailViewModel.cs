using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Models
{
	public class PortfolioDetailViewModel
	{
		[Display(Name = "股名")]
		[DisplayName("股名")]
		public string Name { get; set; }
		[Display(Name = "代號")]
		[DisplayName("代號")]
		public string Symbol { get; set; }
		[Display(Name = "漲跌")]
		[DisplayName("漲跌")]
		public decimal? UpAndDown => ClosingPrice != null ? MarketPrice - ClosingPrice : null;
		[Display(Name = "漲跌幅度")]
		[DisplayName("漲跌幅度")]
		public decimal? UpAndDownPercentage => ClosingPrice != null ? (UpAndDown / ClosingPrice) : null;
		[Display(Name = "開盤價")]
		[DisplayName("開盤價")]
		public decimal OpeningPrice { get; set; }
		[Display(Name = "賣價")]
		[DisplayName("賣價")]
		public decimal BidPrice { get; set; }
		[Display(Name = "現價")]
		[DisplayName("現價")]
		public decimal MarketPrice { get; set; }
		[Display(Name = "買價")]
		[DisplayName("買價")]
		public decimal AskPrice { get; set; }
		[Display(Name = "最高")]
		[DisplayName("最高")]
		public decimal HighestPrice { get; set; }
		[Display(Name = "最低")]
		[DisplayName("最低")]
		public decimal LowestPrice { get; set; }
		[Display(Name = "昨收")]
		[DisplayName("昨收")]
		public decimal? ClosingPrice { get; set; }
		[Display(Name = "交易量")]
		[DisplayName("交易量")]
		public int TradingVolume { get; set; }
		
		[Display(Name = "成本價")]
		[DisplayName("成本價")]
		public decimal? Price { get; set; }
		[Display(Name = "股數")]
		[DisplayName("股數")]
		public int? Quantity { get; set; }

		[Display(Name = "損益")]
		[DisplayName("損益")]
		public int? Profit { get; set; }
		[Display(Name = "購買日")]
		[DisplayName("購買日")]
		public DateTime? PurchaseDate { get; set; }
		[Display(Name = "最後更新")]
		[DisplayName("最後更新")]
		public DateTime LastUpdated { get; set; }
	}
}
