using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTestArrays
{
  internal class Dog
  {
    private string name;
    private int age;
    private string color;

    //properties
    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Age
    {
      get { return age; }
      set { age = value; }
    }
    public string Color
    {
      get { return color; }
      set { color = value; }
    }
      
    public Dog(string name, int age,string color)
    {
      this.name = name;
      this.age = age;
      this.color = color;

    }
    public Dog()
    {
      name = "No tiene";
      age = 0;
      color = "Desconocido";
    }
    public override string ToString()
    {
      return "Nombre: " + name + " Edad: " + age + " Color: " + color;
    }
  }
}
