﻿namespace API.DataAccessLayer.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        T Create(T item);
        T Update(T item);
        int Delete(int id);
    }
}
