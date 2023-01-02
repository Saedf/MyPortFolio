using Microsoft.AspNetCore.Mvc;
using MyPortFolio.Models;
using System.Diagnostics;

namespace MyPortFolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<PortFolio> _portFolios = new List<PortFolio>
        {
            new PortFolio()
            {
                Id = 1,
                Image = "01.jpg",
                Title = "KATANA",
                Description = "این اولین پروزه ی من بود"
            },
            new PortFolio()
            {
                Id = 2,
                Image = "02.jpg",
                Title = "پیام رسان",
                Description = "این دومین پروزه ی من بود"
            },
            new PortFolio()
            {
                Id = 3,
                Image = "03.jpg",
                Title = "شبکه های اجتماعی",
                Description = "این سومین پروزه ی من بود"
            },
            new PortFolio()
            {
                Id = 4,
                Image = "04.jpg",
                Title = "درخواست غذا",
                Description = "این جهارمین پروزه ی من بود"
            },
            new PortFolio()
            {
                Id = 5,
                Image = "05.jpg",
                Title = "درخواست غذا",
                Description = "این جهارمین پروزه ی من بود"
            },
            new PortFolio()
            {
                Id = 6,
                Image = "06.jpg",
                Title = "درخواست غذا",
                Description = "این جهارمین پروزه ی من بود"
            },
        };

        public IActionResult Index()
        {
            ViewData["headingTitle"] = "خوش آمدید";
            ViewData["headingText"] = "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.";


            return View(_portFolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "Saed.Fathi@gmail.com",
                GitHub = "Saed.Fathi",
                Mobile = "09124567780"
            };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}