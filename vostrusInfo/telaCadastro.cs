using System;
using Gtk;

namespace vostrusInfo
{
	public partial class telaCadastro : Gtk.Window
	{
		public telaCadastro () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnFixed2DeleteEvent (object o, Gtk.DeleteEventArgs args)
		{
			this.Destroy ();
		}

		protected void OnFixed2Removed (object o, Gtk.RemovedArgs args)
		{

		}

		public void cad(){
			//clicked button
			if(!string.IsNullOrEmpty(entry1.Text)){
			user us1 = new user ();
			//us1.Name = name.Text;
			us1.Name = entry1.Text;
			res.Text = us1.Name;
			entry1.Text = "";

				MessageDialog dm = new MessageDialog (null,
				                                     DialogFlags.DestroyWithParent,
				                                      MessageType.Info,ButtonsType.Ok,
				                                      "cadastrado om sucesso!"
				                                      );
				dm.Run ();
				dm.Destroy ();



		}
		}
		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			cad ();
		}

		protected void OnEntry1Activated (object sender, EventArgs e)
		{
			cad ();
		}
	}
}

