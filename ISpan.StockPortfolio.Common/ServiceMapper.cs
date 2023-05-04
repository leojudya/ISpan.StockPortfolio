using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ISpan.StockPortfolio.DataAccessLayer;
using ISpan.StockPortfolio.DataAccessLayer.Dtos;
using ISpan.StockPortfolio.DataAccessLayer.Models;

namespace ISpan.StockPortfolio.Common
{
    public class ServiceMapper : Profile
    {
		public ServiceMapper()
		{

			CreateMap<StockRawInfo, TwseStockInfoDto>()
			   .ForMember(x => x.Symbol, y => y.MapFrom(o => o.c))
			   .ForMember(x => x.Name, y => y.MapFrom(o => o.n))
			   .ForMember(x => x.OpeningPrice, y => y.MapFrom(o => o.o))
			   .ForMember(x => x.HighestPrice, y => y.MapFrom(o => o.h))
			   .ForMember(x => x.LowestPrice, y => y.MapFrom(o => o.l))
			   .ForMember(x => x.MarketPrice, y => y.MapFrom(o => o.z == "-" ? o.b.Split('_')[0] : o.z))
			   .ForMember(x => x.BidPrice, y => y.MapFrom(o => o.a.Split('_')[0]))
			   .ForMember(x => x.AskPrice, y => y.MapFrom(o => o.b.Split('_')[0]))
			   .ForMember(x => x.TradingVolume, y => y.MapFrom(o => o.v))
			   .ForMember(x => x.LastUpdated, y => y.MapFrom(o => DateTime.ParseExact($"{o.d} {o.t}", "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture)));

			CreateMap<PortfolioAddViewModel, PortfolioAddDto>();
			CreateMap<ClosingPriceRawDto, ClosingPriceDto>()
				.ForMember(x => x.ClosingPrice, y => y.MapFrom(o => string.IsNullOrEmpty(o.ClosingPrice) ? (decimal?)null : decimal.Parse(o.ClosingPrice)));

			CreateMap<PortfolioDetailViewModel, PortfolioViewModel>();
		}
	}
}
