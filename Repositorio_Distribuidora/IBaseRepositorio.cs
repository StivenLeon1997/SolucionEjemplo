﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio_Distribuidora
{
    internal interface IBaseRepositorio<T> where T : class
    {
        /// <summary>
        /// The Insertar inserta una entidad sobre el modelo
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        void Insertar(T entidad);

        /// <summary>
        /// The Eliminar elimina una entidad sobre el modelo
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        void Eliminar(long id);

        /// <summary>
        /// The Filtrar Obtiene los registros que cumplan con la expresion Lambda
        /// </summary>
        /// <param name="expresion">The expresion<see cref="Expression{Func{T, bool}}"/></param>
        /// <returns>The <see cref="IQueryable"/></returns>
        IQueryable Filtrar(Expression<Func<T, bool>> expresion);

        /// <summary>
        /// The ObtenerPorId Obtiene los objetos que cumplan con el Id
        /// </summary>
        /// <param name="id">The id<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        T ObtenerPorId(string id);

        /// <summary>
        /// The ObtenerTodos Obtiene todos los objetos
        /// </summary>
        /// <returns>The <see cref="IQueryable"/></returns>
        IQueryable<T> ObtenerTodos();

        /// <summary>
        /// The Actualizar
        /// </summary>
        /// <param name="entidad">The entidad<see cref="T"/></param>
        void Actualizar(T entidad);

        /// <summary>
        /// The GuardarCambios guarda los cambios sobre le origen de datos
        /// </summary>
        void GuardarCambios();
    }
}
