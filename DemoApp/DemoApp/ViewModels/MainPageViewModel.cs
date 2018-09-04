using DemoApp.Models;
using DemoApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoApp.ViewModels
{
   public class MainPageViewModel
    {
        Page page;
        IRestService restService;
        
        public List<MainPageModel> Model { get; set; }
       
        int count = 0;

        public MainPageViewModel(IRestService service, Page page)
        {
            this.page = page;
            Model = new List<MainPageModel>();
            restService = service;

            //GetTasksAsync();

            Add();

            SwipedLeft = new Command(HandleSwipedLeft);
            SwipedRight = new Command(HandleSwipedRight);
        }

        public void Add()
        {
            Model.Add(new MainPageModel { Title="Apple",ImageSrc="apple.jpg"});
            Model.Add(new MainPageModel { Title = "Grapes", ImageSrc = "Grapes.jpg" });
            Model.Add(new MainPageModel { Title = "Orange", ImageSrc = "Orange.jpg" });
            Model.Add(new MainPageModel { Title = "Ananas", ImageSrc = "Ananas.jpg" });
        }
        public Task<RootObject> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

        public ICommand SwipedLeft { private set; get; }

        public void HandleSwipedLeft()
        {
            page.DisplayAlert("Reject", "Reject", "Ok");
            count++;
            if (count>=4)
            {
                page.DisplayAlert("Message", "No card available", "Ok");
            }
        }

        public ICommand SwipedRight { private set; get; }

        public void HandleSwipedRight()
        {
            page.DisplayAlert("Accept", "Accept", "Ok");
            count++;
            if (count >= 4)
            {
                page.DisplayAlert("Message", "No card available", "Ok");
            }
        }

        public void GetInfo()
        {
            page.DisplayAlert("Accept", "Accept", "Ok");
        }
    }
}
