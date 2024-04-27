using APBD_Zadanie_4.controllers;
using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.mapper;

public class AnimalMapper
{
    public static IEnumerable<AnimalDTO> MapToDto(IEnumerable<Animal> animals)
    {
        List<AnimalDTO> res = new List<AnimalDTO>();
        foreach (var animal in animals)
        {
            res.Add(new AnimalDTO(animal.IdAnimal, animal.Name, animal.Description, animal.Category, animal.Area));
        }
        return res;
    }

    public static Animal MapDtoToEntity(AnimalCreationDTO dto)
    {
        return new Animal { Name = dto.name, Description = dto.description, Category = dto.category, Area = dto.area };
    }
}
