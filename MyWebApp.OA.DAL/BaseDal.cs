﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebApp.OA.IDAL;
using MyWebApp.OA.Model;

namespace MyWebApp.OA.DAL
{
   public  class BaseDal<T> where T:class ,new()
    {
       OAEntities Db= new OAEntities();
        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>> whereLambda)
        {
            return Db.Set<T>().Where<T>(whereLambda);
        }

       /// <summary>
       /// 
       /// </summary>
       /// <typeparam name=" s>排序字段</typeparam>
       /// <param name="pageIndex">当前页</param>
       /// <param name="pageSize">条数</param>
       /// <param name="totalCount">总条数</param>
       /// <param name="whereLambda">过滤条件</param>
       /// <param name="orderbyLambda">排序条件</param>
       /// <param name="isAsc">是否升序</param>
       /// <returns></returns>
        public IQueryable<T> LoadPagedEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            var temp = Db.Set<T>().Where<T>(whereLambda);
            totalCount = temp.Count();
            if (isAsc)
            {
                temp = temp.OrderBy<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize)
                    .Take<T>(pageSize);
            }
            else
            {
                temp = temp.OrderByDescending<T, s>(orderbyLambda).Skip<T>((pageIndex - 1) * pageSize)
                    .Take<T>(pageSize);
            }
            return temp;
        }

        public bool DeleteEntity(T entity)
        {
            Db.Entry<T>(entity).State = System.Data.EntityState.Deleted;
            return Db.SaveChanges() > 0;

        }

        public bool UpdateEntity(T entity)
        {
            Db.Entry<T>(entity).State = System.Data.EntityState.Modified;
            return Db.SaveChanges() > 0;
        }

        public T AddEntity(T entity)
        {
            //Db.Entry<T>(entity).State = System.Data.EntityState.Added;
  
            Db.Set<T>().Add(entity);
            Db.SaveChanges();
            return entity;
        }
    }
}
