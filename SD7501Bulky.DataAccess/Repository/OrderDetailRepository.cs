using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;
using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }   
        public void Save()
        {
            _db.SaveChanges();
        }   
        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }

    }
}
