namespace APBD_Zadanie_4.controllers;

public class AnimalDTO
{
    public int id { get; }
    public string name { get; }
    public string description { get; }
    public string category { get; }
    public string area { get; }

    public AnimalDTO(int id, string name, string description, string category, string area)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.category = category;
        this.area = area;
    }
}
