using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace YellowRose
{
    public class FormDataResponse
    {
        public int StatusCode { get; set; }
        public FormData? Data { get; set; }
        public string? Message { get; set; }
    }
}
