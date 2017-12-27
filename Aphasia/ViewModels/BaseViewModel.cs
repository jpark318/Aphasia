using System;
using MvvmCross.Core.ViewModels;
using Plugin.BLE.Abstractions.Contracts;

namespace Aphasia.Core.ViewModels {
    public class BaseViewModel : MvxViewModel {
        protected readonly IAdapter Adapter;
        protected const string DeviceIdKey = "DeviceIdNavigationKey";
        protected const string ServiceIdKey = "ServiceIdNavigationKey";
        protected const string CharacteristicIdKey = "CharacteristicIdNavigationKey";
        protected const string DescriptorIdKey = "DescriptorIdNavigationKey";

        public BaseViewModel(IAdapter adapter) {
            Adapter = adapter;
        }
    }
}
