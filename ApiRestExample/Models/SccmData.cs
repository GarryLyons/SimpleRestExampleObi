using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiRestExample.Models
{
    public class SccmData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SccmDataRequest
    {
        public SccmData Data { get; set; }
    }


    public class SccmDataResponse
    {
        public bool Success { get; set; }

        private List<string> _errors;

        public List<string> Errors
        {
            get
            {
                if (_errors==null)
                {
                    _errors = new List<string>();
                }

                return _errors;
            }
            set { _errors = value; }
        }

    }
}