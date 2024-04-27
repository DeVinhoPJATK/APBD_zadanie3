using APBD_Zadanie_4.controllers;
using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.service;

public interface IAnimalService
{
    public IEnumerable<AnimalDTO> GetAnimals(String orderBy);

    public AnimalCreateResultDto createAnimal(AnimalCreationDTO dto);

    public void UpdateAnimal(int id, AnimalUpdateDto dto);

    public void DeleteAnimal(int id);
}
