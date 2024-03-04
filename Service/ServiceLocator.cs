using System;
using Microsoft.Extensions.DependencyInjection;

namespace AccommodationManagerApp.Service {
    public class ServiceLocator {
        private static ServiceProvider _serviceProvider { get; set; } = null;

        private ServiceLocator() { }

        public static ServiceProvider ServiceProvider {
            get {
                if (_serviceProvider == null) {
                    throw new Exception("ServiceLocator must be initialized");
                }

                return _serviceProvider;
            }
        }

        public static void Initialize(ServiceProvider serviceProvider) {
            _serviceProvider = serviceProvider;
        }
    }
}