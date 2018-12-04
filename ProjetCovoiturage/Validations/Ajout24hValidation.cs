﻿using ProjetCovoiturage.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetCovoiturage.Validations
{
    public class Ajout24hValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TrajetHeureDate trajet = (TrajetHeureDate)validationContext.ObjectInstance;
            DateTime datedepart = new DateTime(trajet.DateDepart.Year, trajet.DateDepart.Month, trajet.DateDepart.Day, trajet.HeureDepart.Hour, trajet.HeureDepart.Minute,trajet.HeureDepart.Second);
            DateTime dateaujourdhui = DateTime.Now;
            dateaujourdhui= dateaujourdhui.AddDays(1);
            if (dateaujourdhui > datedepart)
            {
                return new ValidationResult("La date de départ doit avoir une différence de 24 heure au minimum de la date de création");
            }
            return ValidationResult.Success;
        }
    }
}