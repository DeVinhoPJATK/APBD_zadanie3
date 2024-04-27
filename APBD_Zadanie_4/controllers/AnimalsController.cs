using APBD_Zadanie_4.dto;
using APBD_Zadanie_4.service;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_4.controllers;

[ApiController]
[Route("/api/animals")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalService _animalService;


    public AnimalsController(IAnimalService _animalService)
    {
        this._animalService = _animalService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<AnimalDTO>> FetchAnimal(string orderBy = "name")
    {
        var validOrderBy = new[] { "name", "description", "category", "area" };
        if (!validOrderBy.Contains(orderBy))
        {
            return BadRequest($"invalid orderBy = {orderBy}");
        }
        return Ok(_animalService.GetAnimals(orderBy));
    }

    [HttpPost]
    public ActionResult<AnimalCreateResultDto> CreateAnimal(AnimalCreationDTO animal)
    {
        return Ok(_animalService.createAnimal(animal));
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal([FromBody] AnimalUpdateDto dto, [FromRoute] int id)
    {
        _animalService.UpdateAnimal(id, dto);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalService.DeleteAnimal(id);
        return NoContent();
    }
}
