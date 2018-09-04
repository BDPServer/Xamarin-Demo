using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Models
{
  public  class MainPageModel:BaseModel
    {
        private string _title { get; set; }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }


        private string _imageSrc { get; set; }
        public string ImageSrc
        {
            get { return _imageSrc; }

            set
            {
                _imageSrc = value;
                OnPropertyChanged();
            }
        }
        
    }
}
