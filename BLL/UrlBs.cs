﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class UrlBs
    {
        private UrlDb objDb;

        public UrlBs()
        {

            objDb = new UrlDb();

        }

        public IEnumerable<tbl_Url> GetALL()
        {

            return objDb.GetALL();
        }

        public tbl_Url GetById(int Id)
        {
            return objDb.GetById(Id);
        }
        public void Insert(tbl_Url url)
        {
            objDb.Insert(url);
        }

        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }

        public void Update(tbl_Url url)
        {
            objDb.Update(url);
        }










    }
}
