using AutoMapper;
using ISpan.StockPortfolio.Common;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ISpan.StockPortfolio.Services
{
	public class PortfolioService
	{
		private readonly IPortfolioRepository _portfolioRepository;
		private static readonly TwseStockInfoService _twseStockInfoService = new TwseStockInfoService();
		private static MapperConfiguration _mapperConfiguration;
		private static IMapper _mapper;

		public PortfolioService()
		{
			_mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			_mapper = _mapperConfiguration.CreateMapper();
			_portfolioRepository = new PortfolioRepository();
		}

		public int Update(PortfolioEditDto dto)
		{
			return _portfolioRepository.Update(dto);
		}

		public int Delete(int portfolioId)
		{
			return _portfolioRepository.Delete(portfolioId);
		}

		public async Task<IEnumerable<PortfolioDetailViewModel>> GetPortfolio(int userId)
		{
			var portfolioEntities = _portfolioRepository.Search(userId);
			var portfolioDtos = _mapper.Map<IEnumerable<PortfolioDto>>(portfolioEntities);
			var symbols = portfolioDtos.Select(dto => dto.Symbol).ToHashSet();
			var twseStockInfos = await _twseStockInfoService.GetRealtimeStocksInfo(symbols);
			var portfolioViewModels = MergeTwseInfoAndPofoilo(portfolioDtos, twseStockInfos);

			return portfolioViewModels.ToList();
		}

		public int InsertPortfolio(PortfolioAddViewModel viewModel)
		{
			var config = new MapperConfiguration(cfg => cfg.AddProfile<ServiceMapper>());
			var mapper = config.CreateMapper();
			var result = mapper.Map<PortfolioAddDto>(viewModel);

			return _portfolioRepository.Insert(result);
		}

		private IEnumerable<PortfolioDetailViewModel> MergeTwseInfoAndPofoilo(IEnumerable<PortfolioDto> portfolioDtos, IEnumerable<TwseStockInfoDto> twseStockInfoDtos)
		{
			return portfolioDtos.Join(
				twseStockInfoDtos,
				portfolioDto => portfolioDto.Symbol,
				twseStockInfoDto => twseStockInfoDto.Symbol,
				(p, t) => new PortfolioDetailViewModel()
				{
					Id = p.Id,
					StockTypeId = p.StockTypeId,
					Name = t.Name,
					Symbol = p.Symbol,
					ClosingPrice = t.ClosingPrice,
					OpeningPrice = t.OpeningPrice,
					BidPrice = t.BidPrice,
					MarketPrice = t.MarketPrice,
					AskPrice = t.AskPrice,
					HighestPrice = t.HighestPrice,
					LowestPrice = t.LowestPrice,
					TradingVolume = t.TradingVolume,
					LastUpdated = t.LastUpdated,
					Quantity = p.Quantity,
					Price = p.Price,
					PurchaseDate = p.PurchaseDate,
					Profit = null
				}
			).Select(pv =>
			{
				if (pv.Price != null)
					pv.Profit = new StockFee(pv).NetProfit;
				return pv;
			});
		}
	}
}
