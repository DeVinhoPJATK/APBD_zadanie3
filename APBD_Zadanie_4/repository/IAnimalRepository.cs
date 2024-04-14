using APBD_Zadanie_4.controllers;
using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.repository;

public interface IAnimalRepository
{
    public IEnumerable<Animal> GetAnimals(String orderBy);

    public Animal GetAnimal(int id);

    public int AddAnimal(AnimalCreationDTO dto);

    public int DeleteAnimal(int id);
    
    public int UpdateAnimal(int id);
}