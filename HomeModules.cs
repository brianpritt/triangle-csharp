using Nancy;
using TrianglePage.Objects;

namespace Triangles
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/triangle-check"] = _ => {
        Triangle myTriangle = new Triangle(Request.Query["side-1"], Request.Query["side-2"], Request.Query["side-3"]);
        float sideOne = myTriangle.GetSideOne();
        float sideTwo = myTriangle.GetSideTwo();
        float sideThree = myTriangle.GetSideThree();

        if(sideOne + sideTwo >= sideThree && sideOne + sideThree >= sideTwo && sideTwo + sideThree >= sideOne && sideOne>0 && sideTwo >0 && sideThree >0)
        {
            if(sideOne == sideTwo && sideOne == sideThree)
            {
              myTriangle.SetTriangleType("equilateral");
            }
            else if(sideOne == sideTwo || sideOne == sideThree || sideTwo == sideThree)
            {
                myTriangle.SetTriangleType("Isosceles");
            }
            else if(sideOne != sideTwo && sideOne != sideThree && sideTwo != sideThree)
            {
                myTriangle.SetTriangleType("Scalene");
            }
              return View["triangle.cshtml", myTriangle];
          }else
          {
            myTriangle.SetTriangleType("not a triangle.");
            return View["triangle.cshtml", myTriangle];
          }
      //return View["triangle.cshtml", myTriangle];
      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
