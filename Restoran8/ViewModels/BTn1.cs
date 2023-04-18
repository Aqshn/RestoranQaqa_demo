using Restoran8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran8.ViewModels
{
    public class BTn1
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public string? status { get; set; } = null;
        public DateTime? ReservTime { get; set; } = null;

        private static BTn1? _instance = null;

        private BTn1()
        {

        }

        public static BTn1 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn1();
            return _instance;
        }
        public void Clear()
        {
            garson = null;
            hesab = null;
            status = "free";
            ReservTime = null;
        }
    }
}
