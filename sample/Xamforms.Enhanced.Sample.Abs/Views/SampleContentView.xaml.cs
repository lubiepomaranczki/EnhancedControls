using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Enhanced.Views;

namespace Xamforms.Enhanced.Sample.Views
{
    public partial class SampleContentView : ExtendedContentView
    {
        public SampleContentView()
        {
            InitializeComponent();
        }

        protected override void OnViewAppeared()
        {
            base.OnViewAppeared();
            Console.WriteLine($"{nameof(SampleContentView)} appeared");
        }

        protected override void OnViewDisappeared()
        {
            base.OnViewDisappeared();
            Console.WriteLine($"{nameof(SampleContentView)} disappeared");
        }

        protected override void OnToolbarAvailable(IList<ToolbarItem> toolbar)
        {
            base.OnToolbarAvailable(toolbar);
            toolbar.Add(new ToolbarItem("Watch", null, () => { Console.WriteLine("Item was tapped"); }));
            Console.WriteLine($"{nameof(SampleContentView)} toolbar ready");
        }

        //This is here to check if OnPropertyChanged is being invoked with renderer
        private void Button_OnClicked(object sender, EventArgs e)
        {
            TextLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            StackLayout.Children.Add(new Label {Text = "test label"});
        }
    }
}