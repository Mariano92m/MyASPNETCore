using MyCoreApplication.Core;
using System.Linq;
using System.Collections.Generic;

namespace MyCoreApplication.Data
{
    public class InMemoryBimboProductData : IBimboProductData
    {
        readonly List<BimboProduct> bimboProducts;

        public InMemoryBimboProductData()
        {
            bimboProducts = new List<BimboProduct>
            {
                new BimboProduct { Id=1, ProductName="Pan Artesano X 500", Price=82.00, Stock=true, ImgUrl="https://www.bimbo.com.mx/sites/default/files/product_bread_bimbo/Pan%20Artesano_0.png"},

                new BimboProduct { Id=2, ProductName="Liviano Acti Leche Chico X 400", Price=70.00, Stock=false, ImgUrl="https://www.bimbo.com.mx/sites/default/files/product_bread_bimbo/Pan%20Artesano_0.png"},
                new BimboProduct { Id=3, ProductName="Liviano Acti Leche Fliar X 730", Price=123.00, Stock=false, ImgUrl="https://www.bimbo.com.mx/sites/default/files/product_bread_bimbo/Pan%20Artesano_0.png"},

                new BimboProduct { Id=4, ProductName="Pan Integral X 350", Price=72.50, Stock=true, ImgUrl="http://www.bimbo.es/uploads/productos/es/natural_100_integral.png"},

                new BimboProduct { Id=5, ProductName="Pan Lino X 380", Price=72.50, Stock=false, ImgUrl="https://www.bimbo.com.mx/sites/default/files/product_bread_bimbo/Pan%20Artesano_0.png"},
                new BimboProduct { Id=6, ProductName="Pan Arabe X 230 GR.", Price=47.99 , Stock=false, ImgUrl="https://www.superama.com.mx/Content/images/products/img_large/0750103046438L.jpg"},

                new BimboProduct { Id=8, ProductName="Hamburg. Artesano 4U. X 240G", Price=84.00, Stock=true, ImgUrl="http://www.bimbo.es/uploads/productos/es/bollo_adaptado.png"},

                new BimboProduct { Id=7, ProductName="Pan Artesano c/semillas X 500", Price=124.99, Stock=false, ImgUrl="https://www.superama.com.mx/Content/images/products/img_large/0750103046438L.jpg"},         
                new BimboProduct { Id=9, ProductName="Pan Artesano X 400", Price=84.00, Stock=false, ImgUrl="https://www.superama.com.mx/Content/images/products/img_large/0750103046438L.jpg"},
                new BimboProduct { Id=10, ProductName="Pan Artesano X 400", Price=84.00, Stock=false, ImgUrl="https://www.superama.com.mx/Content/images/products/img_large/0750103046438L.jpg"}
            };
        }

        public IEnumerable<BimboProduct> GetAll()
        {
            return from bP in bimboProducts
                   orderby bP.ProductName
                   select bP;
        }
    }
}
