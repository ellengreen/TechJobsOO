using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        //All columns, for display
        public List<JobFieldType> Columns { get; set; }

        //View title
        public string Title { get; set; } = "";

        public BaseViewModel()
        {
            //Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach(JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
