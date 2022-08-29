using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BAL
{
    public class BALayer
    {

        DALayer obj = new DALayer();
        public void InsertData(int id, string name, string author, string publisher, decimal price)
        {
            obj.Insert(id, name, author, publisher, price);
        }

        public void DeleteData(int id)
        {
            obj.Delete(id);
        }

        public void UpdateData(int id, string name, string author, string publisher, decimal price)
        {
            obj.Update(id, name, author, publisher, price);
        }
    }
}
