namespace E5;

public partial class MainPage : ContentPage
{

///<Summary>
///<Createddate>27/6/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>27/6/2023</lastmodificationdate>
///<lastmodificationdescription>
///Se reciben valores se guardan en varibles luego se hacen las operaciones para obtener los resultados requeridos
///</lastmodificationdescription>
//////<lastmodifierautor>Fernando</lastmodifierautor>
///</Summary>
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

