namespace Model_2_Tast_2_Vasylchenlo
{
    public class Actions
    {
        private readonly CreateProducte _product;
        private readonly WorkWithConsol _writeAndReed;
        private readonly Basket _basket;
        private readonly Order _order;
        private readonly string _chooseProduct = "Выберите товар введя его номер в консоль. Делайте это череза пробел";
        private readonly string _commandList = "Хотите удалить(delete) или добавить(add) еще товар? \n Перейти к офформлению заказа(order)? \n Введите команду";
        private readonly string _addNumberProduct = "Выберите номер товара : ";
        private readonly string _deleteProduct = "Напишите номер продукта который хотите удалить :";
        private readonly string _orderCommand = "Для обратной связи ввведите свое имя и через пробер почту или номер телефона";
        private readonly string _selectProduct = "Выбранные товары :";
        private readonly string _wrongData = "Данные ввеены не верно. Попробуйте еще раз.";

        public Actions()
        {
            _product = new CreateProducte();
            _writeAndReed = new WorkWithConsol();
            _basket = Basket.Instance();
            _order = new Order();
        }

        public void Run()
        {
            _writeAndReed.WriteLineMethod(_writeAndReed.NameProduct(_product.FillingProducts()));
            _writeAndReed.WriteLineMethod(_chooseProduct);
            _basket.SelectedProduct(_writeAndReed.ReadProduct());
            _writeAndReed.WriteLineMethod(_selectProduct);
            _writeAndReed.WriteLineMethod(_writeAndReed.NameProduct(_basket.ShowProducts()));
            _writeAndReed.WriteLineMethod(_commandList);
            ThreeCommands(_writeAndReed.ReadLineComand());
        }

        public void ThreeCommands(string choiceComand)
        {
            switch (choiceComand)
            {
                case "add":
                    _writeAndReed.WriteLineMethod(_addNumberProduct);
                    _basket.SelectedProduct(_writeAndReed.ReadProduct());
                    _writeAndReed.WriteLineMethod(_selectProduct);
                    _writeAndReed.WriteLineMethod(_writeAndReed.NameProduct(_basket.ShowProducts()));
                    _writeAndReed.WriteLineMethod(_commandList);
                    ThreeCommands(_writeAndReed.ReadLineComand());
                    break;
                case "delete":
                    _writeAndReed.WriteLineMethod(_deleteProduct);
                    _basket.DeleteProducts(_writeAndReed.ReadProduct());
                    _writeAndReed.WriteLineMethod(_selectProduct);
                    _writeAndReed.WriteLineMethod(_writeAndReed.NameProduct(_basket.ShowProducts()));
                    _writeAndReed.WriteLineMethod(_commandList);
                    ThreeCommands(_writeAndReed.ReadLineComand());
                    break;
                case "order":
                    _writeAndReed.WriteLineMethod(_orderCommand);
                    _writeAndReed.WriteLineMethod(_order.CreateOrder(_writeAndReed.ReadLineComand()));
                    break;
                default:
                    _writeAndReed.WriteLineMethod(_wrongData);
                    _writeAndReed.WriteLineMethod(_commandList);
                    ThreeCommands(_writeAndReed.ReadLineComand());
                    break;
            }
        }
    }
}
