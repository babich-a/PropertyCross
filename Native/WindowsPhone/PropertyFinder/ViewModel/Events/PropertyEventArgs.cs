﻿using System;
using PropertyFinder.Model;

namespace PropertyFinder.ViewModel
{
  public class PropertyEventArgs : EventArgs
  {
    public PropertyEventArgs(Property property)
    {
      Property = property;
    }

    public Property Property { private set; get; }
  }
}
