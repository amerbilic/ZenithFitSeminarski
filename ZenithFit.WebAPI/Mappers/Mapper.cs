using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithFit.Model.Requests;

namespace ZenithFit.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            //Users
            CreateMap<Database.Users, Model.Users>();
            CreateMap<Database.Users, UsersInsertRequest>().ReverseMap();
            //Categories
            CreateMap<Database.Categories, Model.Categories>();
            CreateMap<Database.Categories, CategoriesInsertRequest>().ReverseMap();
            //Articles
            CreateMap<Database.Articles, Model.Articles>();
            CreateMap<Database.Articles, ArticlesUpsertRequest>().ReverseMap();
            //Warehouses
            CreateMap<Database.Warehouses, Model.Warehouses>();
            CreateMap<Database.Warehouses, WarehousesInsertRequest>().ReverseMap();
            //Manufacturers
            CreateMap<Database.Manufacturers, Model.Manufacturers>();
            CreateMap<Database.Manufacturers, ManufacturersInsertRequest>().ReverseMap();
            //Suppliers
            CreateMap<Database.Suppliers, Model.Suppliers>();
            CreateMap<Database.Suppliers, SuppliersUpsertRequest>().ReverseMap();
            //Clients
            CreateMap<Database.Clients, Model.Clients>();
            CreateMap<Database.Clients, ClientsInsertRequest>().ReverseMap();
            //Orders
            CreateMap<Database.Orders, Model.Orders>();
            CreateMap<Database.Orders, OrdersInsertRequest>().ReverseMap();
            //OrderDetails
            CreateMap<Database.OrderDetails, Model.OrderDetails>();
            CreateMap<Database.OrderDetails, OrderDetailsInsertRequest>().ReverseMap();
            //CompleteOrder
            CreateMap<Database.CompleteOrder, Model.CompleteOrder>();
            CreateMap<Database.CompleteOrder, CompleteOrderInsertRequest>().ReverseMap();
            CreateMap<Database.CompleteOrder, CompleteOrderUpdateRequest>().ReverseMap();
            //Procurements
            CreateMap<Database.Procurements, Model.Procurements>();
            CreateMap<Database.Procurements, ProcurementsInsertRequest>().ReverseMap();
            //ProcurementDetails
            CreateMap<Database.ProcurementDetails, Model.ProcurementDetails>();
            CreateMap<Database.ProcurementDetails, ProcurementDetailsInsertRequest>().ReverseMap();
            //UserRoles
            CreateMap<Database.UserRoles, Model.UserRoles>();
            //Roles
            CreateMap<Database.Roles, Model.Roles>();
            //Ratings
            CreateMap<Database.Ratings, Model.Ratings>();
            CreateMap<Database.Ratings, RatingsInsertRequest>().ReverseMap();
            //Goals
            CreateMap<Database.GoalsChoices, Model.GoalsChoices>();
            //
            CreateMap<Database.Messages, Model.Messages>();
            CreateMap<Database.Messages, MessagesInsertRequest>().ReverseMap();
            //
            CreateMap<Database.Comments, Model.Comments>();
            CreateMap<Database.Comments, CommentsInsertRequest>().ReverseMap();

        }
    }
}
