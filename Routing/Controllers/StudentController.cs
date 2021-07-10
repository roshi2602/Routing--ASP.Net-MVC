using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Routing.Models;
namespace Routing.Controllers
{
    public class StudentController : Controller
    {
        //make object for student list
        List<Student> st = new List<Student>()
        {
            //data in it
            new Student(){sid=1,sname="roshi",sroll=20},
             new Student(){sid=2,sname="payal",sroll=30},
              new Student(){sid=3,sname="vasu",sroll=40},
        };
        //now make 2 methods
        //HTTPGET and HTTPPOST attributes encode request parameters as key and value pairs in the HTTP request.
        //HTTP is a HyperText Transfer Protocol that is designed to send and receive the data between client and server using web pages.
        //To retrieve the information from the server.
        //syntax for http methods-[HttpGet],[HttpPost],HttpPut, HttpDelete, HttpOptions,HttpPatch   

        [HttpGet]
        [Route]          //using the concept of route prefix attribute
        public ActionResult GetStudent()
        {

            return View(st.ToList());
        }
        //link for this -https://localhost:44338/Student/GetStudent

        [HttpGet]
        [Route("{stuID}")]         //using the concept of route prefix attribute
        //RoutePrefix attribute is used to specify the common route prefix at the controller level to eliminate
        //the need to repeat that common route prefix on each and every controller action method
        public ActionResult GetStudentID(int stuID)   //giving 1 parameter as id to pass in url 
        {
            Student sd = st.FirstOrDefault(s => s.sid == stuID);
            return View(sd);
        }
        //link for this-https://localhost:44338/Student/GetStudentID?stuID=1


        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}


//HTTP METHODS
/*GET	To retrieve the information from the server. Parameters will be appended in the query string.
POST	To create a new resource.
PUT	To update an existing resource.
HEAD	Identical to GET except that server do not return the message body.
OPTIONS	It represents a request for information about the communication options supported by the web server.
DELETE	To delete an existing resource.
PATCH	To full or partial update the resource.
*/