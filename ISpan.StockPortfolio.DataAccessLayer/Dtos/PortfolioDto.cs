﻿using System;

namespace ISpan.StockPortfolio.DataAccessLayer.Dtos
{
	public class PortfolioDto
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

	public class PortfolioAddDto
	{
		public int UserId { get; set; }
		public int StockId { get; set; }
		public string Symbol { get; set; }
		public int? Quantity { get; set; }
		public decimal? Price { get; set; }
		public DateTime? PurchaseDate { get; set; }
	}

	public class PortfolioEditDto
	{
		public int Id { get; set; }
		public int? Quantity { get; set; }
		public decimal? Price { get; set; }
		public DateTime? PurchaseDate { get; set; }

	}

}
