using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproject.Product
{
    internal class ProductModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float purchaseprice { get; set; }
        public float saleprice { get; set; }
        public float discount { get; set; }
        public ProductModel()
        {

        }
        public ProductModel(int Id, string name, string description, float purchaseprice, float saleprice, float discount)
        {
            this.Id = Id;
            this.name = name;
            this.description = description;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;
        }
        public ProductModel(string name, string description, float purchaseprice, float saleprice, float discount)
        {
            this.name = name;
            this.description = description;
            this.purchaseprice = purchaseprice;
            this.saleprice = saleprice;
            this.discount = discount;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public string GetDescription()
        {
            return this.description;
        }
        public void SetPurchasePrice(float purchaseprice)
        {
            this.purchaseprice = purchaseprice;
        }
        public float GetPurchasePrice()
        {
            return this.purchaseprice;
        }
        public void SetSalePrice(float saleprice)
        {
            this.saleprice = saleprice;
        }
        public float GetSalePrice()
        {
            return this.saleprice;
        }
        public float GetDiscount()
        {
            return this.discount;
        }
        public override string ToString()
        {
            return $"{name},{description},{purchaseprice},{saleprice},{discount}";
        }
    }
}
