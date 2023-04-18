using Restoran8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran8.ViewModels
{
    public class BTn3
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public string? status { get; set; } = null;
        public DateTime? ReservTime { get; set; } = null;

        private static BTn3? _instance = null;

        private BTn3()
        {

        }

        public static BTn3 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn3();
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
