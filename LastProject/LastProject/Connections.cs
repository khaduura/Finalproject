using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LastProject
{

    class Connections
    {
        
        //---this class has one fucntionlity only for holding database connection------------
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\khadra\\Desktop\\FinalExam\\LastProject\\DB\\FinalDB.accdb");
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataReader rd;
        public string qry;
    }
    /// <summary>
    /// /------hiden inside method as encapsulation 
    /// </summary>---------------------
    class proMethod
    {
        private string promo_form;
        private string forwad_app;
        private string prom_tile;
        private string prom_date;
        private string descrip;
        public string Promt_form
        {
            get { return promo_form; }
            set { promo_form = value; }

        }
        public string Forwad_app
        {
            get { return forwad_app; }
            set { forwad_app = value; }
        }
        public string   Prom_title
        {
            get { return promo_form; }
            set { prom_tile = value; }
        }
        public string Prom_date
        {
            get { return prom_date; }
            set { prom_date = value; }
        }
        public string Descrip
        {
            get { return descrip; }
            set { descrip = value; }
        }
       
    }
   /// <summary>
   ///---------------inherite from base class of connection -------------------------
   /// </summary>
    class TransferMethod:Connections
    {
        
        private string emtransfer;
        private string forwad_appliction;
        private string transfer_date;
        private string department;
        private string transfer_station;
        

        /// <summary>
        /// /-------showing important method as abstraction members/methods------------------
        /// </summary>
        public string Emtransfer
        {
            get { return emtransfer; }
            set { emtransfer = value; }
        }
        public string Forwad_appl
        {
            get { return forwad_appliction; }
            set { forwad_appliction = value; }
        }
        public string Transfer_date
        {
            get { return transfer_date; }
            set { transfer_date = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }

        }
        public string  Transfer_station
            {
            get { return transfer_station; }
            set { transfer_station = value; }
            }

        public static implicit operator TransferMethod(AchievmentConn v)
        {
            throw new NotImplementedException();
        }
    }
}

