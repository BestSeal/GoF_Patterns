using System.Collections.Generic;

namespace Observer
{
    public class DB
    {
        public List<Report> Reports{ get; set; }

        public DB()
        {
            Reports = new List<Report>();
        }
    }
}