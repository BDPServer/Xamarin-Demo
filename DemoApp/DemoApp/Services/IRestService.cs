using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Services
{    
    public interface IRestService
    {
        Task<RootObject> RefreshDataAsync();

        //Task SaveTodoItemAsync(MainPageModel item, bool isNewItem);

        //Task DeleteTodoItemAsync(string id);
    }
}
