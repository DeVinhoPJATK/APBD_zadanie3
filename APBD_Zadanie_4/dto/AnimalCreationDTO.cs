﻿using System.ComponentModel.DataAnnotations;

namespace APBD_Zadanie_4.dto;

public class AnimalCreationDTO
{
    [Required]
    public string name { get;}
    public string description { get; }
    public string category { get; }
    public string area { get; }

    public AnimalCreationDTO(string name, string description, string category, string area)
    {
        this.name = name;
        this.description = description;
        this.category = category;
        this.area = area;
    }
}
