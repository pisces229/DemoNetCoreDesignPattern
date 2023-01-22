using System;

namespace DemoNetCoreDesignPattern.ObserverPattern
{
    public class App
    {
        public static void Run()
        {
            var podcastA = new Podcast("PodcastA");
            var podcastB = new Podcast("PodcastB");
            _ = new Student(podcastA);
            _ = new Student(podcastA);
            _ = new Student(podcastB);
            podcastA.NotifyObservers("Hi");
            podcastB.NotifyObservers("Hello");
        }
    }
}
