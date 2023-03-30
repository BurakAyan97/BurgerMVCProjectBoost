using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        T TGetByID(T t);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList();
        List<T> List(Expression<Func<T, bool>> filter);
        
        

    }
}
