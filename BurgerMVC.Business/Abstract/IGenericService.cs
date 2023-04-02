using System;
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
        T TGet(Expression<Func<T, bool>> filter);
        List<T> TGetList();
        List<T> TGetListByFilter(Expression<Func<T, bool>> filter);


    }
}
