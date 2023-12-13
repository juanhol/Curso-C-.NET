using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlTypes;

namespace Business
{
    public class ArticleBusiness //Data access methods for Articles in DB
    {
        List<Article> list = new List<Article>();
        DataAccess data = new DataAccess();

        public List<Article> toList()
        {
            try
            {
                data.SetQuery("select A.Id,A.Precio as Price,A.Codigo as ArticleCode,A.Nombre as Name, A.Descripcion as Description, A.ImagenUrl as imgUrl, M.Descripcion as Brand, M.Id as BrandId, C.Descripcion as Category, C.Id as CategoryId from ARTICULOS A, MARCAS M, CATEGORIAS C \r\nwhere A.IdMarca = M.Id And A.IdCategoria = C.Id");
                data.ExecuteQuery();
                while (data.Reader.Read())
                {
                    Article aux = new Article();
                    aux.Id = (int)data.Reader["Id"];
                    aux.price = (decimal)data.Reader["Price"];
                    aux.articleCode = (string)data.Reader["ArticleCode"];
                    aux.name = (string)data.Reader["Name"];
                    aux.description = (string)data.Reader["Description"];


                    if (!(data.Reader["imgUrl"] is DBNull))
                    { aux.imgUrl = (string)data.Reader["imgUrl"]; }


                    aux.brand = new Brand();
                    aux.category = new Category();
                    aux.brand.description = (string)data.Reader["Brand"];
                    aux.brand.brandId = (int)data.Reader["BrandId"];
                    aux.category.description = (string)data.Reader["Category"];
                    aux.category.categoryId = (int)data.Reader["CategoryId"];
                 
                    list.Add(aux);
                }

                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        

        public List<Category> getCategories()
        {
            List<Category> list = new List<Category>();
            DataAccess data = new DataAccess();
            try
            {
                data.SetQuery("select Descripcion as Description, Id  from CATEGORIAS");
                data.ExecuteQuery();
                while (data.Reader.Read())
                {
                    Category category = new Category();
                    category.description = (string)data.Reader["Description"];
                    category.categoryId = (int)data.Reader["Id"];
                    list.Add(category);
                }
                return list;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        public List<Brand> getBrands()
        {
            List<Brand> list = new List<Brand>();
            DataAccess data = new DataAccess();
            try
            {
                data.SetQuery("select Descripcion as Description, Id  from MARCAS");
                data.ExecuteQuery();
                while (data.Reader.Read())
                {
                    Brand brand = new Brand();
                    brand.description= (string)data.Reader["Description"];
                    brand.brandId = (int)data.Reader["Id"];
                    list.Add(brand);
                }
                return list;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        public void AddArticle(Article article)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.SetQuery("Insert into ARTICULOS(Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria,ImagenUrl) values(@ArticleCode, @Name, @Description, @Price, @BrandId,@CategoryId,@ImgUrl)");
                data.setParameter("@ArticleCode", article.articleCode);
                data.setParameter("@Name", article.name);
                data.setParameter("@Description", article.description);
                data.setParameter("@Price", article.price);
                data.setParameter("@BrandId", article.brand.brandId);
                data.setParameter("@CategoryId", article.category.categoryId);
                data.setParameter("@ImgUrl", article.imgUrl);
                data.executeNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        public void modifyArticle(Article article)
        {
            DataAccess data = new DataAccess();
            try
            {
                data.SetQuery("update ARTICULOS set Codigo=@ArticleCode, Nombre=@Name, Descripcion=@Description, Precio=@Price, IdMarca=@BrandId,IdCategoria=@CategoryId,ImagenUrl=@ImgUrl where Id=@Id");
                data.setParameter("@ArticleCode", article.articleCode);
                data.setParameter("@Name", article.name);
                data.setParameter("@Description", article.description);
                data.setParameter("@Price", article.price);
                data.setParameter("@BrandId", article.brand.brandId);
                data.setParameter("@CategoryId", article.category.categoryId);
                data.setParameter("@ImgUrl", article.imgUrl);
                data.setParameter("@Id", article.Id);
                data.executeNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeleteArticlePhisically(int id)
        {
            try
            {
                DataAccess data = new DataAccess();
                data.SetQuery("delete from ARTICULOS where Id=@Id");
                data.setParameter("@Id", id);
                data.executeNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        public List<Article> advancedFilter(string field, string criteria, string key)
        {
            List<Article> list = new List<Article>();
            DataAccess data = new DataAccess();
            try
            {
                string query = "select A.Id,A.Precio as Price,A.Codigo as ArticleCode,A.Nombre as Name, A.Descripcion as Description, A.ImagenUrl as imgUrl, M.Descripcion as Brand, M.Id as BrandId, C.Descripcion as Category, C.Id as CategoryId from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id And A.IdCategoria = C.Id And ";
                data.SetQuery(query);
                switch (field)
                {
                    case "Price":
                        switch (criteria)
                        {
                            case "Higher than":
                                query += "A.Precio > " + key;
                                    break;
                            case "Equal to":
                                query += "A.Precio = " + key;
                                break;
                            default:
                                query += "A.Precio < " + key;
                                break;

                        }
                        break;
                    case "Name":
                        {
                            switch (criteria)
                            {
                                case "Begins with":
                                    query += "A.Nombre like '" + key + "%'";
                                    break;
                                case "Contains":
                                    query += "A.Nombre like '%" + key + "%'";
                                    break;
                                default:
                                    query += "A.Nombre like '%" + key + "'";
                                    break;
                            }
                        }
                        break;
                    default:
                        {
                            switch (criteria)
                            {
                                case "Begins with":
                                    query += "A.Descripcion like '" + key + "%'";
                                    break;
                                case "Contains":
                                    query += "A.Descripcion like '%" + key + "%'";
                                    break;
                                default:
                                    query += "A.Descripcion like '%" + key + "'";
                                    break;
                            }
                        }
                        break;
                }

                data.SetQuery( query );
                data.ExecuteQuery();
                while (data.Reader.Read())
                {
                    Article aux = new Article();
                    aux.Id = (int)data.Reader["Id"];
                    aux.price = (decimal)data.Reader["Price"];
                    aux.articleCode = (string)data.Reader["ArticleCode"];
                    aux.name = (string)data.Reader["Name"];
                    aux.description = (string)data.Reader["Description"];


                    if (!(data.Reader["imgUrl"] is DBNull))
                    { aux.imgUrl = (string)data.Reader["imgUrl"]; }


                    aux.brand = new Brand();
                    aux.category = new Category();
                    aux.brand.description = (string)data.Reader["Brand"];
                    aux.brand.brandId = (int)data.Reader["BrandId"];
                    aux.category.description = (string)data.Reader["Category"];
                    aux.category.categoryId = (int)data.Reader["CategoryId"];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.CloseConnection();
            }
        }

        

    }
}
