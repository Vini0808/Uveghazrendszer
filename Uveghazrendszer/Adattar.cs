using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uveghazrendszer
{
	internal class Adattar
	{
		List<NovenyFaj> novenyek;
		public Adattar()
		{
			this.novenyek = new List<NovenyFaj>();
		}

		public void UjNoveny(NovenyFaj noveny)
		{
			this.novenyek.Add(noveny);
		}
		public void NovenyekListazasa()
		{
			foreach (var item in this.novenyek)
			{
				Console.WriteLine(item);
			}
		}
	}
}
