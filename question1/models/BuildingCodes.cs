using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question1.models
{
    public class BuildingCodes
    {
        public BuildingCodes() 
        {
        }
        public BuildingCodes(int _buildingId,string _buildingLocation, string _buildingCode)
        {
            BuildingId = _buildingId;
            BuildingLocation = _buildingLocation;
            BuildingCode = _buildingCode;
        }
        public int BuildingId { get; set; }
        public string BuildingLocation { get; set; }
        public string BuildingCode { get; set; }
    }
}
