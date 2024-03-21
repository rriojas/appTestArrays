using static System.Runtime.InteropServices.JavaScript.JSType;

namespace appTestArrays
{
  public partial class Form1 : Form
  {
    //declare the array
    int[] myArray;
    int index;
    Dog[] myDogs;
    //declare a dog matrix 3x3
    Dog[,] myDogsMatrix = new Dog[3, 3];
    public Form1()
    {
      InitializeComponent();
      index = 0;
      myArray = new int[5];
      myDogs = new Dog[3];
      //create dogs into mydogs matrix with a loop
      for (int row = 0; row < myDogsMatrix.GetLength(0); row++)
      {
        for (int column = 0; column < myDogsMatrix.GetLength(1); column++)
        {
          myDogsMatrix[row, column] = new Dog();
        }
      }
      myDogsMatrix[2, 2].Name = "Firulais";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      //if the array is full, display a message
      if (index == myArray.Length)
      {
        //display the data in the array
        string data = "";
        for (int i = 0; i < myArray.Length; i++)
        {
          data += myArray[i] + " ";
        }
        MessageBox.Show("Array is full " + data);
        myArray = null;
        myArray = new int[3];
        index = 0;
        return;
      }
      try
      {
        myArray[index++] = Int32.Parse(txtNumber.Text);
      }
      catch (FormatException ex)
      {
        MessageBox.Show("Se requiere un numero ENTERO. Error de formato ");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message + " ");
      }

    }

    private void btnSaveDog_Click(object sender, EventArgs e)
    {
      if (index == myDogs.Length)
      {
        string data = "";
        for (int i = 0; i < myDogs.Length; i++)
        {
          data += myDogs[i] + " ";
        }
        MessageBox.Show("Array is full and the average age of your dogs is " + calculateAverageAge(myDogs) );
        return;
      }
      try
      {
        myDogs[index++] = new Dog(txtName.Text, Int32.Parse(txtAge.Text), txtColor.Text);
      }
      catch (FormatException ex)
      {
        MessageBox.Show("Se requiere un numero ENTERO. Error de formato ");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message + " ");
      }

    }

    private double calculateAverageAge(Dog[] myDogs)
    {
      double sum = 0;
      for (int i = 0; i < myDogs.Length; i++)
      {
        sum += myDogs[i].Age;
      }
      return sum / myDogs.Length;
      
    }
  }
}


