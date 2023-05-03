using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class StockDto
	{
        public int Id { get; set; }
		public int StockTypeId { get; set; }
		public string Name { get; set; }
		public string StockType { get; set; }
		public string StockSymbol { get; set; }
    }
}
