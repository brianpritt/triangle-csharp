namespace TrianglePage.Objects
{
  public class Triangle{
    private float _sideOne;
    private float _sideTwo;
    private float _sideThree;
    public string _triangleType;


    public Triangle(float triSideOne, float triSideTwo, float triSideThree){
        _sideOne = triSideOne;
        _sideTwo = triSideTwo;
        _sideThree = triSideThree;

    }
    public void SetSideOne(float NewSideOne)
    {
      _sideOne = NewSideOne;
    }
    public float GetSideOne()
    {
      return _sideOne;
    }

    public void SetSideTwo(float NewSideTwo)
    {
      _sideTwo = NewSideTwo;
    }
    public float GetSideTwo()
    {
      return _sideTwo;
    }

    public void SetSideThree(float NewSideThree)
    {
      _sideThree = NewSideThree;
    }
    public float GetSideThree()
    {
      return _sideThree;
    }

    public void SetTriangleType(string NewTriangleType)
    {
      _triangleType = NewTriangleType;
    }
    public string GetTriangleType()
    {
      return _triangleType;
    }

  }
}
