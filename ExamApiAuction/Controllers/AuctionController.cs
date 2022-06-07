using AutoMapper;
using ExamApiAuction.Dtos.AuctionDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IAuctionRepository _auctionRepository;
        private IMapper _mapper;

        public AuctionController(IAuctionRepository auctionRepository, IMapper mapper)
        {
            _auctionRepository = auctionRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAuctionAsync(CancellationToken cancellationToken)
        {
            var result = await _auctionRepository.GetAuctionsAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuctin(AuctionCreateDto auct, CancellationToken cancellationToken)
        {
            var auctModel = _mapper.Map<Auction>(auct);
            await _auctionRepository.AddAuction(auctModel, cancellationToken);
            _auctionRepository.Savechange();

            return await Task.FromResult(Ok(auctModel));
        }

        [HttpPut("{auctId}")]
        public async Task<IActionResult> UpdateAuction(int auctId, AuctionUpdateDto auct, CancellationToken cancellationToken)
        {
            var auctResult = await _auctionRepository.GetAuctionById(auctId, cancellationToken);
            if (auctResult == null)
            {
            }

            var auctModel = _mapper.Map<Auction>(auct);
            auctModel.Id = auctResult.Id;
            _auctionRepository.UpdateAuction(auctModel);
            _auctionRepository.Savechange();

            return await Task.FromResult(Ok(auctModel));
        }

        [HttpDelete("{auctId}")]
        public async Task<IActionResult> DeleteAuction(int auctId, CancellationToken cancellationToken)
        {
            var auctResult = await _auctionRepository.GetAuctionById(auctId, cancellationToken);
            if (auctResult == null)
            {
            }

            _auctionRepository.DeleteAuction(auctResult);
            _auctionRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }
}
