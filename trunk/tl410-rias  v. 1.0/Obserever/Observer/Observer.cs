using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public abstract class Observer
    {
        public abstract void Update();

    }

    public class AviaEvent : Observer
    {
        string _name;

        bool _done = false;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private State _state;

        float _height;

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

        public AviaEvent(State state, string name)
        {
            _name = name;
            _state = state;
        
        }

        public override void Update()
        {
            if(!_done)
            {

            if ((_height - _state.Height) < 3 &&
                (_height - _state.Height) > -3&&
                _height!=0.0f)
            {
                MessageBox.Show("Подія "+_name +" відбулась");
            _done = true;
            }
            if ((_speed - _state.Speed) < 3 &&
                (_speed - _state.Speed) > -3&&
                _speed!=0.0f)
            {
                MessageBox.Show("Подія " + _name + " відбулась");
                _done = true;

            }
        }
    
        }


        public State ObserverState
        {
            get { return _state; }
            set { _state = value; }
        
        }








    
    }
}
