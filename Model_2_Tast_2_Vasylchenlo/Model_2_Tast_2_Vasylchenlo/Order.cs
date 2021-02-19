using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_2_Tast_2_Vasylchenlo
{
    public class Order
    {
        private readonly int _minRandomAction = 1000;
        private readonly int _maxRandomAction = 10000;
        private readonly Basket _basket;
        private readonly Random _random;
        private readonly WorkWithConsol _writeandRead;
        private decimal _price = 0;

        public Order()
        {
            _basket = Basket.Instance();
            _random = new Random();
            _writeandRead = new WorkWithConsol();
        }

        public string CreateOrder(string dataOrder)
        {
            string[] s = dataOrder.Split(' ');
            var randomOder = _random.Next(_minRandomAction, _maxRandomAction);
            return $"\n{s[0]} ваш заказ под номером №{randomOder} сформирован \nВ него входит: \n{_writeandRead.NameProduct(_basket.ShowProducts())}" +
                $"Цена заказа {CostOrders(_basket.ShowProducts())} {TypeCurrency.UA}\nНаш оператор свяжется с вами в ближайшее время";
        }

        public decimal CostOrders(Product[] m)
        {
            foreach (Product p in m)
            {
                    if (p != null)
                    {
                        _price = _price + p.Price;
                    }
            }

            return _price;
        }
    }
}
