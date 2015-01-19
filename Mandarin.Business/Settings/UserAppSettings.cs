﻿namespace Mandarin.Business.Settings
{
    public class UserAppSettings : AppSettings
    {
        public string ActiveProfile { get; set; }

        public UserAppSettings()
        {
            ActiveProfile = "Default";
        }
    }
}
