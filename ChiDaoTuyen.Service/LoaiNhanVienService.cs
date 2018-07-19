using ChiDaoTuyen.Data.Infrastructure;
using ChiDaoTuyen.Data.Repositories;
using ChiDaoTuyen.Model.Models;
using System.Collections.Generic;

namespace ChiDaoTuyen.Service
{
    public interface ILoaiNhanVienService
    {
        LoaiNhanVien Add(LoaiNhanVien loaiNhanVien);

        void Update(LoaiNhanVien loaiNhanVien);

        void Detele(string maLoai);

        IEnumerable<LoaiNhanVien> GetAll();

        IEnumerable<LoaiNhanVien> GetAllPaging(int page, int pageSize, out int totalRow);

        LoaiNhanVien GetByMa(string maLoai);

        void SaveChanges();
    }

    public class LoaiNhanVienService : ILoaiNhanVienService
    {
        private ILoaiNhanVienRepository _loaiNhanVienRepository;
        private IUnitOfWork _unitOfWork;

        public LoaiNhanVienService(ILoaiNhanVienRepository loaiNhanVienRepository, IUnitOfWork unitOfWork)
        {
            _loaiNhanVienRepository = loaiNhanVienRepository;
            _unitOfWork = unitOfWork;
        }

        public LoaiNhanVien Add(LoaiNhanVien loaiNhanVien)
        {
            return _loaiNhanVienRepository.Add(loaiNhanVien);
        }

        public void Detele(string maLoai)
        {
            _loaiNhanVienRepository.DeleteMulti(x => x.MaLoai == maLoai);
        }

        public IEnumerable<LoaiNhanVien> GetAll()
        {
            return _loaiNhanVienRepository.GetAll();
        }

        public IEnumerable<LoaiNhanVien> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _loaiNhanVienRepository.GetMultiPaging(x => x.xoa == false, out totalRow, page, pageSize);
        }

        public LoaiNhanVien GetByMa(string maLoai)
        {
            return _loaiNhanVienRepository.GetSingleByCondition(x => x.MaLoai == maLoai);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(LoaiNhanVien loaiNhanVien)
        {
            _loaiNhanVienRepository.Update(loaiNhanVien);
        }
    }
}