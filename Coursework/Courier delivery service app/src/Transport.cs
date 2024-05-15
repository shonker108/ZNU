using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier_delivery_service_app.src
{
    public class Transport
    {
        public int? id;
        public int? courierId;
        public string? type;
        public string? number;

        public Transport(int? id, int? courierId, string? type, string? number)
        {
            this.id = id;
            this.type = type;
            this.number = number;
        }
    }
}
