﻿
using MyWebApp.OA.DALFactory;
using MyWebApp.OA.IDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyWebApp.OA.BLL
{
    public abstract class BaseService<T> where T:class,new ()
    {
        public IDBSession DbSession
        {
            // get { return new DBSession(); }
            get { return DBSessionFactory.CreateDbSession(); }
        }

        public IBaseDal<T> CurrentDal { get; set; }//获取当前数据操作类
            
        public abstract void SetCurrentDal();

        public BaseService()
        {
            SetCurrentDal();
        }

        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
           return  this.CurrentDal.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPagedEntities<s>(int pageIndex, int pageSize, out int totalCount,
            System.Linq.Expressions.Expression<Func<T, bool>> whereLambda,
            System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda,
            bool isAsc)
        {
            return this.CurrentDal.LoadPagedEntities(pageIndex,pageSize,out totalCount,whereLambda,orderbyLambda,isAsc);
        }

        public bool DeleteEntity(T entity)
        {
            this.CurrentDal.DeleteEntity(entity);
            return this.DbSession.SaveChanges();
        }


        public bool UpdateEntity(T entity)
        {
            this.CurrentDal.UpdateEntity(entity);
            return this.DbSession.SaveChanges();
           
        }

        public T AddEntity(T entity)
        {
            this.CurrentDal.AddEntity(entity);
            this.DbSession.SaveChanges();
            return entity;
        }
    }
}