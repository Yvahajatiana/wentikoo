namespace Hashdji.Software.Core.Services
{
    using Hashdji.Software.Core.Entities;
    using Hashdji.Software.Core.Interfaces.Repositories;
    using Hashdji.Software.Core.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class CarrierService : ICarrierService
    {
        private readonly ICarrierRepository carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
        {
            this.carrierRepository = carrierRepository;
        }

        public async Task CreateCarrier(Carrier carrier)
        {
            await carrierRepository.Create(carrier);
            await carrierRepository.SaveAsync();
        }
    }
}
