using System;

namespace vostrusInfo
{
	public class user
	{
		private string name = null;
		private string creditCard=null;
		private string plano=null;
		private string attendance=null;

		public user ()
		{
		}

		public string Name{
			get{return this.name;}
			set{name = value;}

		}
		public string Atendance{
			get{return this.attendance;}
			set{name = value;}

		}
		public string CreditCard{
		get{return this.creditCard;}
			set{name = value;}

		}
		public string Plano{
			get{return this.plano;}
			set{name = value;}

		}

	}
}

