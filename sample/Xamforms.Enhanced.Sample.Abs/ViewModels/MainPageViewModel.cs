using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamforms.Enhanced.Sample.Models;
using Xamforms.Enhanced.Sample.Views;
using XamForms.Enhanced.ViewModels;

namespace Xamforms.Enhanced.Sample.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public INavigation Navigation { private get; set; }

        public MainPageViewModel()
        {
                
        }
        
        public ObservableCollection<PageItem> Pages => new ObservableCollection<PageItem>
        {
            new PageItem("Gradient View", typeof(SampleGradientPage)),
            new PageItem("Extended Frame", typeof(SampleExtendedFramePage)),
            new PageItem("Content View", typeof(SampleContentPage)),
        };
        
        public  ICommand PageSelectedCmd => new Command<PageItem>(async (page) =>
        {
            if (page.PageType == typeof(SampleGradientPage))
            {
                await Navigation.PushAsync(new SampleGradientPage());
            }
            if (page.PageType == typeof(SampleContentPage))
            {
                await Navigation.PushAsync(new SampleContentPage());
            }
            if (page.PageType == typeof(SampleExtendedFramePage))
            {
                await Navigation.PushAsync(new SampleExtendedFramePage());
            }
        });
    }
}