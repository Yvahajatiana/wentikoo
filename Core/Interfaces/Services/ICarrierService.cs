namespace Hashdji.Software.Core.Interfaces.Services
{
    using Hashdji.Software.Core.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICarrierService
    {
        Task CreateCarrier(Carrier carrier);
    }
}
