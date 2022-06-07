using ExamApiAuction.Dtos.AuctionDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface IAuctionRepository
  { 
        Task<IEnumerable<AuctionReadDto>> GetAuctionsAsync(CancellationToken cancellationToken);
        Task<Auction> GetAuctionById(int id, CancellationToken cancellationToken);
        Task AddAuction(Auction auction, CancellationToken cancellationToken);
        void UpdateAuction(Auction auction);
        void DeleteAuction(Auction auction);
        void Savechange();
    
    }
}
