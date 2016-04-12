using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LectorQRv2.DAO
{
    interface IRepository<T> where T : class
    {
        //Interfqaz que establece las funciones necesarias para el manejo de datos
        IEnumerable<T> SelectAll(); //Función para seleccionar todos los registros
        IEnumerable<T> FindAll(Func<T, bool> exp); //Busca todos los registros que cumplan la condición exp (expresión lambda)
        T SelectSingle(Func<T, bool> exp); //Busca el PRIMER registro que cumpla la condición exp (expresión lambda)
        void Insert(T obj); //Inserta un onjeto
        void Update(Func<T, bool> exp, T obj); //Actualiza un objeto cumpla la condición (Solo debería usarse con un primary key o campo único)
        void Delete(Func<T, bool> exp); //Borra un objeto
        void SaveAll(); //Guarda todos los cambios
    }

    public class Repository<T> : IRepository<T> where T : class
    {
        //Clase que implementa la interfaz de arriba

        //Todos los métodos usan LINQ para el manejo de datos
        //Trabajan usando tipo genéricos

        protected Models.ParqueoDataModelDataContext context = new Models.ParqueoDataModelDataContext();

        public IEnumerable<T> SelectAll()
        {
            var query = from t in context.GetTable<T>()
                        select t;
            return query.AsEnumerable();
        }

        public IEnumerable<T> FindAll(Func<T, bool> exp)
        {
            var query = from t in context.GetTable<T>().Where(exp)
                        select t;
            return query.AsEnumerable();
        }

        public void SaveAll()
        {
            this.context.SubmitChanges();
        }

        public T SelectSingle(Func<T, bool> exp)
        {
            var query = (from t in context.GetTable<T>()
                         select t);
            if (query.Any(exp))
                return query.First(exp);
            else
                return null;
        }

        public void Insert(T obj)
        {
            this.context.GetTable<T>().InsertOnSubmit(obj);
        }

        void IRepository<T>.Update(Func<T, bool> exp, T obj)
        {
            T objUpdate = this.context.GetTable<T>().Where(exp).SingleOrDefault();
            objUpdate = obj;
        }

        public void Delete(Func<T, bool> exp)
        {
            T entity = SelectSingle(exp);
            this.context.GetTable<T>().DeleteOnSubmit(entity);
        }
    }
}
