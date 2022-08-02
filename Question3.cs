using System;

public class Star
{
    //Write the code here
    double shineFactor;
    public string Name { get; set; }
    bool fadeOut = true;
    public static void Main(string[] args)
    {
        // Code for debugging the test case NewStarsCanShine
        double shineFactor = 1d;
        Star star = new Star(shineFactor);
        Console.WriteLine($"Are equal: {object.Equals(shineFactor, star.Shine())},expected: {shineFactor}, actual: {star.Shine()}");
    }
    public Star(double shineFactor)
    {

        this.shineFactor = shineFactor;
    }
    public double Shine()
    {
        if (!fadeOut)
            throw new InvalidOperationException();
        return shineFactor;
    }
    public void FadeOut()
    {
        fadeOut = false;
        //shineFactor=0;
    }
}