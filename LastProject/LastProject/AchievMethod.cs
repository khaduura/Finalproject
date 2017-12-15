using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace LastProject
{
    class AchievMethod
    {
        private string employee;
        private string forwad_appliction;
        public string achivement_title;
        public string achivemnet_date;
        public string Empolyee
        {
            get { return employee; }
            set { employee =value; }
        }
        public string Forward_application
        {
            get { return forwad_appliction; }
            set { forwad_appliction =value; }
        }
        public string Achivment_title
        {
            get { return achivement_title; }
            set { achivement_title = value; }
        }
        public string Achiveivment_date
        {
            get { return Achiveivment_date; }
            set { achivemnet_date = value; }
        }
    }
}
