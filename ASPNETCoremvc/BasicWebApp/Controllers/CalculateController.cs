namespace Services;

public class CalculateController : Controller
{
     public IActionResult Cal(double p , double r, double n,[FromServices] Services.SimpleInt Interest)
     { 
         ViewBag.SI =Interest.Interest(p, r, n);
        return View("Interest");
     }  
   
    
}
