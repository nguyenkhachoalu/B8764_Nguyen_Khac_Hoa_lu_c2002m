using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.AuctionDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores
{
    public class AuctionRepository : IAuctionRepository
    {
        private AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public AuctionRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task AddAuction(Auction auction, CancellationToken cancellationToken)
        {
            await _appDbContext.Auctions.AddAsync(auction, cancellationToken);
        }

        public void DeleteAuction(Auction auction)
        {
            _appDbContext.Auctions.Remove(auction);
        }

        public async Task<Auction> GetAuctionById(int id, CancellationToken cancellationToken)
        {

            return await _appDbContext.Auctions.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }
        public async Task<IEnumerable<AuctionReadDto>> GetAuctionsAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Auctions.AsNoTracking().ProjectTo<AuctionReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        public void Savechange()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateAuction(Auction auction)
        {
            _appDbContext.Auctions.Update(auction);
        }

       
    }
}
