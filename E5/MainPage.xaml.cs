namespace E5;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        int Base1 = Convert.ToInt32(Base.Text);
        int Altura1= Convert.ToInt32(Altura.Text);

        int r1 = Base1 + Altura1 + Altura1 + Base1;
        int r2 = Base1 * Altura1;

        la.Text = "El perimetro es " + r1 + " la superficie es " + r2;
    }
}

