﻿using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.DataLayer.Abstract;
using BurgerMVC.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.BusinessLayer.Concrete
{
    public class DessertManager : IDessertService
    {
        IDessertDal _dessertDal;

        public DessertManager(IDessertDal dessertDal)
        {
            _dessertDal = dessertDal;
        }

        public void TAdd(Dessert t)
        {
            _dessertDal.Insert(t);
        }

        public void TDelete(Dessert t)
        {
            _dessertDal.Delete(t);
        }

        public Dessert TGet(Expression<Func<Dessert, bool>> filter)
        {
            return _dessertDal.Get(filter);
        }
                
        public List<Dessert> TGetList(Dessert t)
        {
            return _dessertDal.GetList();
        }

        public List<Dessert> TGetListByFilter(Expression<Func<Dessert, bool>> filter)
        {
            return _dessertDal.GetListByFilter(filter);
        }
                
        public void TUpdate(Dessert t)
        {
            _dessertDal.Update(t);
        }
    }
}
