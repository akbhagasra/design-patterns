using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.PrototypeSpace
{
    public class Prototype : ICloneable
    {
        private string _id;
        private string _data;

        public void setId()
        {
            _id = Guid.NewGuid().ToString();
        }
        public string getId()
        {
            return _id;
        }
        public void setData()
        {
            // This method takes time to load the data
            _data = "Static data which takes time to load";
            Thread.Sleep(5000);
        }
        public string getData()
        {
            return _data;
        }

        public override string ToString()
        {
            return _id + " : " + _data;
        }

        public object Clone()
        {
            return this;
        }
    }
}
