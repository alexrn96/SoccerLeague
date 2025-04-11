
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Module.SoccerLeagueManagement.Shared.Abstracts;
using Module.SoccerLeagueManagement.Shared.DataTransferObjects;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement;

namespace Module.SoccerLeagueManagement.Infrastructure.Services;
 public class GenericCrudService<TEntity,TDto>: IGenericCrudService<TEntity,TDto> where TEntity:BaseEntity<TEntity> where TDto:BaseDbDto
{
    protected readonly SoccerLeagueDbContext _dbContext;
    protected readonly IMapper _mapper;

    protected GenericCrudService(SoccerLeagueDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }
    public async Task<List<TDto>> GetAll()
    {
        List<TEntity> entities = await _dbContext.Set<TEntity>().AsNoTracking().OrderByDescending(x => x.ModifiedAt).ToListAsync();
        return _mapper.Map<List<TDto>>(entities);
    }

    public async Task<TDto> GetById(Guid id)
    {
        TEntity? entity = await _dbContext.Set<TEntity>().FindAsync(id);

        if (entity == null) throw new KeyNotFoundException();

        TDto dto = _mapper.Map<TDto>(entity);

        return dto;
    }

    public async Task<TDto> Create(TDto item)
    {
        TEntity entity = _mapper.Map<TEntity>(item);
        EntityEntry<TEntity> newEntity = await _dbContext.Set<TEntity>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        item.Id = newEntity.Entity.Id;
        return item;
    }

    public async Task<int> Delete(Guid id)
    {
        //return await _dbContext.Set<TEntity>().Where(x => x.Id == id).ExecuteDeleteAsync();
        return 0;
    }

    public async Task<TDto> Update(TDto item)
    {
        TEntity entity = _mapper.Map<TEntity>(item);
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
        return item;
    }
}
