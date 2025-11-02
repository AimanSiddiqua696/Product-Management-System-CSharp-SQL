using practiceproject.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Product
{
    internal class ProductService
    {
        private ProductRepo _repo = new ProductRepo();

        public ProductService()
        {

        }
        public List<ProductModel> GetAllData()
        {
            return _repo.GetProductsFromFile();
        }
        public void SaveProduct(ProductModel product)
        {
            _repo.SaveInFile(product);
        }
        public ProductModel SearchByName(string name)
        {
            foreach (ProductModel product in _repo.GetProductsFromFile())
            {
                if (product.GetName() == name)
                {
                    return product;
                }
            }
            return null;
        }
        public bool UpdateProductPrice(string name, float saleprice)
        {
            List<ProductModel> productslist = _repo.GetProductsFromFile();
            foreach (var product in productslist)
            {
                if (product.GetName() == name)
                {
                    product.SetSalePrice(saleprice);
                    _repo.SaveAllDataIntoFile(productslist);
                    return true;
                }
            }
            return false;
        }
        public bool DeleteProduct(string name)
        {
            List<ProductModel> products = _repo.GetProductsFromFile();
            int count = 0;
            foreach (var product in products)
            {
                if (product.GetName() == name)
                {
                    products.RemoveAt(count);
                    _repo.SaveAllDataIntoFile(products);

                }
                count++;
            }
            return false;
        }

        public List<ProductModel> SearchProductByName(string name)
        {

            List<ProductModel> allproduct = _repo.GetProductsFromFile();
            List<ProductModel> filterProducts = new List<ProductModel>();
            foreach (var product in allproduct)
            {
                if (product.GetName() == name)
                {
                    filterProducts.Add(product);

                }
            }
            return filterProducts;
        }
        public List<ProductModel> SearchProductByPrice(float price)
        {
            List<ProductModel> AllPrice = _repo.GetProductsFromFile();
            List<ProductModel> filteredprice = new List<ProductModel>();
            foreach (ProductModel saleprice in AllPrice)
            {
                if (saleprice.GetSalePrice() == price)
                {
                    filteredprice.Add(saleprice);
                }
            }
            return filteredprice;
        }
        public List<ProductModel> PriceRange(float minprice, float maxprice)
        {
            List<ProductModel> PriceRange = _repo.GetProductsFromFile();
            List<ProductModel> filteredprice = new List<ProductModel>();
            foreach (ProductModel saleprice in PriceRange)
            {
                if ((saleprice.GetSalePrice() >= minprice) && (saleprice.GetSalePrice() <= maxprice))
                {
                    filteredprice.Add(saleprice);
                }
            }
            return filteredprice;
        }
        public List<ProductModel> PriceDifference(int price)
        {
            List<ProductModel> PriceDiff = _repo.GetProductsFromFile();
            List<ProductModel> FilteredPrice = new List<ProductModel>();
            foreach (ProductModel diff in PriceDiff)
            {
                if (((diff.GetSalePrice()) - (diff.GetPurchasePrice()) == price))
                {
                    FilteredPrice.Add(diff);
                }
            }
            return FilteredPrice;
        }
        public List<ProductModel> SubString(char target)
        {

            List<ProductModel> product = _repo.GetProductsFromFile();
            List<ProductModel> filteredchar = new List<ProductModel>();
            foreach (ProductModel substring in product)
            {
                string name = substring.GetName();
                if (substring.GetName() == name)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (name[i] == target)
                        {
                            filteredchar.Add(substring);
                        }
                    }
                }
                //return filteredchar;
            }
            //return null;
            return filteredchar;
        }
    }
}