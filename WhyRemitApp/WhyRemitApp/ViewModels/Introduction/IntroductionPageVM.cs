using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Models;
using Xamarin.Forms;

namespace WhyRemitApp.ViewModels.Introduction
{
    public class IntroductionPageVM : BaseViewModel
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="IntroductionVM"/> class.
        /// </summary>
        /// <param name="nav"></param>
        public IntroductionPageVM(INavigation nav)
        {
            Navigation = nav; 
            ContinueCommand = new Command(OnContinueAsync); 
        }

        #endregion

        #region DELEGATECOMMAND 
        public Command ContinueCommand { get; set; } 
        #endregion

        #region PROPERTIES 

        private ObservableCollection<IntroductionModel> _IntroductionList;
        public ObservableCollection<IntroductionModel> IntroductionList
        {
            get { return _IntroductionList; }
            set
            {
                if (_IntroductionList != value)
                {
                    _IntroductionList = value;
                    OnPropertyChanged("IntroductionList");
                }
            }
        }
        private ObservableCollection<IndicatorModel> _IndicatorList;
        public ObservableCollection<IndicatorModel> IndicatorList
        {
            get { return _IndicatorList; }
            set
            {
                if (_IndicatorList != value)
                {
                    _IndicatorList = value;
                    OnPropertyChanged("IndicatorList");
                }
            }
        }
        #endregion

        #region Methods 
      
        /// <summary>
        /// TODO : To navigate To Login Page...
        /// </summary>
        /// <param name="obj"></param>
        private async void OnContinueAsync(object obj)
        {
            App.Current.MainPage = new Views.Register.RegistrationPage();
        } 

        /// <summary>
        /// TODO : To Get LoginHistory Details List...
        /// </summary>
        public async Task GetIntroductionList()
        {
            IntroductionList = new ObservableCollection<IntroductionModel>(IntroductionModel.GetIntroList());
            IndicatorList = new ObservableCollection<IndicatorModel>();
            var indicatorList = new ObservableCollection<IndicatorModel>();
            int first = 0;
            foreach (var item in IntroductionList)
            {

                IndicatorModel objIndicator = new IndicatorModel();
                if (first == 0)
                {
                    objIndicator.IsCurrent = true;
                    objIndicator.IsNotCurrent = false;
                    first = 1;
                }
                else
                {
                    objIndicator.IsCurrent = false;
                    objIndicator.IsNotCurrent = true;
                }
                objIndicator.Id = item.ID.ToString();
                indicatorList.Add(objIndicator);
            }
            IndicatorList = indicatorList;
        }
        #endregion 
    }
}
