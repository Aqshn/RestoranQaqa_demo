using Restoran8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran8.ViewModels
{
    public class BTn4
    {
        public Garson? garson { get; set; }
        public float? hesab { get; set; }
        public string? status { get; set; } = null;
        public DateTime? ReservTime { get; set; } = null;

        private static BTn4? _instance = null;

        private BTn4()
        {

        }

        public static BTn4 GetInstance()
        {
            if (_instance == null)
                _instance = new BTn4();
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
