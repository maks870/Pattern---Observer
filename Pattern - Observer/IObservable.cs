namespace Pattern___Observer
{
    public interface IObservable
    {
        public void AddObserver(IObserver obs);
        public void RemoveObserver(IObserver obs);
        public void NotifyObservers();
    }
}
