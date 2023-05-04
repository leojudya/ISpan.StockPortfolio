using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class ClosingPriceDto
	{
		public string Code { get; set; }
		public decimal? ClosingPrice { get; set; }
	}


	public class ClosingRoot
	{
		public ClosingPriceRawDto[] Dtos { get; set; }
	}

	public class ClosingPriceRawDto
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public string ClosingPrice { get; set; }
		public string MonthlyAveragePrice { get; set; }
	}
}
