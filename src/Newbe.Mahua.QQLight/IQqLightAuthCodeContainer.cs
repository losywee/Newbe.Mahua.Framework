﻿namespace Newbe.Mahua.QQLight
{
    public interface IQqLightAuthCodeContainer
    {
        string AuthCode { get; set; }

        void Save();

        void Load();
    }
}
