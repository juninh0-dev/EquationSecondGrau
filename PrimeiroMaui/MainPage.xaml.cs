
namespace PrimeiroMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text);
            if(a == 0)
            {
                string msg = $"O valor de A tem que ser diferente de 0!";

                DisplayAlert("Ta errado fião", msg, "Fechar");

                return;
            }
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            double d = (b*b -(4 * a *c) );

            double root = Math.Sqrt(d);

            double x1 = ((- b + root) / (2*a));
            double x2 = ((- b - root) / (2*a));

            string msg2 = $"O resultado do X positivo:" + "\n" + x1 + "\n" +
                "E negativo:" + "\n" + x2;

            

            if(d < 0)
            {
                string msg3 = $"O delta é igual {d} não há raiz"; 

                DisplayAlert("Não há raiz", msg3, "Fechar");
            }
            else
            {

                DisplayAlert("Resposta:", msg2, "Fechar");
            }

        }
    }
    
}

