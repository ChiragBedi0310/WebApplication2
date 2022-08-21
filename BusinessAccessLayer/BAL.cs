using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessAccessLayer
{
    public class BAL
    {
        DAL obj = new DAL();
        
        public void InsertData(string id,string name,string city, string email)
        {
            obj.Insert(id,name,city,email);
        }

        public void DeleteData(string id)
        {
            obj.Delete(id);
        }

        public void UpdateData(string id, string name, string city, string email)
        {
            obj.Update(id, name, city, email);
        }
    }
}
