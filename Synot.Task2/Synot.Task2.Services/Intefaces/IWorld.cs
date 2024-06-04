using Synot.Task2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synot.Task2.Services.Intefaces
{
    public interface IWorld
    {
        public List<BaseItem> ItemsInWorld { get; set; }
        void CreateWorld();
        List<BaseItem> FindNearby(BaseItem referencePoint, int distance);        
    }
}
