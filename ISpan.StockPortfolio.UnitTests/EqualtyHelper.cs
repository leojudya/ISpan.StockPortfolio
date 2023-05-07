using System.Text.Json;

namespace ISpan.StockPortfolio.UnitTests
{
	public static class EqualtyHelper
	{
		public static bool AreEqual<T>(T a, T b)
		{
			return JsonSerializer.Serialize(a) == JsonSerializer.Serialize(b);
		}
	}
}
