using System;
using System.Text;

namespace Model_2_Tast_2_Vasylchenlo
{
    public class WorkWithConsol
    {
        public void WriteLineMethod(string text)
        {
            Console.WriteLine(text);
        }

        public int[] ReadProduct()
        {
            string[] idNumbers = ReadLineComand().Split(' ');
            int[] id = new int[idNumbers.Length];
            for (var i = 0; i < idNumbers.Length; i++)
            {
                var temp = idNumbers[i];
                if (int.TryParse(temp, out var idProduct))
                {
                    id[i] = idProduct;
                }
            }

            return id;
        }

        public string ReadLineComand()
        {
            return Console.ReadLine();
        }

        public string NameProduct(Product[] arreyProduct)
        {
            StringBuilder nameProducts = new StringBuilder();

            foreach (Product product in arreyProduct)
            {
                if (product != null)
                {
                    nameProducts.AppendLine($"{product.Id}: {product.Name} {product.Price} {product.Currency}");
                }
            }

            return nameProducts.ToString();
        }
    }
}
