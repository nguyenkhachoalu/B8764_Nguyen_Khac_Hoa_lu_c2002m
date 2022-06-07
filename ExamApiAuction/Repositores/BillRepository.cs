using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.BillDto;
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
    public class BillRepository : IBillRepository
    {
        private AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public BillRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task AddBill(Bill bill, CancellationToken cancellationToken)
        {
            await _appDbContext.Bills.AddAsync(bill, cancellationToken);
        }

        public void DeleteBill(Bill bill)
        {
            _appDbContext.Bills.Remove(bill);
        }

        public async Task<Bill> GetBillById(int id, CancellationToken cancellationToken)
        {

            return await _appDbContext.Bills.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<BillReadDto>> GetBillsAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Categories.ProjectTo<BillReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
        public async Task<IEnumerable<BillReadDto>> GetBillByTimeAsync(DateTime dateFrom, DateTime DateTo, CancellationToken cancellationToken)
        {
            var result = await _appDbContext.Bills.AsNoTracking().Where(x => x.CreateDate >= dateFrom && x.CreateDate <= DateTo).
                ProjectTo<BillReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            return result;
        }
        public void Savechange()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateBill(Bill bill)
        {
            _appDbContext.Bills.Update(bill);
        }
    }
}
