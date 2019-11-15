namespace Hashdji.Software.Core.Exceptions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {

        }

        public NotFoundException(string msg)
            :base($"{msg} not found")
        {

        }
    }
}
