using System.Data.SqlClient;
using APBD_Zadanie_4.dto;

namespace APBD_Zadanie_4.repository;

public class AnimalRepository : IAnimalRepository
{
    private IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IEnumerable<Animal> GetAnimals(string orderBy)
    {
        using (var connection = new SqlConnection(_configuration.GetValue<string>("ConnectionString")))
        {
            connection.Open();
            var animals = new List<Animal>();
            using (SqlCommand command = new SqlCommand($"SELECT * FROM Animals ORDER BY {orderBy}", connection))
            {
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var animalId = reader.GetInt32(reader.GetOrdinal("Id"));
                    var name = reader.GetString(reader.GetOrdinal("Name"));
                    var description = reader.GetString(reader.GetOrdinal("Description"));
                    var category = reader.GetString(reader.GetOrdinal("Category"));
                    var area = reader.GetString(reader.GetOrdinal("Area"));
                    animals.Add(new Animal()
                    {
                        IdAnimal = animalId,
                        Name = name,
                        Description = description,
                        Category = category,
                        Area = area,
                    });
                }

                reader.Close();
                return animals;
            }
        }
    }

    public int AddAnimal(Animal animal)
    {
        using (var connection = new SqlConnection(_configuration.GetValue<string>("ConnectionString")))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("INSERT INTO Animals (Name, Description, Category, Area) " +
                                                       "VALUES (@name, @description, @category, @area)", connection))
            {
                command.Parameters.AddWithValue("@name", animal.Name);
                command.Parameters.AddWithValue("@description", animal.Description);
                command.Parameters.AddWithValue("@category", animal.Category);
                command.Parameters.AddWithValue("@area", animal.Area);
                return command.ExecuteNonQuery();
            }
        }
    }

    public int DeleteAnimal(int id)
    {
        using (var connection = new SqlConnection(_configuration.GetValue<string>("ConnectionString")))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("DELETE FROM Animals WHERE id = @animalId", connection))
            {
                command.Parameters.AddWithValue("@animalId", id);
                return command.ExecuteNonQuery();
            }
        }
    }

    public int UpdateAnimal(int id, AnimalUpdateDto dto)
    {
        using (var connection = new SqlConnection(_configuration.GetValue<string>("ConnectionString")))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("UPDATE Animals " +
                                                       "SET name = @newName, description = @newDescription, category = @newCategory, area = @newArea WHERE id = @animalId", connection))
            {
                command.Parameters.AddWithValue("@animalId", id);

                command.Parameters.AddWithValue("@newName", dto.name);
                command.Parameters.AddWithValue("@newDescription", dto.description);
                command.Parameters.AddWithValue("@newCategory", dto.category);
                command.Parameters.AddWithValue("@newArea", dto.area);
                return command.ExecuteNonQuery();
            }
        }
    }
}
