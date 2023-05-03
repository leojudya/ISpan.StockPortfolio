using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISpan.StockPortfolio.Services;

namespace ConsoleApp2
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			var s = new TwseStockInfoService();
			var a = await s.Test(new string[] { "2330", "00878" });
			Console.WriteLine(a);
		}
	}
}
