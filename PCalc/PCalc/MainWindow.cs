using System;
using Gtk;

//TODO Al hacer click en buttonSumar, sumar los números en entry1 y entry2 mostrando el resultado en entryResult

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		
//		entry1.KeyPressEvent += delegate(object o, KeyPressEventArgs args) {
//			Console.WriteLine ("entry1.KeyPressEvent args.Event.Key={0}", args.Event.Key);
//			if (args.Event.Key == Gdk.Key.KP_Decimal) {
//				args.RetVal = false;
//			}
//		};
		
		foreach (Button item in new Button[]{button1, button2})
			item.Clicked += delegate(object sender, EventArgs e) {
				Button button = (Button)sender;
				Entry entry = Focus as Entry;
				if (entry != null)
					entry.Text = entry.Text + button.Label;
			};
		
		buttonSumar.Clicked += delegate {
			decimal d1 = decimal.Parse(entry1.Text);
			entryResult.Text = d1.ToString ();
		};
		
	}
	
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
