using AutoMapper;
using ExamApiAuction.Dtos.BillDto;
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
    public class BillController : ControllerBase
    {
        private readonly IBillRepository _billRepository;
        private IMapper _mapper;

        public BillController(IBillRepository billRepository, IMapper mapper)
        {
            _billRepository = billRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetBillAsync(CancellationToken cancellationToken)
        {
            var result = await _billRepository.GetBillsAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBill(BillCreateDto bill, CancellationToken cancellationToken)
        {
            var billModel = _mapper.Map<Bill>(bill);
            await _billRepository.AddBill(billModel, cancellationToken);
            _billRepository.Savechange();

            return await Task.FromResult(Ok(billModel));
        }

        [HttpPut("{billId}")]
        public async Task<IActionResult> UpdateBill(int billId, BillUpdateDto bill, CancellationToken cancellationToken)
        {
            var billResult = await _billRepository.GetBillById(billId, cancellationToken);
            if (billResult == null)
            {
            }

            var billModel = _mapper.Map<Bill>(bill);
            billModel.Id = billResult.Id;
            _billRepository.UpdateBill(billModel);
            _billRepository.Savechange();

            return await Task.FromResult(Ok(billModel));
        }

        [HttpDelete("{billId}")]
        public async Task<IActionResult> DeleteBill(int billId, CancellationToken cancellationToken)
        {
            var billResult = await _billRepository.GetBillById(billId, cancellationToken);
            if (billResult == null)
            {
            }

            _billRepository.DeleteBill(billResult);
            _billRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }
}
