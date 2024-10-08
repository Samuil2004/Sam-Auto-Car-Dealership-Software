﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.InterfacesLL
{
    /// <summary>
    /// An interface used for Dependency Inversion
    /// </summary>
    public interface IStatisticsInterfaceLogicLayer
    {
        Dictionary<int, decimal> GetMontlyRevenue(DateTime currentYear);
        Dictionary<int, int> GetCarsProductionYear();
        List<int> GetAboveAndBelowAverageRatings();
        public List<int> GetNumberOfVehiclePerCategory();
    }
}
