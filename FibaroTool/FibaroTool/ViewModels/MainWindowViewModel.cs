﻿using Prism.Mvvm;
using Prism.Regions;

namespace FibaroTool.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager regionManager;

        public MainWindowViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }
    }
}
