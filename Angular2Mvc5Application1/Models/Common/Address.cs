using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Angular2Mvc5Application1.Models.Common
{
    public class Address
    {

        private string[] lines;
        public string Line1
        {
            get
            {
                if (lines.Length > 0)
                    return lines[0];
                return string.Empty;
            }
            set
            {
                if (lines.Length > 0)
                    lines[0] = value;
                else lines = new string[] { value };
            }
        }
        public string Line2
        {
            get
            {
                if (lines.Length > 1)
                    return lines[1];
                return string.Empty;
            }
            set
            {
                if (lines.Length > 1)
                    lines[1] = value;
                else lines = lines.Concat(new string[] { value }).ToArray(); 
            }
        }
        public string Line3
        {
            get
            {
                if (lines.Length > 2)
                    return lines[2];
                return string.Empty;
            }
            set
            {
                if (lines.Length > 2)
                    lines[2] = value;
                else lines = lines.Concat(new string[] { value }).ToArray();
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, lines);
        }

    }
}