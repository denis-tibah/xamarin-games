using System;

namespace MWC.BL
{
	public partial class Speaker : Contracts.BusinessEntityBase
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public string Company { get; set; }
		
		public Speaker ()
		{
		}
	}
}

