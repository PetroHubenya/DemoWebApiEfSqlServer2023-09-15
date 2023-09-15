using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Helpers
{
    public class BoxHelper
    {
        private List<Box> Boxes = new List<Box>()
        {
            new Box()
            {
                Id = 1,
                Name = "Box1"
            },
            new Box()
            {
                Id = 2,
                Name = "Box2"
            }
        };

        public List<Box> GetBoxes()
        {
            return Boxes;
        }
        

        
    }
}
