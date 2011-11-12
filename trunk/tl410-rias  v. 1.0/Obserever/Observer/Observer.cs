using System;
using System.Collections;
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


    /// <summary>
    /// Делегат для собития исполнения собития (как говорит порутчик Ржевский: каламбурчик)
    /// </summary>
    /// <param name="eventName">Имя события</param>
    /// <param name="paramName">Имя параметра из-за каторого это событие произошло</param>
    public delegate void EventHandler(String eventName, String paramName);



    public class AviaEvent : Observer
    {
        public event EventHandler Execute;

        string _name;

        bool _done = false;
        private State _state;
        private SortedList<String,String> _eventState;


        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        

        //float _height;

        //public float Height
        //{
        //    get { return _height; }
        //    set { _height = value; }
        //}
        //private TimeSpan _time;

        //public TimeSpan Time
        //{
        //    get { return _time; }
        //    set { _time = value; }
        //}
        //private float _speed;

        //public float Speed
        //{
        //    get { return _speed; }
        //    set { _speed = value; }
        //}

        public AviaEvent(State state, string name, SortedList<String,String> eventState)
        {
            _name = name;
            _state = state;
            _eventState = eventState;
            Execute += AviaEvent_Execute;


        }

        void AviaEvent_Execute(string eventName, string paramName)
        {
            _done = true;
        }

        public override void Update()
        {
            if(!_done)
            {
                foreach(var param in _eventState)
                {
                    if(_state.EqualParam(param.Key,param.Value)== EqualState.Equally)
                    {
                        Execute(_name, param.Key);
                    }

                }


                //if ((_height - _state.Height) < 3 &&
            //    (_height - _state.Height) > -3&&
            //    _height!=0.0f)
            //{
            //    MessageBox.Show("Подія "+_name +" відбулась");
            //_done = true;
            //}
            //if ((_speed - _state.Speed) < 3 &&
            //    (_speed - _state.Speed) > -3&&
            //    _speed!=0.0f)
            //{
            //    MessageBox.Show("Подія " + _name + " відбулась");
            //    _done = true;

            //}
        }
    
        }


        public State ObserverState
        {
            get { return _state; }
            set { _state = value; }
        
        }








    
    }
}
