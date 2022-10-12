using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreDesignPattern.TemplateMethodPattern
{
    internal abstract class WorkTemplate
    {
        private readonly RestTemplate _restTemplate;
        public WorkTemplate(RestTemplate restTemplate)
        {
            _restTemplate = restTemplate;
        }
        public void Start() => Console.WriteLine("Work.Start");
        public abstract void Work();
        public void Stop() => Console.WriteLine("Work.Stop");
        public void Describe()
        {
            Start();
            Work();
            _restTemplate.Describe();
            Work();
            Stop();
        }
    }
    internal class FirstWorkTemplate : WorkTemplate
    {
        public FirstWorkTemplate(RestTemplate restTemplate) : base(restTemplate) { }
        public override void Work() => Console.WriteLine("Work.First");
    }
    internal class SecondWorkTemplate : WorkTemplate
    {
        public SecondWorkTemplate(RestTemplate restTemplate) : base(restTemplate) { }
        public override void Work() => Console.WriteLine("Work.Second");
    }
    internal abstract class RestTemplate
    {
        public void Start() => Console.WriteLine("Rest.Start");
        public abstract void Rest();
        public void Stop() => Console.WriteLine("Rest.Stop");
        public void Describe()
        {
            Start();
            Rest();
            Stop();
        }
    }
    internal class FirstRestTemplate : RestTemplate
    {
        public override void Rest() => Console.WriteLine("Rest.First");
    }
    internal class SecondRestTemplate : RestTemplate
    {
        public override void Rest() => Console.WriteLine("Rest.Second");
    }
}