using APBD_Zadanie_4.controllers;
using APBD_Zadanie_4.dto;
using APBD_Zadanie_4.mapper;
using APBD_Zadanie_4.repository;

namespace APBD_Zadanie_4.service;

public class AnimalService : IAnimalService
{
    private IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository _animalRepository)
    {
        this._animalRepository = _animalRepository;
    }

    public IEnumerable<AnimalDTO> GetAnimals(string orderBy)
    {

        IEnumerable<Animal> animals = _animalRepository.GetAnimals(orderBy);
        return AnimalMapper.MapToDto(animals);
    }

    public AnimalCreateResultDto createAnimal(AnimalCreationDTO dto)
    {
        var entity = AnimalMapper.MapDtoToEntity(dto);
        int rows = _animalRepository.AddAnimal(entity);
        if (rows == 1)
        {
            return new AnimalCreateResultDto(dto.name);
        }

        throw new Exception("Cannot create new animal");
    }

    public void UpdateAnimal(int id, AnimalUpdateDto dto)
    {
        _animalRepository.UpdateAnimal(id, dto);
    }

    public void DeleteAnimal(int id)
    {
        _animalRepository.DeleteAnimal(id);
    }
}
