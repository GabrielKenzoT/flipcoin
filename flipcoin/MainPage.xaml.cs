namespace flipcoin
{
    public partial class MainPage : ContentPage
    {
  

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            int coin = new Random.Next(2);

            if (coin ==0) {
                CoinImage.Source = "coroa.jeg";
            }
            if (coin ==1)
            {
                CoinImage.Source = "cara.jpeg";
            }


        }
    }

}
