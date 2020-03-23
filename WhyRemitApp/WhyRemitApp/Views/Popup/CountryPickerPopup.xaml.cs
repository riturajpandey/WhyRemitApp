using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhyRemitApp.Model;
using WhyRemitApp.ViewModels.Registration;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhyRemitApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryPickerPopup : PopupPage
    {
        public event EventHandler DialogClosed;
        public event EventHandler DialogShow;
        public event EventHandler DialogClosing;
        public event EventHandler DialogShowing;
        protected RegistrationPageVM registerVM;

        public CountryPickerPopup(RegistrationPageVM _regViewVM)
        {
            InitializeComponent();
            registerVM = _regViewVM;
            this.BindingContext = registerVM;
            CountryPickerList.SetBinding(ListView.ItemsSourceProperty, "TempCountryPickerListItem");
            CountryPickerList.ItemSelected += CountryPickerList_ItemSelected;
            PopUpBgLayout.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(HideDialog)
            });
        }

        private void CountryPickerList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as CountryPickerModel;
            if (item != null)
            {
                if (item.CountryName != null)
                {
                    registerVM.CallSubmitMethodForCollaborate(item.CountryFlag, item.CountryISDCode, item.Id, item.CountryName,item.CountryIS03Code);
                    HideDialog();
                }
            }
        }

        private void FilterNames()
        {
            string filter = EntrySearch.Text;
            CountryPickerList.ItemsSource = registerVM.TempCountryPickerListItem.Where(x => x.CountryName.ToLower().Contains(filter.ToLower()));
            CountryPickerList.EndRefresh();
        }

        void OnSearchBarTextChanged(object sender, TextChangedEventArgs args)
        {
            FilterNames();
        }
        void OnSearchBarButtonPressed(object sender, EventArgs args)
        {
            FilterNames();
        }
        public void ShowDialog()
        {
            ShowDialogAnimation(PopUpDialogLayout, PopUpBgLayout);
        }

        public void HideDialog()
        {
            HideDialogAnimation(PopUpDialogLayout, PopUpBgLayout);
        } 

        protected virtual void OnDialogClosed(EventArgs e)
        {
            DialogClosed?.Invoke(this, e);
        }

        protected virtual void OnDialogShow(EventArgs e)
        {
            DialogShow?.Invoke(this, e);
        }

        protected virtual void OnDialogClosing(EventArgs e)
        {
            DialogClosing?.Invoke(this, e);
        }

        protected virtual void OnDialogShowing(EventArgs e)
        {
            DialogShowing?.Invoke(this, e);
        }

        private void ShowDialogAnimation(VisualElement dialog, VisualElement bg)
        {
            dialog.TranslationY = bg.Height;
            bg.IsVisible = true;
            dialog.IsVisible = true;

            ////ANIMATIONS 
            var showBgAnimation = OpacityAnimation(bg, 0, 0.5);
            var showDialogAnimation = TransLateYAnimation(dialog, bg.Height, 0);

            ////EXECUTE ANIMATIONS
            this.Animate("showBg", showBgAnimation, 16, 200, Easing.Linear, (d, f) => { });
            this.Animate("showMenu", showDialogAnimation, 16, 200, Easing.Linear, (d, f) =>
            {
                OnDialogShow(new EventArgs());
            });

            OnDialogShowing(new EventArgs());
        }

        private async void HideDialogAnimation(VisualElement dialog, VisualElement bg)
        {
            //ANIMATIONS     
            var hideBgAnimation = OpacityAnimation(bg, 0.5, 0);
            var showDialogAnimation = TransLateYAnimation(dialog, 0, bg.Height);

            ////EXECUTE ANIMATIONS
            this.Animate("hideBg", hideBgAnimation, 16, 200, Easing.Linear, (d, f) => { });
            this.Animate("hideMenu", showDialogAnimation, 16, 200, Easing.Linear, (d, f) =>
            {
                bg.IsVisible = false;
                dialog.IsVisible = false;
                dialog.TranslationY = PopUpBgLayout.Height;

                OnDialogClosing(new EventArgs());
            });
            await Navigation.PopAllPopupAsync(true);

            OnDialogClosing(new EventArgs());
        }

        private static Animation TransLateYAnimation(VisualElement element, double from, double to)
        {
            return new Animation(d => { element.TranslationY = d; }, from, to);
        }

        private static Animation TransLateXAnimation(VisualElement element, double from, double to)
        {
            return new Animation(d => { element.TranslationX = d; }, from, to);
        }

        private static Animation OpacityAnimation(VisualElement element, double from, double to)
        {
            return new Animation(d => { element.Opacity = d; }, from, to);
        }

        //TODO : To close the CountryPickerPopup
        private void ImageCross_Tapped(object sender, EventArgs e)
        {
            HideDialog();
        }
    }
}