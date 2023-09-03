using Dapper;
using GorselProgramlama.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama.Services
{
    public class DbService:IDisposable
    {
        IDbConnection conn;
        /// <summary>
        /// DbService oluşturulduğu anda bağlantının açılmasını sağlar.
        /// </summary>
        public DbService() {
            conn = new SqlConnection("data source=DESKTOP-3TJ90CS; initial catalog=SupplyManagement; integrated security=true;");
            conn.Open();
        }

        /// <summary>
        /// Verilen tipe göre sql deki tablo karşılığını bulur ve liste olarak döndürür.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<T> GetList<T>(string where="RowStateId<>3") where T : BaseEntity
        {
            try
            {
                List<T> result = conn.Query<T>($"Select * from {typeof(T).Name} where {where} and RowStateId<>3").ToList();

                return result;
            }
            catch(Exception ex)
            {
                LogService.CreateErrorLog(ex);
                return new List<T>();
            }
        }

        /// <summary>
        /// Verilen tipe göre where koşulunun içine yazılan sql cümlesiyle istenilen kayıt bulunur.Birden fazla aynı kayıt varsa bile ilk kayıtı döndürür.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="where"></param>
        /// <returns></returns>
        public T FirstOrDefault<T>(string where= "RowStateId<>3") where T : class
        {
            try
            {
                T result = conn.QuerySingleOrDefault<T>($"Select Top 1 * from {typeof(T).Name} where {where} and RowStateId<>3");
                return result;
            }
            catch (Exception ex)
            {
                LogService.CreateErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        /// Verilen tipe göre gönderilen modelin sqldeki karşılığı aranır eğer bulunmazsa yeni kayıt olarak ekler, bulursa da var olan kayıtı günceller.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void AddOrUpdateEntity<T>(T entity) where T : BaseEntity
        {
            try
            {
                var dbEntity = FirstOrDefault<T>($"{nameof(entity.Id)} = {entity.Id}");
                if (dbEntity == null)
                {
                    var sql = "INSERT INTO";
                    var sqlProps = $" {entity.GetType().Name}";
                    sqlProps += "(";
                    var sqlValues = " VALUES(";
                    var propList = typeof(T).GetProperties();
                    foreach (var prop in propList.Where(a => a.Name != "Id"))
                    {
                        sqlProps += $"{prop.Name},";
                        var propType = prop.PropertyType.Name;
                        if (propType == "Int" || propType == "Boolean" || propType == "Double" || propType == "Float" || propType == "Byte")
                        {
                            var value = prop.GetValue(entity);
                            sqlValues += $"{value},";
                        }
                        else
                        {
                            var value = prop.GetValue(entity);
                            sqlValues += $"'{value}',";
                        }
                    }
                    sqlProps = sqlProps.Substring(0, sqlProps.Length - 1);
                    sqlValues = sqlValues.Substring(0, sqlValues.Length - 1);
                    sqlValues += ")";
                    sqlProps += ")";
                    sql += sqlProps + sqlValues;
                    conn.Execute(sql);
                }
                else
                {
                    var sql = "UPDATE";
                    sql += $" {entity.GetType().Name}";
                    var sqlNewEntity = " SET";
                    var sqlOldEntity = " WHERE";
                    var propList = typeof(T).GetProperties();
                    foreach (var prop in propList.Where(a => a.Name != "Id"))
                    {
                        var sqlPropName = $"{prop.Name}";
                        var propType = prop.PropertyType.Name;
                        var newValue = prop.GetValue(entity);
                        var oldValue = prop.GetValue(dbEntity);
                        if (propType == "Int" || propType == "Boolean" || propType == "Double" || propType == "Float" || propType == "Byte")
                        {

                            sqlNewEntity += $" {sqlPropName}={newValue},";
                            sqlOldEntity += $" {sqlPropName}={oldValue} and";
                        }
                        else
                        {
                            sqlNewEntity += $" {sqlPropName}='{newValue}',";
                            sqlOldEntity += $" {sqlPropName}='{oldValue}' and";
                        }
                    }
                    sqlNewEntity = sqlNewEntity.Substring(0, sqlNewEntity.Length - 1);
                    sqlOldEntity = Extensions.WordTrimEnd(sqlOldEntity, "and");
                    sql = sql + sqlNewEntity + sqlOldEntity;
                    conn.Execute(sql);
                }

            }
            catch (Exception ex)
            {
                LogService.CreateErrorLog(ex);
            }
        }

        /// <summary>
        /// Gönderilen modelin RowStateId sini 3 yapar yani silinmiş durumuna getirir. Böylelikle kayıt listelenirken yada çağrılırken bu kayıt getirilmez.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        public void DeleteEntity<T>(T entity) where T : BaseEntity
        {
            entity.RowStateId = 3;
            AddOrUpdateEntity<T>(entity);
        }
        public void Dispose()
        {
            conn.Close();
        }
    }
}
