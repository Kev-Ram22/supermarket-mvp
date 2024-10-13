using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategorieRepository : BaseRepository, ICategoriesRepository
    {

        public CategorieRepository(string connectionString) { 
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Categories VALUES (@name, @Observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Categories WHERE Categorie_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Categories
                    SET Categorie_Name = @name,
                    Categorie_Observation = @observation
                    WHERE Categorie_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesModel.Name;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = categoriesModel.Observation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesModel.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categorieList = new List<CategoriesModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Category ORDER BY Category_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriemodel = new CategoriesModel();
                        categoriemodel.Id = (int)reader["Category_Id"];
                        categoriemodel.Name = reader["Category_Name"].ToString();
                        categoriemodel.Observation = reader["Category_Description"].ToString();
                        categorieList.Add(categoriemodel);
                    }
                }
            }
            return categorieList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categorieList = new List<CategoriesModel>();
            int categorieId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categorieName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Category
                                        WHERE Category_Id=@id or Category_Name LIKE @name+ '%'
                                        ORDER By Category_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categorieId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categorieName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categorieModel = new CategoriesModel();
                        categorieModel.Id = (int)reader["Category_Id"];
                        categorieModel.Name = reader["Category_Name"].ToString();
                        categorieModel.Observation = reader["Category_Description"].ToString();
                        categorieList.Add(categorieModel);
                    }
                }
            }
            return categorieList;
        }
    }
}
