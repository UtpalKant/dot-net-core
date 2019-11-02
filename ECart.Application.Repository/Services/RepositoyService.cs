using System;
using System.Collections.Generic;
using ECart.Application.Core.Interfaces;
using ECart.Application.Core.Models.DTO;

namespace ECart.Application.Repository.Services
{
    public class RepositoryService: IRepositoryService
    {
        public Token GetToken(string userName, string password)
        {
            string _userName = "nabin007";
            string _password = "P@ssw0rd";
            if(userName.ToLower() == _userName.ToLower() && password == _password)
            {
                return new Token(string.Empty,_userName);
            }
            else
            {
                string message = (password == _password) ? "wrong username." : "wrong password.";
                throw new Exception(message);
            }
        }

        public List<Item> GetItems()
        {
            string[] Id = new string[]
            {
                "c2219e8a-0bdc-4426-af8c-306042265280",
                "c2219e8a-0bdc-4426-af8c-306042265281",
                "c2219e8a-0bdc-4426-af8c-306042265282",
                "c2219e8a-0bdc-4426-af8c-306042265283",
                "c2219e8a-0bdc-4426-af8c-306042265284",
                "c2219e8a-0bdc-4426-af8c-306042265285",
                "c2219e8a-0bdc-4426-af8c-306042265286",
                "c2219e8a-0bdc-4426-af8c-306042265287",
                "c2219e8a-0bdc-4426-af8c-306042265288",
                "c2219e8a-0bdc-4426-af8c-306042265289"
            };
            string[] Name = new string[]
            {
                "Rice", "Oil", "Sugar", "Tea Powder", "Salt", "Turmeric Powder", "Tooth Paste", "Tamato KetchUp", "Maggie", "Cashew"
            };
            double[] Weight = new double[]
            {
                5.000 , 1.000, 1.000, 0.100, 1.000, 0.250, 0.150, 1.250, 0.025, 0.500
            };
            double[] Rate = new double[]
            {
                310.75, 97.50, 40.00, 108.00, 25.00, 37.50, 89.00, 117.75, 12.00, 470.00
            };
            string[] Images = new string[]
            {
                "rice.jpg", "oil.jpg", "sugar.jpg", "tea.jpg", "salt.jpg", "turmeric.jpg", "toothpaste.jpg", "ketchup.jpg", "maggie.jpg", "cashew.jpg"
            };
            List<Item> items = new List<Item>();
            Item item = null;
            for (int i = 0; i < 10; i++)
            {
                item = new Item();
                item.Id = new Guid(Id[i]);
                item.Name = Name[i];
                item.Weight = Weight[i];
                item.Rate = Rate[i];
                item.SourceImage = Images[i];

                items.Add(item);
            }
            return items;
        }
    }
}
