using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassProject.Models
{
    public class Directions
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Name { get; set; }
        public Directions(string origin, string destination, string name)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Name = name;
        }



    }
}