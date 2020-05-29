using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AiFormsPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            List<string> loanType = new List<string>(new List<string> {
               "test001", "test002","test003","test004"
            });

            if (Device.RuntimePlatform == Device.Android)
            {
                loanType.Reverse();
            }

            LoanType.Items = loanType;  //set the data source
        }
    }
}
