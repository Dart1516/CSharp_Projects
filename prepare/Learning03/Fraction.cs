/// Create the Fraction class
/// Create a class to hold fraction.
///The class should be in its own file.
///The class should have two attributes for the top and bottom numbers.
/// Make sure the attributes are private
public class Fraction 
{
    private int _top;
    private int _bottom;

// Create the Constructors
//Constructor that has no parameters that initializes the number to 1/1.
//Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
//Constructor that has two parameters, one for the top and one for the bottom.
    public  Fraction()    
    {
        _top= 1;
        _bottom= 1 ;
        
    }
    public  Fraction(int wholeNumber)
    {
        _top= wholeNumber;
        _bottom= 1 ;


    }

    public Fraction (int topNumber, int bottomNumber)
    {
        _top= topNumber;
        _bottom= bottomNumber ;

    }

    /// <Create getters and setters for both the top and the bottom values.

    public int GetTop()
    {
        return _top;
    }

    public void setTop(int topNumber)
    {
        _top = topNumber;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void setBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }
//Create a method called GetFractionString that returns the fraction in the form 3/4.

    public string getFractionString()
    {   
        return Convert.ToString(_top/_bottom);
    }
//Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75
     public double getDecimalValue()
    {   
        return Convert.ToDouble(_top/_bottom);
    }
   
        public double getDecimalValueButGood()
    {   
        double top = Convert.ToDouble(_top);
        double bottom = Convert.ToDouble(_bottom);
        return top/bottom;
    }
}