using System;
using System.Collections.Generic;

namespace TruckRentalManagement.DataAccessLayer.DB
{
    public partial class TruckFeature
    {
        public TruckFeature()
        {
            TruckFeatureAssociation = new HashSet<TruckFeatureAssociation>();
        }

        public int FeatureId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TruckFeatureAssociation> TruckFeatureAssociation { get; set; }
    }
}
