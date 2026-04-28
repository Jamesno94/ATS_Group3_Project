using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS_Group3_Project
{
    internal class JobRecord
    {
        public string jobId {  get; set; }
        public DateTime jobDate {  get; set; }
        public string jobTime { get; set; }
        public string farmId { get; set; }
        public string turbineId { get; set; }
        public string staffId { get; set; }
        public string jobType { get; set; }
        public string jobDescription { get; set; }
        public Boolean mainGenServiced { get; set; }
        public Boolean gearboxServiced { get; set; }
        public Boolean yawMotorServiced { get; set; }
        public Boolean liftServiced { get; set; }
        public Boolean mainGenReplaced { get; set; }
        public Boolean gearboxReplaced { get;set; }
        public Boolean yawMotorReplaced { get; set; }
        public Boolean liftReplaced { get; set; }
        public string jobStatus { get; set; }



    }
}
