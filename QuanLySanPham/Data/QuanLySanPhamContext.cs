using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLySanPham.Models;

namespace QuanLySanPham.Data
{
    public class QuanLySanPhamContext : DbContext
    {
        public QuanLySanPhamContext (DbContextOptions<QuanLySanPhamContext> options)
            : base(options)
        {
        }

        public DbSet<QuanLySanPham.Models.Catalog> Catalog { get; set; } = default!;
        public DbSet<QuanLySanPham.Models.Product> Product { get; set; } = default!;
    }
}
