﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T TGetByID(T t);
        T TGet(Expression<Func<T, bool>> filter);
        List<T> TGetList(T t);
        List<T> TList(Expression<Func<T, bool>> filter);


    }
}
