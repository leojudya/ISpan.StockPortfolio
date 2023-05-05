using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Core
{
	public class Portfolio
	{
			public int Id { get; set; }
			public int StockTypeId { get; set; }
			public int UserId { get; set; }
			public int StockId { get; set; }
			public string Symbol { get; set; }
			public int? Quantity { get; set; }
			public decimal? Price { get; set; }
			public DateTime? PurchaseDate { get; set; }
		
	}
}
