using ExamApiAuction.Dtos.BillDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface IBillRepository
    {
        Task<IEnumerable<BillReadDto>> GetBillsAsync(CancellationToken cancellationToken);
        Task<Bill> GetBillById(int id, CancellationToken cancellationToken);
        Task AddBill(Bill bill, CancellationToken cancellationToken);
        Task<IEnumerable<BillReadDto>> GetBillByTimeAsync(DateTime dateFrom, DateTime DateTo, CancellationToken cancellationToken);
        void UpdateBill(Bill bill);
        void DeleteBill(Bill bill);
        void Savechange();
    }
}
