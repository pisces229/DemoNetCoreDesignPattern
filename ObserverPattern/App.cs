using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.ObserverPattern
{
    public class App
    {
        public static void Run()
        {
            var podcast = new Podcast("Podcast");
            var studentFirst = new Student("StudentFirst");
            var studentSecond = new Student("StudentSecond");
            studentFirst.Subscribe(podcast);
            studentSecond.Subscribe(podcast);
            podcast.NotifyObservers();
        }
    }
}
