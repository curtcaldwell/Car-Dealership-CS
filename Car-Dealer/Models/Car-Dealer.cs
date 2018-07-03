using System;
using System.Collections.Generic;

namespace CarDealer.Models
{
  public class Cars
  {
    private string _makeModel;
    private string _color;
    private string _year;
    private string _price;
    private static List<Cars> _instances = new List<Cars> {};

    public Cars (string makeModel)
      {
        _makeModel = makeModel;
      }
      public string GetMakeModel()
      {
        return _makeModel;
      }
      public void SetMakeModel(string newMakeModel)
      {
        _makeModel = newMakeModel;
      }
      public string GetColor()
      {
        return _color;
      }
      public void SetColor(string newColor)
      {
        _color = newColor;
      }
      public string GetYear()
      {
        return _year;
      }
      public void SetYear(string newYear)
      {
        _year = newYear;
      }
      public string GetPrice()
      {
        return _price;
      }
      public void SetPrice(string newPrice)
      {
        _price = newPrice;
      }
      public static List<Cars> GetAll()
      {
        return _instances;
      }
      public void Save()
      {
        _instances.Add(this);
      }
  }
}
