using practiceproject.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Product
{
    internal class ProductRepo
    {
        private readonly string file = @"C:\Users\User\Desktop\pro.txt";
        public ProductRepo()
        {

        }
        public void SaveInFile(ProductModel product)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(product.ToString());
            }
        }
        public readonly string DbConnection = "Server=LocalHost;Database=PointOfSale;Trusted_Connection=True";
        public bool Create(ProductModel Product)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                string query = "INSERT INTO PRODUCT1 (name, description, purchaseprice, saleprice, discount)" +
                    "VALUES (@name, @description, @purchaseprice, @saleprice, @discount)";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@Id", Product.name);
                cmd.Parameters.AddWithValue("@name", Product.name);
                cmd.Parameters.AddWithValue("@description", Product.description);
                cmd.Parameters.AddWithValue("@purchaseprice", Product.purchaseprice);
                cmd.Parameters.AddWithValue("@saleprice", Product.saleprice);
                cmd.Parameters.AddWithValue("@discount", Product.discount);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                string query = "DELETE FROM PRODUCT1 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<ProductModel> GetAll()
        {
            List<ProductModel> products = new List<ProductModel>();
            using (SqlConnection conn = new SqlConnection(DbConnection))
            {
                string query = "SELECT Id, name, description, purchaseprice, saleprice, discount FROM PRODUCT1";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = reader["name"].ToString();
                        string description = reader["description"].ToString();
                        float purchaseprice = Convert.ToInt32(reader["purchaseprice"]);
                        float saleprice = Convert.ToInt32(reader["saleprice"]);
                        float discount = Convert.ToInt32(reader["discount"]);
                        ProductModel product = new ProductModel(id, name, description, purchaseprice, saleprice, discount);
                        products.Add(product);
                    }
                    reader.Close();
                }
                return products;
            
        }
                    //public readonly string DbConnection = "Server=LocalHost;Database=PointOfSale;Trusted_Connection=True";
                    public bool Update(ProductModel product)
                    {
            using (SqlConnection conn = new SqlConnection(DbConnection))
                          {
                            string query = "UPDATE PRODUCT1 SET name= @name, description=@description, purchaseprice=@purchaseprice, saleprice=@saleprice," +
                                " discount=@discount WHERE Id = @Id";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Id", product.Id);
                            cmd.Parameters.AddWithValue("@name", product.name);
                            cmd.Parameters.AddWithValue("@description", product.description);
                            cmd.Parameters.AddWithValue("@purchaseprice", product.purchaseprice);
                            cmd.Parameters.AddWithValue("@saleprice", product.saleprice);
                            cmd.Parameters.AddWithValue("@discount", product.discount);
                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

        public void SaveAllDataIntoFile(List<ProductModel> Products)
        {
            File.WriteAllText(file, "");
            foreach (ProductModel product in Products)
            {
                SaveInFile(product);
            }
        }
        public List<ProductModel> GetProductsFromFile()
        {
            List<ProductModel> productlist = new List<ProductModel>();
            using (StreamReader stream = new StreamReader(file))
            {
                string line = " ";
                while ((line = stream.ReadLine()) != null)
                {
                    if (line.Length > 5)
                    {
                        string[] parts = line.Split(',');

                        string productname = parts[0];
                        string desc = parts[1];
                        float purchaseprice = float.Parse(parts[2]);
                        float saleprice = float.Parse(parts[3]);
                        float discount = float.Parse(parts[4]);

                        ProductModel product = new ProductModel(productname, desc, purchaseprice, saleprice, discount);
                        productlist.Add(product);
                    }
                }
            }
            //Console.WriteLine("Total products are "+productlist.Count);
            return productlist;

        }
    }
}


    
