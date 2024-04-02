namespace TipoCalculator
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        public void PercentageSlider_ValueChanged(object sender, EventArgs e)
        {
            TipoPorcentageLabel.Text = $" { PercentageSlider.Value.ToString()} %";
        }

        public void Button15Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 15;
        }

        public void Button30Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 30;
        }

        public void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            double valor = CalculateTip();
            TipLabel.Text = $"R${Math.Ceiling(valor).ToString("C2")}";

            //1-Chamar o método que calcula a gorjeta
            //2-Armazenar esse valor em uma vaariável
            //3-Exibir o valor da gorjeta arredondado para cima
            //4-Exibir o valor total da refeição
        }

        public void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

            //1-Chamar o método que calcula a gorjeta
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TipLabel.Text = Convert.ToString(tip);
            //2-Armazenar esse valor em uma vaariável
            //3-Exibir o valor da gorjeta arredondado para baixo
            double valorRefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            //4-Exibir o valor total da refeição
            TotalValueLabel.Text = valorRefeicao.ToString("C2");
        }

        public double CalculateTip()
        {

            //1-Pegar o valor da refeição
            //2-Armazenar esse valor em uma variável
            double valrefeicao = Convert.ToDouble(ValueEntry.Text);

            //3-Pegar o valor que o usuário definiu no slider
            double valPorcentagem = PercentageSlider.Value;

            //4-Calcular o valor da gorjeta
            double valorGorjeta = valrefeicao * (valPorcentagem / 100);

            //5-Retornar o valor do cálculo
            return (valorGorjeta);
            
        }
    }

}
