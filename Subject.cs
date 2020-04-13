using System.Collections.Generic;

namespace pattern_observer
{
    public class Subject
    {
        private List<ObServer> _observers;
        public Subject()
        {
            _observers = new List<ObServer>();
        }
        public void AddObserver(ObServer obServer)
        {
            _observers.Add(obServer);
        }

        public void RemoveObserver(ObServer obServer)
        {
            _observers.Remove(obServer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}