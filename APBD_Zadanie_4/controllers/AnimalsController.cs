using APBD_Zadanie_4.dto;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using APBD_Zadanie_4.service;

namespace APBD_Zadanie_4.controllers;

[ApiController]
[Route("/api/animals")]
public class AnimalsController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalsController(IAnimalService _animalService)
    {
        this._animalService = _animalService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<AnimalDTO>> FetchAnimal()
    {
    }

    [HttpPost]
    public ActionResult<Animal> CreateAnimal(AnimalCreationDTO animal)
    {
        return null;
    }

    [HttpPut("{id}")]
    public void UpdateAnimal()
    {
        
    }
}