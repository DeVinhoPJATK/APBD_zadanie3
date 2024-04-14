using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.repository;

public class AnimalRepository : IAnimalRepository
{
    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        throw new NotImplementedException();
    }

    public Animal GetAnimal(int id)
    {
        throw new NotImplementedException();
    }

    public int AddAnimal(AnimalCreationDTO dto)
    {
        throw new NotImplementedException();
    }

    public int DeleteAnimal(int id)
    {
        throw new NotImplementedException();
    }

    public int UpdateAnimal(int id)
    {
        throw new NotImplementedException();
    }
}