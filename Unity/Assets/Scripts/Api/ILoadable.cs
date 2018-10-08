namespace Api
{
    public interface ILoadable
    {
        void SetData<T>(T[] entities);
    }
}