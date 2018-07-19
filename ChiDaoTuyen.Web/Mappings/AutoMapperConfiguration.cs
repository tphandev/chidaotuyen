using AutoMapper;
using ChiDaoTuyen.Model.Models;
using ChiDaoTuyen.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChiDaoTuyen.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<DaoTaoLienTuc, DaoTaoLienTucViewModel>();
                cfg.CreateMap<LoaiNhanVien, LoaiNhanVienViewModel>();
               
            });
        }
    }
}