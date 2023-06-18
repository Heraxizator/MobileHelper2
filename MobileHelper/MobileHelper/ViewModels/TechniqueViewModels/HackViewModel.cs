﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileHelper.ViewModels.TechniqueViewModels
{
    public class HackViewModel : BaseViewModel
    {
        public HackViewModel()
        {

        }
        public HackViewModel(INavigation navigation)
        {
            Title = "Техника";
            Navigation = navigation;
            Theory = new Command(ToTheory);
            Info = "Этот обработчик сносит абсолютно любые привязанности, зависимости, привычки, связи как с живыми объектами так и не живыми. С помощью этого обработчика можно обрабатывать любые привычки: грызть ногти, курение, и т.п. Любые зависимости и привязанности от любых материальных вещей, предметов, всего того что для вас имеет ценность, важность и значимость; все то что создает страх потери чего –либо как части себя Любые привязанности к людям, друзьям, родным, домашним животным, любым иным существам Любые привязанности к любым образам, маскам, частям личности, эго, самому себе Такие привязанности как к родному дому, месту, мечте, цели… В общем, применим ко всему, что создает зависимость/привязанность/привычку/связь.";
        }
    }
}
;