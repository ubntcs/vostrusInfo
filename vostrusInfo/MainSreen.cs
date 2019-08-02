using System;
using Gtk;
namespace vostrusInfo
{
	public partial class MainSreen : Gtk.Window
	{
		public MainSreen () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		public static void Main(){
			Application.Init ();
			MainSreen m=new MainSreen();
			m.Show ();
			Application.Run ();

		}

		protected void OnButton1Clicked (object sender, EventArgs e)
		{
		
		}

		protected void OnFixed1Removed (object o, RemovedArgs args)
		{
			RootWindow.Destroy ();
		}

		protected void OnMenubar1SelectionDone (object sender, EventArgs e)
		{
		/*
		 string systemTitle = "vostrusInfo";
			telaCadastro t1 = new telaCadastro ();

			switch(menubar1.){

			case "cadastrarUsuario":
				t1.Title = systemTitle;
				t1.Show ();
				break;
			default:
				this.Destroy();
				break;
			}
			*/
		}


		protected void OnCadastrarUsuarioAction1Activated (object sender, EventArgs e)
		{
			string systemTitle = "vostrusInfo";
			telaCadastro t1 = new telaCadastro ();
			t1.Title = systemTitle;
			t1.Show ();
		}
		protected void OnSairActionActivated (object sender, EventArgs e)
		{
			this.Destroy ();
		}



		}
	}

