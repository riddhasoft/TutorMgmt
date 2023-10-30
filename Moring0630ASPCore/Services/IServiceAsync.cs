namespace Moring0630ASPCore.Services
{
    public interface IServiceAsync<t>
    {
        Task<List<t>> ToList();
        Task<int> Add(t model);
        Task<int> Update(t model);
        Task<int> Delete(t model);
        Task<t> Find(int id);

    }
}
