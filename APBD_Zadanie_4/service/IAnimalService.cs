using APBD_Zadanie_4.controllers;

namespace APBD_Zadanie_4.service;

public interface IAnimalService
{
    IEnumerable<AnimalDTO> GetAnimals(String orderBy);

    public AnimalDTO GetAnimal(int id);
}