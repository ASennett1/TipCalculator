namespace TipCalculator;

public partial class MainPage : ContentPage
{
    

    public MainPage()
    {
        InitializeComponent();
    }


    private void Tip15(object sender, EventArgs e)
    {
        double tipPercentage = 0.15;
        
        double billAmount;
        double.TryParse(txtBillAmount.Text, out billAmount);
        double tipAmount = billAmount * tipPercentage;
        double Total = billAmount + tipAmount;

        

        lblTipTotal.Text = "15% Tip: " + "$" + (tipAmount) + " | " + "Total: " + "$" + (Total);
    }

    private void Tip20(object sender, EventArgs e)
    {
        double tipPercentage = 0.20;
        
        double billAmount;
        double.TryParse(txtBillAmount.Text, out billAmount);
        double tipAmount = billAmount * tipPercentage;
        double Total = billAmount + tipAmount;

        

        lblTipTotal.Text = "20% Tip: " + "$" + (tipAmount) + " | " + "Total: " + "$" + (Total);
    }

    private void Tip25(object sender, EventArgs e)
    {
        double tipPercentage = 0.25;
        
        double billAmount;
        double.TryParse(txtBillAmount.Text, out billAmount);
        double tipAmount = billAmount * tipPercentage;
        double Total = billAmount + tipAmount;

        

        lblTipTotal.Text = "25% Tip: " + "$" + (tipAmount) + " | " + "Total: " + "$" + (Total);
    }
}