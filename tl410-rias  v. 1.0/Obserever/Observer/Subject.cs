using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        
        }

        public void Dettach(Observer observer)
        {
            _observers.Remove(observer);
        
        }

        public void Notify()
        {
            foreach (Observer obs in _observers)
            {

                obs.Update();
            }
        
        }

    }

    public class State:Subject
    {
        private float _height;

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private TimeSpan _time;

        public TimeSpan Time
        {
            get { return _time; }
            set { _time = value; }
        }
        private float _speed;

        public float Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }


    
    }

    
}
