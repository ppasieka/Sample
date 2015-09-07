using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sample.Models
{
    public class BoardModel
    {
        private IEnumerable<PointModel> _points;
        public IEnumerable<PointModel> Points 
        {
            get { return _points ?? Enumerable.Empty<PointModel>(); }
            set { _points = value; } 
        }
    }
}