using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
		Gdk.Color greenColor = new Gdk.Color(0, 255, 0);
		
		int count = arrayButton.Rows * arrayButton.Columns;
		for (int index = 0; index < count; index++) {
			arrayButton.Get (index).Label = string.Format ("{0}", index + 1);
			if (index % 2 == 0)
				arrayButton[index]. ModifyBg (StateType.Normal, greenColor);
		}
		
		arrayButton.Get(2, 4).Label = "*";
		arrayButton[3, 5].Label = "**";
		
		arrayButton.SetLabels (new string[]{"Uno", "Dos", "Tres"});
		arrayButton.SetLabels (new string[]{"Uno", "Dos", "Tres", "Cuatro"});
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
