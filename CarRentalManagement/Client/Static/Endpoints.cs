using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        // Defines the prefix for all endpoints, api. Invisible to other classes.
        private static readonly string Prefix = "api";

        // Public static readonly endpoints for all 6 entities
        // An endpoint is a specific location within an API that accepts requests and sends back responses.
        // For example, when looking at the Makes, the MakesEndpoint is used.
        public static readonly string MakesEndpoint = $"{Prefix}/makes";
        public static readonly string ModelsEndpoint = $"{Prefix}/models";
        public static readonly string ColoursEndpoint = $"{Prefix}/colours";
        public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
    }
}