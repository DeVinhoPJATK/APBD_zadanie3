using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.repository;

public interface IAnimalRepository
{
    public IEnumerable<Animal> GetAnimals(String orderBy);

    public int AddAnimal(Animal animal);

    public int DeleteAnimal(int id);
    
    public int UpdateAnimal(int id, AnimalUpdateDto dto);
}
