namespace Model_2_Tast_2_Vasylchenlo
{
    public class Basket
    {
        private static readonly Basket _instance = new Basket();
        private readonly Product[] _arraProducts = new Product[15];
        private readonly CreateProducte _createProductes = new CreateProducte();
        private int _numbeInTheArrey = 0;

        static Basket()
        {
        }

        private Basket()
        {
        }

        public static Basket Instance() => _instance;

        public void SaveProducts(Product product)
        {
            _arraProducts[_numbeInTheArrey] = product;
            _numbeInTheArrey++;
        }

        public void DeleteProducts(Product product)
        {
            for (var i = 0; i < _arraProducts.Length; i++)
            {
                if (_arraProducts[i] == product)
                {
                    _arraProducts[i] = null;
                }
            }
        }

        public Product[] ShowProducts()
        {
            return _arraProducts;
        }

        public void SelectedProduct(int[] arrayNumberProduct)
        {
            var baseProducts = _createProductes.FillingProducts();
            foreach (Product product in baseProducts)
            {
                foreach (var numberProduct in arrayNumberProduct)
                {
                    if (product.Id == numberProduct)
                    {
                        SaveProducts(product);
                    }
                }
            }
        }

        public void DeleteProducts(int[] arrayNumberProduct)
        {
            foreach (Product product in _arraProducts)
            {
                foreach (var numberProduct in arrayNumberProduct)
                {
                    if (product != null)
                    {
                        if (product.Id == numberProduct)
                        {
                            DeleteProducts(product);
                        }
                    }
                }
            }
        }
    }
}
