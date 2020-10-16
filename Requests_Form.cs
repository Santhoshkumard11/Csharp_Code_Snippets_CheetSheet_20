//to get all the keys and values from the request body

var dictionary = new Dictionary<string, object>();
Request.Form.CopyTo(dictionary);



// redirect users to the url where they came from
//Controller:
public ActionResult Index()
{
   ViewBag.Referrer = Request.UrlReferrer.LocalPath;
   //.....
   return View();
}

//View (Razor syntax):

<a href="@ViewBag.Referrer">Back</a>
