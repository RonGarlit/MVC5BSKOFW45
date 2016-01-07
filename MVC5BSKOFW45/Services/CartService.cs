using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MVC5BSKOFW45.EFDAL;
using MVC5BSKOFW45.Models;


namespace MVC5BSKOFW45.Services
{
    public class CartService : IDisposable
    {
        private EFDataContext _db = new EFDataContext();

        public Cart GetBySessionId(string sessionId)
        {
            var cart = _db.Carts.
                Include("CartItems").
                Where(c => c.SessionId == sessionId).
                SingleOrDefault();

            cart = CreateCartIfItDoesntExist(sessionId, cart);

            return cart;
        }

        private Cart CreateCartIfItDoesntExist(string sessionId, Cart cart)
        {
            if (null == cart)
            {
                cart = new Cart
                {
                    SessionId = sessionId,
                    CartItems = new List<CartItem>()
                };
                _db.Carts.Add(cart);
                _db.SaveChanges();
            }

            return cart;
        }

        public Cart GetById(int id)
        {
            var cart = _db.Carts.
                Include("CartItems").
                Include("CartItems.Book").
                Include("CartItems.Book.Author").
                Include("CartItems.Book.Category").
                Where(c => c.Id == id).
                SingleOrDefault();

            if (null == cart)
                throw new System.Data.Entity.Core.ObjectNotFoundException
                    (string.Format("Unable to find cart with id {0}", id));

            return cart;
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
