using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace encrypt
{
	public class AppShellViewModel
	{
        public ICommand SignOutCommand { get => new Command(async () => await SignOut()); }

        private async Task SignOut()
        {
            await Shell.Current.DisplayAlert("logout", "logged out", "okay");
            //Preferences.Remove(Constants.IS_USER_LOGGED_IN);
            //_navigationService.GoToLoginFlow();
            //await _navigationService.InsertAsRoot<LoginViewModel>();
        } 
    }
}

