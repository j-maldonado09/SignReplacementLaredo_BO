using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignReplacementLaredo.HelperModels
{
    public class WorkOrderItemHelperModel
    {
        public int ItemId { get; set; }
        //public int NIGPId { get; set; }
        public string NIGP { get; set; }
        public int Quantity { get; set; }
        public string SignImage { get; set; }
        public string Instructions { get; set; }
        public string SpecialInstructions { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
