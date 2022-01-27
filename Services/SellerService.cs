using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoWebMVC.Models;
using ProjetoWebMVC.Data;

namespace ProjetoWebMVC.Services
{
    public class SellerService
    {
        private readonly ProjetoWebMVCContext _context;

        public SellerService(ProjetoWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
    }
}