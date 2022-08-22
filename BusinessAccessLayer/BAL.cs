using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

        public bool UpdateData(string id, string name, string city, string email)
        {
            if(obj.Update(id, name, city, email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ShowData()
        {
            return obj.Show();
            
        }
    }
}
