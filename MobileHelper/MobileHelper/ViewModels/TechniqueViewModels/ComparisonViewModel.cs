﻿using MobileHelper.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobileHelper.ViewModels.TechniqueViewModels
{
    public class ComparisonViewModel : BaseViewModel
    {
        public ComparisonViewModel()
        {

        }

        public ComparisonViewModel(INavigation navigation)
        {
            Title = "Техника";
            Info = "Основной причиной любого беспокойства является завышенная важность. Поэтому её нужно уметь понижать. Сравнение важностей - один из способов уменьшить значимость того, что тревожит. По сути важность - сопутствуещее любого негатива, включая страх, неверие в себя, завышенную планку, сомнения и другое. Для выполнения этой техники достаточно сравнить то, что было важно в прошлом, важно в настоящем и будет важно в будущем относительно проблемы.";
            Finish = new Command(ToFinish);
            Theory = new Command(ToTheory);
            Navigation = navigation;
        }




    }
}
