﻿
using System;
using PropertyFinder.Model;
using System.Net;


namespace PropertyFinder.ViewModel
{
  /// <summary>
  /// A search against a plain-text string
  /// </summary>
  public class PlainTextSearchItem : SearchItemBase
  {
    public string SearchText { get; set; }

    public PlainTextSearchItem()
    {
    }

    public PlainTextSearchItem(string text)
    {
      DisplayText = SearchText = text;
    }

    public PlainTextSearchItem(string searchText, string displayText)
    {
      DisplayText = displayText;
      SearchText = searchText;
    }

    public override void FindProperties(PropertyDataSource dataSource,
      int pageNumber, Action<PropertyDataSourceResult> callback, Action<Exception> error)
    {
      dataSource.FindProperties(SearchText, 1, callback, error);
    }
  }
}
