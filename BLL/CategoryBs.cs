using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;

namespace BLL
{
    public class CategoryBs
    {

        private CategoryDb objDb;

        public CategoryBs()
        {
            objDb = new CategoryDb();
        }

        public IEnumerable<tbl_Category> GetALL()
        {

            return objDb.GetALL();
        }

        public tbl_Category GetById(int Id)
        {
            return objDb.GetById(Id);
        }
        public void Insert(tbl_Category category)
        {
            objDb.Insert(category);
        }

        public void Delete(int Id)
        {
            objDb.Delete(Id);
        }

        public void Update(tbl_Category category)
        {
            objDb.Update(category);
        }
    }
}
