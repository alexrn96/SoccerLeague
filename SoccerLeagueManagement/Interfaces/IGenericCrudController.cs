using Microsoft.AspNetCore.Mvc;

namespace Module.SoccerLeagueManagement.Server.Interfaces;
public interface IGenericCrudController<TDto>
{
    Task<ActionResult<List<TDto>>> GetAll();

    Task<ActionResult<TDto>> GetById(Guid id);

    Task<ActionResult<TDto>> Create(TDto dto);

    Task<ActionResult<TDto>> Update(TDto dto);

    Task<ActionResult<int>> Delete(Guid id);
}