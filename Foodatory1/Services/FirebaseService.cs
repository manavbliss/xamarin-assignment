using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Foodatory1.Models;

namespace Foodatory1.Services
{
    public class FirebaseService
    {
        FirebaseClient firebase = new FirebaseClient("https://foodatory-ffc87.firebaseio.com/");
        public FirebaseService()
        {

        }

        public async Task<List<User>> GetAllUsers()
        {

            return (await firebase
              .Child("Users")
              .OnceAsync<User>()).Select(item => new User
              {
                  id = item.Object.id,
                  username = item.Object.username,
                  email = item.Object.email,
                  password = item.Object.password,

              }).ToList();
        }


        public async Task<List<Inventory>> GetAllInventories()
        {

            return (await firebase
              .Child("Inventories")
              .OnceAsync<Inventory>()).Select(item => new Inventory
              {
                  name = item.Object.name,
                
              }).ToList();
        }

        public async Task AddUser(int id, string username, string email ,string password)
        {

            await firebase
              .Child("Users")
              .PostAsync(new User() { id = id, username= username, email = email, password = password });
        }

        public async Task AddRecipe(string name, string procedure, string ingredients)
        {

            await firebase
              .Child("Recipes")
              .PostAsync(new Recipe() { name = name, procedure = procedure, ingredients = ingredients});
        }

        public async Task AddInventory(string name)
        {

            await firebase
              .Child("Inventories")
              .PostAsync(new Inventory() { name = name});
        }

        public async Task<List<Recipe>> GetAllRecipes()
        {

            return (await firebase
              .Child("Recipes")
              .OnceAsync<Recipe>()).Select(item => new Recipe
              {
                  name = item.Object.name,
                  procedure = item.Object.procedure,
                  ingredients = item.Object.ingredients,

               }).ToList();
        }
    }
}
