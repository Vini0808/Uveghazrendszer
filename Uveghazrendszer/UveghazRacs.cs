namespace Uveghazrendszer
{
	internal class UveghazRacs
	{
		int meret;
		Cella[,] agyasok;
		static Random rnd = new Random();

		public UveghazRacs(int meret)
		{
			this.meret = meret;
			this.agyasok = new Cella[meret, meret];
		}

		public void Parcellazas()
		{
			for (int i = 0; i < meret; i++) //sorok
			{
				for (int j = 0; j < meret; j++) //oszlopok
				{
					this.agyasok[i, j] = new Cella(i, j);
				}
			}
		}

		public void Ultetes(List<NovenyFaj> novenyek)
		{
			int index = 0;
			for (int i = 0; i < meret; i++) //sorok
			{
				for (int j = 0; j < meret; j++) //oszlopok
				{
					if(index < novenyek.Count)
					{
						agyasok[i, j].Telepit(novenyek[index++], rnd.Next(-1, 15));
					}
				}
			}
		}

		public void MatrixKiir()
		{
			for (int i = 0; i < meret; i++) //sorok
			{
				Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
				for (int j = 0; j < meret; j++) //oszlopok
				{
					Console.Write(agyasok[i,j]+"\t");
				}
				Console.WriteLine();
				Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
			}
		}
	}		
}
