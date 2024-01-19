using HotelGuestInteractionSystem.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Collections.Generic;

namespace HotelGuestInteractionSystem.Controllers
{
    public class RequestController : Controller
    {
        private static readonly List<RequestModel> Requests = new List<RequestModel>();
        private readonly IWebHostEnvironment _hostingEnvironment;

        public RequestController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View(Requests);
        }

        //This section handles the logic to raise a new request 
        [HttpPost]
        public IActionResult RaiseRequest(string userName, int room, string category, string description)
        {
            var request = new RequestModel
            {
                RequestId = Requests.Count + 1,
                RoomNo = room,
                GuestName = userName,
                RequestCategory = category,
                RequestDescription = description,
                RequestTimestamp = DateTime.Now,
                IsRequestCompleted = false
            };
            Requests.Add(request);
            return RedirectToAction("Index");
        }

        //This section lets a user mark a request completed
        [HttpPost]
        public IActionResult MarkRequestComplete(int reqId)
        {
            Requests[reqId].IsRequestCompleted = true;
            return RedirectToAction("Index");
        }

        public IActionResult StaffHomepage()
        {
            return View(Requests);
        }

        //This section lets a member of staff to mark a request completed
        [HttpPost]
        public IActionResult MarkRequestCompleteByStaff(int reqId)
        {
            Requests[reqId].IsRequestCompleted = true;
            return RedirectToAction("StaffHomepage");
        }


        public IActionResult SaveToTextFile()
        {
            string filePath = Path.Combine(_hostingEnvironment.ContentRootPath, "Output", "RequestList.txt"); 

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var item in Requests)
                {
                    // Assuming YourModel has properties named Property1, Property2, etc.
                    sw.WriteLine($"{item.RequestId}, {item.RoomNo}, {item.GuestName}, {item.RequestCategory}, {item.RequestDescription}, {item.RequestTimestamp}, {item.IsRequestCompleted}");
                }
            }

            return RedirectToAction("StaffHomepage");
        }
    }
}
