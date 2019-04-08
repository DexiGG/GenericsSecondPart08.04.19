using System;
using System.Collections.Generic;
using System.Data.Common;

namespace GenericsSecondPart
{
    public abstract class AbstractDataAccessServices<T>:IDisposable
    {
        private readonly DbProviderFactory _factroy;
        private readonly DbConnection _connection;
        public AbstractDataAccessServices()
        {
            _factroy = DbProviderFactories.GetFactory("Имя провайдера");
            _connection = _factroy.CreateConnection();
            _connection.Open();
        }

        public abstract List<T> GetAll();
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);


        public void Dispose()
        {
            _connection.Close();
        }
    }
}
