using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern_Exercise_2
{
    public interface IDataAccess
    {

        public void SaveData();
        public List<Product> LoadData();
    }
}
