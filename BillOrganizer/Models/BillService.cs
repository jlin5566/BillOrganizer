using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BillOrganizer.Repositories;
using BillOrganizer.Models.ViewModels;

namespace BillOrganizer.Models
{
    public class BillService
    {

        private readonly IRepository<AccountBook> _billRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<BillViewModels> Lookup()
        {
            var source = _billRepository.LookupAll();
            var result = source.Select(x => new BillViewModels
            {
                Type = x.Categoryyy == 0 ? "支出" : "收入",
                CreateDate = x.Dateee,
                Money = x.Amounttt,
                Remark = x.Remarkkk
            })
             .OrderBy(x => x.CreateDate);

            return result;
        }

        public void Create(AccountBook entity)
        {
           _billRepository.Create(entity);
        }

        public void Remove(AccountBook entity)
        {
            _billRepository.Remove(entity);
        }

        public void Save()
        {
            _unitOfWork.Save();
        }
    }
}