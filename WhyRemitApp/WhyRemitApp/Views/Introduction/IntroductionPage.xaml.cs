using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.ViewModels.Introduction;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views.Introduction
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroductionPage : ContentPage
    {
        //TODO : To Define class Level Variables...
        IntroductionPageVM IntroVM;

        public IntroductionPage()
        {
            InitializeComponent();
            IntroVM = new IntroductionPageVM(this.Navigation);
            this.BindingContext = IntroVM;

            // iOS Platform
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        #region Event Handlers

        /// <summary>
        /// TODO : To Define On Page Appearing Event...
        /// </summary>
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await IntroVM.GetIntroductionList();
            LvIndicators.ItemsSource = IntroVM.IndicatorList;
        }

        /// <summary>
        /// TODO : To Define On Carousel Changed event...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            var index = e.NewValue;
            //var item = e.SelectedItem as Value;
            if (IntroVM.IntroductionList != null)
            {
                var item = IntroVM.IntroductionList.ElementAt(index);

                //For Indicators
                foreach (var inditem in IntroVM.IndicatorList)
                {
                    if (inditem.Id == item.ID)
                    {
                        inditem.IsCurrent = true;
                        inditem.IsNotCurrent = false;
                    }
                    else
                    {
                        inditem.IsCurrent = false;
                        inditem.IsNotCurrent = true;
                    }
                }
                LvIndicators.ItemsSource = null;
                LvIndicators.ItemsSource = IntroVM.IndicatorList;
            }
        } 
        #endregion  
    }
}