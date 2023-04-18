using DenemeProje.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DenemeProje.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult veriler()
        {
            Random r = new Random();
            List<List<int>> liste = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                List<int> li = new List<int>();
                for (int j = 0; j < 5; j++)
                {                    
                    li.Add(r.Next());
                }
                liste.Add(li);
            }

            int count = 1;
            foreach (var item in liste)
            {
                ViewData["liste" + count] = item;
                count++;
;            }
            return View();
        }

        public IActionResult mveriler()
        {
            Random r = new Random();

            VeriModel veriModel = new VeriModel();
            veriModel.Liste = new List<List<int>>();    

            for (int i = 0; i < 10; i++)
            {
                List<int> li = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    li.Add(r.Next());
                }
                veriModel.Liste.Add(li);
            }

            
            return View(veriModel);
        }

        public IActionResult FormIslem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormIslem(FormIslemModel model)
        {
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}