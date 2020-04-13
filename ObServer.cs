namespace pattern_observer
{
    public interface ObServer
    {
        void Update();
    }

    public interface ObServer<T>
    {
        void Update(T value);
    }
}