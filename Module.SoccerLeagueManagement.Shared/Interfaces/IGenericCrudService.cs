

namespace Module.SoccerLeagueManagement.Shared.Interfaces;
public interface IGenericCrudService<TEntity,TDto>
{
    public Task<List<TDto>> GetAll();
    public Task<TDto> GetById(Guid id);
    public Task<TDto> Create(TDto item);
    public Task<int> Delete(Guid id);
    public Task<TDto> Update(TDto item);
}