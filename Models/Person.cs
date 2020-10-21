

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Assignment.Models
{
    public class Person
    {
        private EyeColorInterface EyeColorInterface = new EyeColor();
        private HairColorInterface hair = new HairColor();
        public int Id { get; set; }
        [NotNull]
        public string FirstName { get; set; }
        public void SetFName(string FName)
        {
            FirstName = FName;
        }
        [NotNull]
        public string LastName { get; set; }
        public void SetLName(string LName)
        {
            LastName = LName;
        }
        [ValidHairColor]
        public string HairColor { get; set; }
        public void SetHairColor(int i)
        {
            HairColor = hair.SelectHairColor(i);
        }
        [NotNull]
        [ValidEyeColor]
        public string EyeColor { get; set; }
        public void SetEyeColor(int i)
        {
            EyeColor = EyeColorInterface.SelectEyeColor(i);
        }
        [NotNull, Range(0, 125)]
        public int Age { get; set; }
        public void setAge(int age)
        {
            Age = age;
        }
        [NotNull, Range(1, 250)]
        public float Weight { get; set; }
        public void setWeight(float weight)
        {
            Weight = weight;
        }
        [NotNull, Range(30, 250)]
        public int Height { get; set; }
        public void setHeight(int height)
        {
            Height = height;
        }
        [NotNull]
        public string Sex { get; set; }
        public void setSex(Boolean sex)
        {
            string s = "";
            if (sex == true)
            {
                s = "female";
            }
            else s = "male";
            Sex = s;
        }
        public Person() { }
        public void Update(Person toUpdate)
        {
            Age = toUpdate.Age;
            Height = toUpdate.Height;
            HairColor = toUpdate.HairColor;
            Sex = toUpdate.Sex;
            Weight = toUpdate.Weight;
            EyeColor = toUpdate.EyeColor;
            FirstName = toUpdate.FirstName;
            LastName = toUpdate.LastName;
        }

    }

    public class ValidHairColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[] {"blond", "red", "brown", "black",
            "white", "grey", "blue", "green", "leverpostej"}.ToList();
            if (valid == null || valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
        }
    }

    public class ValidEyeColor : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            List<string> valid = new[] {"brown", "grey", "green", "blue",
            "amber", "hazel"}.ToList();
            if (valid != null && valid.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
        }
    }

}