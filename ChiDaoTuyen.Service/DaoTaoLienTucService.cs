using ChiDaoTuyen.Data.Infrastructure;
using ChiDaoTuyen.Data.Repositories;
using ChiDaoTuyen.Model.Models;
using System;
using System.Collections.Generic;

namespace ChiDaoTuyen.Service
{
    public interface IDaoTaoLienTucService
    {
        DaoTaoLienTuc Add(DaoTaoLienTuc daoTaoLienTuc);

        void Update(DaoTaoLienTuc daoTaoLienTuc);

        DaoTaoLienTuc Delete(int id);

        IEnumerable<DaoTaoLienTuc> GetAll();

        IEnumerable<DaoTaoLienTuc> GetAll(string keyword);

        IEnumerable<DaoTaoLienTuc> GetAllPaging(int page, int pageSize, out int totalRow);

        DaoTaoLienTuc GetById(int id);

        IEnumerable<DaoTaoLienTuc> GetAllByDonViPaging(string idNV, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class DaoTaoLienTucService : IDaoTaoLienTucService
    {
        IDaoTaoLienTucRepository _daoTaoLienTucRepository;
        IUnitOfWork _unitOfWork;

        public DaoTaoLienTucService(IDaoTaoLienTucRepository daoTaoLienTucRepository, IUnitOfWork unitOfWork)
        {
            _daoTaoLienTucRepository = daoTaoLienTucRepository;
            _unitOfWork = unitOfWork;
        }
        public DaoTaoLienTuc Add(DaoTaoLienTuc daoTaoLienTuc)
        {
            return _daoTaoLienTucRepository.Add(daoTaoLienTuc);
        }

        public DaoTaoLienTuc Delete(int id)
        {
            return _daoTaoLienTucRepository.Delete(id);
        }

        public IEnumerable<DaoTaoLienTuc> GetAll()
        {
           return _daoTaoLienTucRepository.GetAll();
        }

        public IEnumerable<DaoTaoLienTuc> GetAll(string keyword)
        {
            if (!String.IsNullOrEmpty(keyword))
                return _daoTaoLienTucRepository.GetMulti(x => x.NhanVien.HoTen.Contains(keyword) || x.NoiDung.Contains(keyword));
            else
                return _daoTaoLienTucRepository.GetAll();
        }

        public IEnumerable<DaoTaoLienTuc> GetAllByDonViPaging(string idNV,int page, int pageSize, out int totalRow)
        {
            return _daoTaoLienTucRepository.GetMultiPaging(x=>x.xoa==false && x.MaNhanVien== idNV, out totalRow, page, pageSize);
        }

        public IEnumerable<DaoTaoLienTuc> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _daoTaoLienTucRepository.GetMultiPaging(x => x.xoa == false, out totalRow, page, pageSize);
        }

        public DaoTaoLienTuc GetById(int id)
        {
            return _daoTaoLienTucRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(DaoTaoLienTuc daoTaoLienTuc)
        {
            _daoTaoLienTucRepository.Update(daoTaoLienTuc);
        }
    }
}