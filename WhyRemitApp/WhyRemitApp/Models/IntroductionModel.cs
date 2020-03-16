using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace WhyRemitApp.Models
{
    public class IntroductionModel
    {
        public string ID { get; set; }
        public string Header { get; set; } 
        public string Description { get; set; }
        public string DescriptionImage { get; set; }

        public static List<IntroductionModel> GetIntroList()
        {
            return new List<IntroductionModel>
        {
          new IntroductionModel ()
          {
            ID=Guid.NewGuid().ToString(),
            Header ="How it works", 
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            DescriptionImage = "howitworks.png",
          },
           new IntroductionModel ()
          {
            ID=Guid.NewGuid().ToString(),
            Header ="How it works",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            DescriptionImage = "howitworks.png",
          },
           new IntroductionModel ()
          {
            ID=Guid.NewGuid().ToString(),
            Header ="How it works",
            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
            DescriptionImage = "howitworks.png",
          },
        };
        }
    }
    public class IndicatorModel : BindableObject
    {
        private bool _IsCurrent;
        public bool IsCurrent
        {
            get { return _IsCurrent; }
            set
            {
                if (_IsCurrent != value)
                {
                    _IsCurrent = value;
                    OnPropertyChanged("IsCurrent");
                }
            }
        }
        private bool _IsNotCurrent;
        public bool IsNotCurrent
        {
            get { return _IsNotCurrent; }
            set
            {
                if (_IsNotCurrent != value)
                {
                    _IsNotCurrent = value;
                    OnPropertyChanged("IsNotCurrent");
                }
            }
        } 
        public string Id { get; set; }
    }
}
