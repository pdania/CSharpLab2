﻿using System.ComponentModel;
using System.Windows;

namespace Lab1ParkhomenkoCSharp2019.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        Visibility LoaderVisibility { get; set; }
        bool IsControlEnabled { get; set; }
    }
}
