﻿using System.Collections.Generic;

namespace SGFP.Domain.Interfaces.Commom
{
    public interface IBaseRepository<T> where T : class
    {
       void add(object ob);

       bool Update(object ob);

       bool IdExist(int id);

       bool delete(int id);

       ICollection<T> GetAll();

       T getById(int id);

       bool Inativar(int id);

       bool Ativar(int id);
    }
}