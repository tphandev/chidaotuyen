using ChiDaoTuyen.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChiDaoTuyen.Service;
using AutoMapper;
using ChiDaoTuyen.Web.Models;
using ChiDaoTuyen.Model.Models;
using ChiDaoTuyen.Web.Infrastructure.Extensions;
using System.Web.Script.Serialization;

namespace ChiDaoTuyen.Web.Api
{
    public class DaoTaoLienTucController : ApiControllerBase
    {
        IDaoTaoLienTucService _daoTaoLienTucService;
        public DaoTaoLienTucController(IErrorService errorService, IDaoTaoLienTucService daoTaoLienTucService) 
            : base(errorService)
        {
            _daoTaoLienTucService = daoTaoLienTucService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request, string keyword, int page, int pageSize = 20)
        {
            return CreateHttpResponse(request, () =>
            {
                int totalRow = 0;
                var listDaoTaoLienTuc = _daoTaoLienTucService.GetAll(keyword);

                totalRow = listDaoTaoLienTuc.Count();

                var query = listDaoTaoLienTuc.OrderByDescending(x => x.NgayTao).Skip(page * pageSize).Take(pageSize);

                var listDaoTaoLienTucVm = Mapper.Map<List<DaoTaoLienTucViewModel>>(query);

                var paginationSet = new PaginationSet<DaoTaoLienTucViewModel>()
                {
                    Items = listDaoTaoLienTucVm,
                    Page = page,
                    TotalCount = totalRow,
                    TotalPages = (int)Math.Ceiling((decimal)totalRow / pageSize)
                };

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, paginationSet);

                return response;
            });
        }

        [Route("getbyid/{id:int}")]
        public HttpResponseMessage Get(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                var daoTaoLienTuc = _daoTaoLienTucService.GetById(id);

                var daoTaoLienTucVm = Mapper.Map<DaoTaoLienTucViewModel>(daoTaoLienTuc);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, daoTaoLienTucVm);

                return response;
            });
        }

        [Route("create")]
        public HttpResponseMessage Post(HttpRequestMessage request, DaoTaoLienTucViewModel daoTaoLienTucVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    DaoTaoLienTuc newDaoTaoLienTuc = new DaoTaoLienTuc();
                    newDaoTaoLienTuc.UpdateDaoTaoLienTuc(daoTaoLienTucVm);
                    newDaoTaoLienTuc.NgayTao = DateTime.Now;
                    newDaoTaoLienTuc.NguoiTao = User.Identity.Name;
                    var daoTaoLienTuc = _daoTaoLienTucService.Add(newDaoTaoLienTuc);
                    _daoTaoLienTucService.SaveChanges();

                    var responseData = Mapper.Map<DaoTaoLienTucViewModel>(daoTaoLienTuc);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, DaoTaoLienTucViewModel daoTaoLienTucVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    DaoTaoLienTuc dbDaoTaoLienTuc = _daoTaoLienTucService.GetById(daoTaoLienTucVm.ID);
                    dbDaoTaoLienTuc.UpdateDaoTaoLienTuc(daoTaoLienTucVm);
                    dbDaoTaoLienTuc.NgayCapNhat = DateTime.Now;
                    dbDaoTaoLienTuc.NguoiCapNhat = User.Identity.Name;
                    _daoTaoLienTucService.Update(dbDaoTaoLienTuc);
                    _daoTaoLienTucService.SaveChanges();

                    var responseData = Mapper.Map<DaoTaoLienTucViewModel>(dbDaoTaoLienTuc);
                    response = request.CreateResponse(HttpStatusCode.Created, responseData);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        [Route("delete")]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var oldDaoTaoLienTuc = _daoTaoLienTucService.Delete(id);
                    _daoTaoLienTucService.SaveChanges();

                    var responseData = Mapper.Map<DaoTaoLienTucViewModel>(oldDaoTaoLienTuc);
                    response = request.CreateResponse(HttpStatusCode.OK, responseData);
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }

        [Route("deletemulti")]
        public HttpResponseMessage Delete(HttpRequestMessage request, string checkedDaoTaoLienTucIds)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    var listDaoTaoLienTucIds = new JavaScriptSerializer().Deserialize<List<int>>(checkedDaoTaoLienTucIds);
                    foreach (var item in listDaoTaoLienTucIds)
                    {
                        _daoTaoLienTucService.Delete(item);

                    }

                    _daoTaoLienTucService.SaveChanges();

                    response = request.CreateResponse(HttpStatusCode.OK, listDaoTaoLienTucIds.Count());
                }
                else
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                return response;
            });
        }
    }
}