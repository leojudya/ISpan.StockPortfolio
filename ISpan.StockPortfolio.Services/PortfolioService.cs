using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Models;
using ISpan.StockPortfolio.Common;

namespace ISpan.StockPortfolio.Services
{
	public class PortfolioService
	{
		private static readonly PortfolioRepository _portfolioRepository = new PortfolioRepository();
		private static readonly TwseStockInfoService _twseStockInfoService = new TwseStockInfoService();

		public async Task<IEnumerable<PortfolioViewModel>> GetPortfolio(int userId)
		{
			var portfolioDtos = _portfolioRepository.Search(userId);
			var symbols = portfolioDtos.Select(dto => dto.Symbol);
			var twseStockInfos = await _twseStockInfoService.GetRealtimeStocksInfo(symbols);
			var portfolioViewModels = await MergeTwseInfoAndPofoilo(portfolioDtos, twseStockInfos);

			return portfolioViewModels.ToList();
		}

		public int InsertPortfolio(PortfolioAddViewModel viewModel)
		{
			var config = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			var mapper = config.CreateMapper();
			var result = mapper.Map<PortfolioAddDto>(viewModel);

			return _portfolioRepository.Insert(result);
		}

		private async Task<IEnumerable<PortfolioViewModel>> MergeTwseInfoAndPofoilo(IEnumerable<PortfolioDto> portfolioDtos, IEnumerable<TwseStockInfoDto> twseStockInfoDtos)
		{
			var closingPrices = await _twseStockInfoService.GetClosingPrices();

			return portfolioDtos.Join(
				twseStockInfoDtos,
				portfolioDto => portfolioDto.Symbol,
				twseStockInfoDto => twseStockInfoDto.Symbol,
				(p, t) => new PortfolioViewModel(){
						Name = t.Name,
						Symbol = p.Symbol,
						ClosingPrice = closingPrices.Where(cp => cp.Code == t.Symbol).Select(cp => cp.ClosingPrice).First() ?? (decimal?)null,
						OpeningPrice = t.OpeningPrice,
						BidPrice = t.BidPrice,
						MarketPrice = t.MarketPrice,
						AskPrice = t.AskPrice,
						HighestPrice = t.HighestPrice,
						LowestPrice = t.LowestPrice,
						TradingVolume = t.TradingVolume,
						LastUpdated = t.LastUpdated,
						Profit = null,
				}
			);
		}
	}
}
