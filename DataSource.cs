namespace pattern_observer
{
    public class DataSource : Subject
    {
        private int _data;
        public int Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
                NotifyObserver();
            }
        }
    }
}