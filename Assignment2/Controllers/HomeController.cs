using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            List<Models1> about = new List<Models1>
            {
                new Models1
                {
                    ImageUrl = "/Content/Picture/张国荣.png",
                    Name = "Guorong Zhang",
                    Role = "Dieyi Cheng",
                    Dub = "Lixin Yang",
                    Intro = "Famous Peking Opera performer. He Cheng Dieyi became a famous actress when he co-starred with her senior brother Duan Xiaolou in Farewell My Concubine. During the Cultural Revolution, Cheng Dieyi felt lost in his lifelong pursuit of art and killed himself on stage during a rehearsal with Duan Xiaolou."
                },
                new Models1
                {
                    ImageUrl = "/Content/Picture/巩俐.png",
                    Name = "Li Gong",
                    Role = "Xian Ju",
                    Dub = "Li Gong",
                    Intro = "She is the head prostitute of Hua Man Lou, and later married to Duan Xiaolou. During the Cultural Revolution, Duan Xiaolou said against his will that he did not like Juxian in order to protect himself, which made Juxian see Duan Xiaolou's face clearly. After saying goodbye to Cheng Dieyi, she hangs herself from a beam in the house."

                },
                new Models1
                {
                    ImageUrl = "/Content/Picture/张丰毅.png",
                    Name = "Fengyi Zhang",
                    Role = "Xiaolou Duan",
                    Dub = "Xiaolou Duan",
                    Intro = "Cheng Dieyi's partner when she sings Peking Opera. He looks strong on the surface but is actually very weak inside. During the Cultural Revolution, he not only denied his lifelong career in order to survive, but also betrayed and exposed his wife and his junior Cheng Dieyi."
                },
                new Models1
                {
                    ImageUrl = "/Content/Picture/葛优.png",
                    Name = "You Ge",
                    Role = "Xiaolou Duan",
                    Dub = "Shiqing Yuan",
                    Intro = "The Republic of China in the period of the fallen aristocrats, a generation of Pear Park hegemony, known as the Yuan four masters. He loved Peking Opera and knew it well. After a performance, Yuan Shiqing was deeply impressed by Cheng Dieyi's superb acting skills and sighed Yu Ji is born again."
                }
            };
            return View(about);
        }

        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Photos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}