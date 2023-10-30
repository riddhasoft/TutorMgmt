namespace Moring0630ASPCore.Services
{
    public interface IService<t>
    {
        List<t> ToList();
        int Add(t model);
        int Update(t model);
        int Delete(t model);
        t Find(int id);

    }
}
