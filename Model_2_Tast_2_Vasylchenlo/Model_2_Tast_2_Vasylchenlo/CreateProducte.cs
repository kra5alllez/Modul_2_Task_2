using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_2_Tast_2_Vasylchenlo
{
    public class CreateProducte
    {
        private readonly Basket _basket = Basket.Instance();
        public Product[] FillingProducts()
        {
            Product item1 = new Product { Id = 1, Name = "Пылесос", Price = 1500, Currency = TypeCurrency.UA, ImagePath = "gffdgd" };
            Product item2 = new Product { Id = 2, Name = "Холодильник", Price = 8000, Currency = TypeCurrency.UA, ImagePath = "dsfhsdhf" };
            Product item3 = new Product { Id = 3, Name = "Телевизор", Price = 5000, Currency = TypeCurrency.UA, ImagePath = "dsfhsdhf" };
            Product item4 = new Product { Id = 4, Name = "Фен", Price = 1500, Currency = TypeCurrency.UA, ImagePath = "dsfouipdhf" };
            Product item5 = new Product { Id = 5, Name = "Миксер", Price = 1500, Currency = TypeCurrency.UA, ImagePath = "yupdsfhsdhf" };
            Product item6 = new Product { Id = 6, Name = "Микроволновка", Price = 2000, Currency = TypeCurrency.UA, ImagePath = "yidsfhsdhf" };
            Product item7 = new Product { Id = 7, Name = "Утюг", Price = 1700, Currency = TypeCurrency.UA, ImagePath = "dsgdsfhsdhf" };
            Product item8 = new Product { Id = 8, Name = "Электорочайник", Price = 900, Currency = TypeCurrency.UA, ImagePath = "dbdsfhsdhf" };
            Product item9 = new Product { Id = 9, Name = "Телефон", Price = 10000, Currency = TypeCurrency.UA, ImagePath = "hbdsfhsdhf" };
            Product item10 = new Product { Id = 10, Name = "Настольная лампа", Price = 500, Currency = TypeCurrency.UA, ImagePath = "asddsfhsdhf" };
            Product item11 = new Product { Id = 11, Name = "Ноутбук", Price = 20000, Currency = TypeCurrency.UA, ImagePath = "hyrdsfhsdhf" };
            Product item12 = new Product { Id = 12, Name = "Кондиционер", Price = 9000, Currency = TypeCurrency.UA, ImagePath = "hnddsfhsdhf" };
            Product item13 = new Product { Id = 13, Name = "Соковыжималка", Price = 1600, Currency = TypeCurrency.UA, ImagePath = "mhddsfhsdhf" };
            Product item14 = new Product { Id = 14, Name = "Стиральная машина", Price = 8000, Currency = TypeCurrency.UA, ImagePath = "hgnnsdsfhsdhf" };
            Product item15 = new Product { Id = 15, Name = "Обогреватель", Price = 2000, Currency = TypeCurrency.UA, ImagePath = "dgfndsfhsdhf" };
            Product item16 = new Product { Id = 16, Name = "Сушилка", Price = 1500, Currency = TypeCurrency.UA, ImagePath = "pidsfhsdhf" };

            Product[] productCatalog = { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16 };
            return productCatalog;
        }
    }
}
