namespace Web.Data.Intrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}