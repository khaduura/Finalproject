using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LastProject
{
 public   class AchievmentConn
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\khadra\\Desktop\\FinalExam\\LastProject\\DB\\FinalDB.accdb");
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataReader rd;
        public string qry;
    }
}
