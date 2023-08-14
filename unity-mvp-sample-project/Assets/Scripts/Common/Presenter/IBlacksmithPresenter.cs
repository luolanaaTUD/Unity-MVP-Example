﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.Presenter
{
    public interface IBlacksmithPresenter: IDisposable
    {
        void Addlives();
        void Greet();
        void Jump();
    }
}
