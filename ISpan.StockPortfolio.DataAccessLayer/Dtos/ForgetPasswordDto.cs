using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class ForgetPasswordDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Guid { get; set; }
		public DateTime ExpiryTime { get; set; }
	}
}
