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
    public class ExtraManager : IExtraService
    {
        IExtraDal _extraDal;

        public ExtraManager(IExtraDal extraDal)
        {
            _extraDal = extraDal;
        }

        public void TAdd(Extra t)
        {
            _extraDal.Insert(t);
        }

        public void TDelete(Extra t)
        {
            _extraDal.Delete(t);
        }

        public Extra TGet(Expression<Func<Extra, bool>> filter)
        {
            return _extraDal.Get(filter);
        }

        public List<Extra> TGetList(Extra t)
        {
            return _extraDal.GetList();
        }

        public List<Extra> TGetListByFilter(Expression<Func<Extra, bool>> filter)
        {
            return _extraDal.GetListByFilter(filter);
        }

        public void TUpdate(Extra t)
        {
            _extraDal.Update(t);
        }
    }
}
