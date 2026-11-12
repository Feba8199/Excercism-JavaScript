class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
public int ExpectedMinutesInOven() 
{
 return 40;
}

    // TODO: define the 'RemainingMinutesInOven()' method

public int RemainingMinutesInOven(int timeInOven) 
{
    return ExpectedMinutesInOven() - timeInOven;
}

    // TODO: define the 'PreparationTimeInMinutes()' method
public int PreparationTimeInMinutes(int layersForPizza)
{
    return layersForPizza * 2;
}

    // TODO: define the 'ElapsedTimeInMinutes()' method

  public int  ElapsedTimeInMinutes(int layersForPizza, int inTheOvenActualTime)
  {
    return PreparationTimeInMinutes(layersForPizza) + inTheOvenActualTime;
  }

}
