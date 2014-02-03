using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		labelSaludo.LabelProp = "Texto del label establecido en ejecución";
		
		entryNombre.Text = "Pon tu nombre, por favor";

		//Focus = entryNombre;
		
		buttonAceptar.Clicked += delegate {
			labelSaludo.LabelProp = "Hola " + entryNombre.Text;
		};
		
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
