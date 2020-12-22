
namespace Repositorio_Distribuidora
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the <see cref="BaseRepositorioSQL{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepositorioSQL<T> : IBaseRepositorio<T> where T : class
    {
        /// <summary>
        /// Defines the contexto
        /// </summary>
        internal DbContext contexto = new Datos_Distribuidora.BD_DistribuidoraEntities1();
        internal Datos_Distribuidora.BD_DistribuidoraEntities1 modelo = new Datos_Distribuidora.BD_DistribuidoraEntities1();

        /// <summary>
        /// Defines the dbSet
        /// </summary>
        protected DbSet<T> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepositorioSQL{T}"/> class.
        /// </summary>
        public BaseRepositorioSQL()
        {
            dbSet = contexto.Set<T>();
        }

        /// <summary>
        /// The Eliminar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Eliminar(long id)
        {
            try
            {
                T model = dbSet.Find(id);
                dbSet.Remove(model);
            }
            catch (Exception ex)
            {
                throw new Exception("Se presento un error." + " --> Parametros de generacion: idRol = " + id + " -->" + ex.Message + " - " + ex.StackTrace, ex.InnerException);
            }
        }

        /// <summary>
        /// The Filtrar
        /// </summary>
        /// <param name="expresion">The expresion<see cref="Expression{Func{T, bool}}"/></param>
        /// <returns>The <see cref="IQueryable"/></returns>
        public IQueryable Filtrar(Expression<Func<T, bool>> expresion)
        {
            return dbSet.Where(expresion);
        }

        /// <summary>
        /// The GuardarCambios
        /// </summary>
        public void GuardarCambios()
        {
            contexto.SaveChanges();
        }

        /// <summary>
        /// The Insertar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Insertar(T entidad)
        {
            try
            {
                dbSet.Add(entidad);
            }
            catch
            {
                contexto.Entry(entidad).State = EntityState.Added;
            }
        }

        /// <summary>
        /// The ObtenerPorId
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        public T ObtenerPorId(string id)
        {
            try
            {
                return dbSet.Find(Convert.ToInt64(id));
            }
            catch (Exception ex)
            {
                throw new Exception("Se presento un error." + " --> Parametros de generacion: idRol = " + id + " -->" + ex.Message + " - " + ex.StackTrace, ex.InnerException);
            }
        }

        /// <summary>
        /// The ObtenerTodos
        /// </summary>
        /// <returns>The <see cref="IQueryable"/></returns>
        public IQueryable<T> ObtenerTodos()
        {
            return dbSet;
        }

        /// <summary>
        /// The Actualizar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        public void Actualizar(T entidad)
        {
            contexto.Entry(entidad).State = EntityState.Modified;
        }
    }
}
