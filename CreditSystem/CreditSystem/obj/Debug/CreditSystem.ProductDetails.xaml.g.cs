// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CreditSystem {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/maysan/Projects/CreditSystem/CreditSystem/ProductDetails.xaml")]
    public partial class ProductDetails : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry CreditEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Slider CreditSlider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Picker CurrencyPicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry FixedTermEntry;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Slider FixedTermSlider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ListView opports;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label credit;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label rate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label monthlypayment;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ProductDetails));
            CreditEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Entry>(this, "CreditEntry");
            CreditSlider = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Slider>(this, "CreditSlider");
            CurrencyPicker = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Picker>(this, "CurrencyPicker");
            FixedTermEntry = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Entry>(this, "FixedTermEntry");
            FixedTermSlider = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Slider>(this, "FixedTermSlider");
            opports = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.ListView>(this, "opports");
            credit = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "credit");
            rate = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "rate");
            monthlypayment = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "monthlypayment");
        }
    }
}