using Microsoft.AspNetCore.Mvc;
using Module.SoccerLeagueManagement.Server.Interfaces;
using Module.SoccerLeagueManagement.Shared.Interfaces;

namespace Module.SoccerLeagueManagement.Server.Generics;
public class GenericCrudController<TEntity,TDto>:ControllerBase, IGenericCrudController<TDto>
{
    protected readonly IGenericCrudService<TEntity, TDto> _genericCrudService;
    public GenericCrudController(IGenericCrudService<TEntity, TDto> genericCrudService)
    {
        _genericCrudService = genericCrudService;
    }


    [HttpGet]
    public async Task<ActionResult<List<TDto>>> GetAll()
     => await GenericControllerErrorHandling.RunServiceMethod(_genericCrudService.GetAll);

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<TDto>> GetById(Guid id)
        => await GenericControllerErrorHandling.RunServiceMethod(_genericCrudService.GetById, id);

    [HttpPost]
    public virtual async Task<ActionResult<TDto>> Create(TDto dto)
        => await GenericControllerErrorHandling.RunServiceMethod(_genericCrudService.Create, dto);

    [HttpPut]
    public async Task<ActionResult<TDto>> Update(TDto dto)
       => await GenericControllerErrorHandling.RunServiceMethod(_genericCrudService.Update, dto);

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult<int>> Delete(Guid id)
        => await GenericControllerErrorHandling.RunServiceMethod(_genericCrudService.Delete, id);
}
