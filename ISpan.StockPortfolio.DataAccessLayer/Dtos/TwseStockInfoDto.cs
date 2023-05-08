using System;
using System.Collections.Generic;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class TwseStockInfoDto
	{
		public string Symbol { get; set; }
		public string Name { get; set; }
		public decimal? OpeningPrice { get; set; }
		public decimal? HighestPrice { get; set; }
		public decimal? LowestPrice { get; set; }
		public decimal? ClosingPrice { get; set; }
		public decimal MarketPrice { get; set; }
		public decimal BidPrice { get; set; }
		public decimal AskPrice { get; set; }
		public int TradingVolume { get; set; }
		public DateTime LastUpdated { get; set; }
	}

	public class StockRawInfo
	{
		public string tv { get; set; }
		public string ps { get; set; }
		public string pz { get; set; }
		public string bp { get; set; }
		public string fv { get; set; }
		public string oa { get; set; }
		public string ob { get; set; }
		public string a { get; set; }
		public string b { get; set; }
		public string c { get; set; }
		public string d { get; set; }
		public string ch { get; set; }
		public string ot { get; set; }
		public string tlong { get; set; }
		public string f { get; set; }
		public string ip { get; set; }
		public string g { get; set; }
		public string mt { get; set; }
		public string ov { get; set; }
		public string h { get; set; }
		public string i { get; set; }
		public string it { get; set; }
		public string oz { get; set; }
		public string l { get; set; }
		public string n { get; set; }
		public string o { get; set; }
		public string p { get; set; }
		public string ex { get; set; }
		public string s { get; set; }
		public string t { get; set; }
		public string u { get; set; }
		public string v { get; set; }
		public string w { get; set; }
		public string nf { get; set; }
		public string y { get; set; }
		public string z { get; set; }
		public string ts { get; set; }
		public string nu { get; set; }
	}

	public class StockQueryTime
	{
		public string sysDate { get; set; }
		public int stockInfoItem { get; set; }
		public int stockInfo { get; set; }
		public string sessionStr { get; set; }
		public string sysTime { get; set; }
		public bool showChart { get; set; }
		public long? sessionFromTime { get; set; }
		public long? sessionLatestTime { get; set; }
	}

	public class StockRoot
	{
		public List<StockRawInfo> msgArray { get; set; }
		public string referer { get; set; }
		public int userDelay { get; set; }
		public string rtcode { get; set; }
		public StockQueryTime queryTime { get; set; }
		public string rtmessage { get; set; }
		public string exKey { get; set; }
		public int cachedAlive { get; set; }
	}
}
