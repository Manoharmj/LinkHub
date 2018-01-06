using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UrlDb
    {

        private LinkHubDbEntities db;

        public UrlDb()
        {
            db = new LinkHubDbEntities();
        }

        public IEnumerable<tbl_Url> GetALL ()
        {
            return db.tbl_Url.ToList();
        }

        public tbl_Url GetById(int Id)
        {
            return db.tbl_Url.Find(Id);
        }

        public void Insert(tbl_Url Url)
        {
            db.tbl_Url.Add(Url);
            Save();
        }

        public void Delete(int Id)
        {
            tbl_Url url = db.tbl_Url.Find(Id);
            db.tbl_Url.Remove(url);
            Save();
        }

        public void Update(tbl_Url Url)
        {
            db.Entry(Url).State = EntityState.Modified;

        }

        public void Save()
        {
            db.SaveChanges();

        }








        //IEnumerable<tbl_Url> GetALL();

        //tbl_Url GetByID(int Id);

        //void Insert(tbl_Url url);
        //void Delete(int id);
        //void Update(tbl_Url url);
        //void Save();

    }
}
