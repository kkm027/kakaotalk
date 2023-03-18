﻿using Jamesnet.Wpf.Global.Location;
using Kakao.Friends.Local.ViewModels;
using Kakao.Friends.UI.Views;
using Kakao.Login.Local.ViewModels;
using Kakao.Login.UI.Views;

namespace Kakao.Settings
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
        }
    }
}
