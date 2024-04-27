namespace APBD_Zadanie_4.dto;

public class AnimalCreateResultDto
{
    public string name { get; }

    public AnimalCreateResultDto(string name)
    {
        this.name = name;
    }
}
