using App.Domain.Core.Advertise.Contracts.Repositories;
using App.Domain.Core.Advertise.Contracts.Services;
using App.Infra.Data.Repo.EF.Sql.Advertise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Advertise
{

    public class AdvertiseService : IAdvertiseService
    {
        private readonly IAdvertiseRepository _advertiseRepository = new AdvertiseRepository();
    }
}
