using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.DataAccessLayer.Core
{
	public class ForgetPassword
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public Guid Guid { get; set; }
		public DateTime ExpiryTime { get; set; }
	}
}
