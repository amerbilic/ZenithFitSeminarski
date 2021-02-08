using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;
using ZenithFit.WebAPI.Database;

namespace ZenithFit.WebAPI.Services
{
    public class ProcurementsService : BaseCRUDService<Model.Procurements, ProcurementsSearchRequest, Database.Procurements, ProcurementsInsertRequest, object>
    {
        public ProcurementsService(ZenithFitDatabaseContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Procurements> Get(ProcurementsSearchRequest search)
        {
            var list = _context.Procurements.Include(x => x.Warehouse).Include(c => c.Supplier).ToList();

            var procurementlist = new List<Model.Procurements>();

            foreach ( var item in list)
            {
                Model.Procurements procurement = new Model.Procurements();

                procurement.ProcurementNumber = item.ProcurementNumber;
                procurement.ProcurementNote = item.ProcurementNote;
                procurement.ProcurementAccountAmount = item.ProcurementAccountAmount;
                procurement.ProcurementDate = item.ProcurementDate;
                procurement.ProcurementId = item.ProcurementId;
                procurement.ProcurementTax = item.ProcurementTax;
                procurement.SupplierId = item.SupplierId;
                procurement.WarehouseId = item.WarehouseId;
                procurement.WarehouseName = item.Warehouse.WarehouseName;
                procurement.SupplierName = item.Supplier.SupplierName;
                procurement.ContactPerson = item.Supplier.SupplierContact;
                procurement.ContactPhone = item.Supplier.SupplierPhone;

                procurementlist.Add(procurement);
            }

            return procurementlist;

        }

        public override Model.Procurements GetById(int id)
        {
            Database.Procurements item = _context.Procurements.Where(x => x.ProcurementId == id).Include(c => c.Supplier).Include(y => y.Warehouse).SingleOrDefault();

            Model.Procurements procurement = new Model.Procurements();

            procurement.ProcurementNumber = item.ProcurementNumber;
            procurement.ProcurementNote = item.ProcurementNote;
            procurement.ProcurementAccountAmount = item.ProcurementAccountAmount;
            procurement.ProcurementDate = item.ProcurementDate;
            procurement.ProcurementId = item.ProcurementId;
            procurement.ProcurementTax = item.ProcurementTax;
            procurement.SupplierId = item.SupplierId;
            procurement.WarehouseId = item.WarehouseId;
            procurement.WarehouseName = item.Warehouse.WarehouseName;
            procurement.SupplierName = item.Supplier.SupplierName;
            procurement.ContactPerson = item.Supplier.SupplierContact;
            procurement.ContactPhone = item.Supplier.SupplierPhone;

            return procurement;

        }

        public override Model.Procurements Insert(ProcurementsInsertRequest request)
        {
            Database.Procurements procurement = new Database.Procurements();
            procurement.ProcurementNumber = request.ProcurementNumber;
            procurement.ProcurementNote = request.ProcurementNote;
            procurement.ProcurementAccountAmount = request.ProcurementAccountAmount;
            procurement.ProcurementDate = request.ProcurementDate;
            procurement.ProcurementTax = request.ProcurementTax;
            procurement.SupplierId = request.SupplierId;
            procurement.WarehouseId = request.WarehouseId;
            procurement.UserId = request.UserId;
            _context.Procurements.Add(procurement);
            _context.SaveChanges();

            foreach(var item in request.Details)
            {
                Database.ProcurementDetails procdetail = new Database.ProcurementDetails();

                procdetail.ArticleId = item.ArticleId;
                procdetail.Amount = item.Amount;
                procdetail.Price = item.Price;
                procdetail.ProcurementId = procurement.ProcurementId;
                

                _context.ProcurementDetails.Add(procdetail);
                _context.SaveChanges();

            }
            

            return _mapper.Map<Model.Procurements>(procurement);



        }


    }
}
