
using MauiApp5.Model;

namespace MauiApp5;

public partial class MainPage : ContentPage
{
	public List<Memori> LL { get; set; }
	public Memori MM { get; set; }
 

    public MainPage()
	{
		LL = new List<Memori>();
        Memori WW = new Memori();
        Memori EE = new Memori();
        Memori RR = new Memori();
        MM = new Memori();
		WW.fami = "QWQ";
		WW.name = "OWO";
		WW.secondName = "OUO";
		EE.fami = "YIY";
		EE.name = "UIU";
		EE.secondName = "OIO";
		RR.fami = "aweq";
		RR.name = "ASD";
		RR.secondName = "ZXC";
        InitializeComponent();
        LL.Add(WW);
		LL.Add(EE);
		LL.Add(RR);
		
		LL.Add(MM);
	
		
        BindingContext = this;
		
	
	}

	public void Picker_SelectedIndexChanged(object sender, EventArgs e)
	{
		Fami.SetBinding(Entry.TextProperty, "MM.Fami");
        labelFami.SetBinding(Label.TextProperty, "MM.Fami");
		Name.SetBinding(Entry.TextProperty, "MM.Name");
		labelName.SetBinding(Label.TextProperty, "MM.Name");
		Second.SetBinding(Entry.TextProperty, "MM.SecondName");
		labelSecond.SetBinding(Label.TextProperty, "MM.SecondName");
		Source.SetBinding(Label.TextProperty, "MM.Sour");
		ImSource.SetBinding(Image.SourceProperty, "MM.Sour");
    }
}

