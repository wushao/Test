using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    //public abstract class Subject
    //{
    //    private List<Observer> observers = new List<Observer>();

    //    public void Attach(Observer observer)
    //    {
    //        observers.Add(observer);
    //    }
    //    public void Detach(Observer observer)
    //    {
    //        observers.Remove(observer);
    //    }

    //    public void NotifyAllObservers()
    //    {
    //        foreach (var observer in this.observers)
    //        {
    //            observer.Update();
    //        }
    //    }

    //}

    //public abstract class Observer
    //{
    //    public abstract void Update();
    //}

    //public class BadMan : Subject
    //{
    //    private string _currentLocation = "";
    //    public string CurrentLocation
    //    {
    //        get { return _currentLocation; }
    //    }
    //    public void RunAway(string Location)
    //    {
    //        this._currentLocation = Location;
    //        base.NotifyAllObservers();
    //    }


    //}

    //public class PoliceMan : Observer
    //{

    //    private BadMan _target = null;

    //    public PoliceMan(BadMan target)
    //    {
    //        this._target = target;
    //        target.Attach(this);
    //    }
    //    public override void Update()
    //    {
    //        var location = this._target.CurrentLocation;

    //        Console.Write("在{0}部署警力围堵", location);
    //    }
    //}

    //public class City : Observer
    //{

    //    private BadMan _target = null;

    //    public City(BadMan target)
    //    {
    //        this._target = target;
    //        target.Attach(this);
    //    }
    //    public override void Update()
    //    {
    //        var location = this._target.CurrentLocation;

    //        Console.Write("热心市民{0}", location);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Subject subject = new BadMan();
    //        Observer plice = new PoliceMan(subject as BadMan);
    //        Observer city = new City(subject as BadMan);

    //        BadMan badman = subject as BadMan;
    //        badman.RunAway("跑路");
    //        Console.ReadKey();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}