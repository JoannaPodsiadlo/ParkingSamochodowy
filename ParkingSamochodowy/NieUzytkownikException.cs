using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSamochodowy
{
    public class NieUzytkownikException:Exception
    {
        public NieUzytkownikException()
        {
        }

        public NieUzytkownikException(string message) : base(message)
        {
        }

        public NieUzytkownikException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NieUzytkownikException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
