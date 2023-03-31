/* Given code :

for (int i = 1; i <= 3; i++)
			{
				for (int j = 1; j <= 5; j++)
				{
					Response.Write(j);
					if (j == 5)
					{
						Response.Write("<br>");
						for (int k = 1; k <= 1; k++)
						{
							for (int l = 5; l >= 1; l--)
							{
								Response.Write(l);
								if (l == 1)
								{
									Response.Write("<br>");
								}

							}


						}

					}

				}

			}

Kode ini akan menampilkan angka 1 hingga 5 secara horizontal sebanyak 3 baris, dan kemudian menampilkan angka 5 secara vertikal. Ini karena kondisi if (j == 5) terpenuhi pada setiap iterasi ke-5 dari loop dalam variabel j, yang mengakibatkan tulisan <br> ditambahkan di akhir setiap baris horizontal.
Jika tujuan dari kode ini adalah untuk menampilkan angka dari 1 hingga 5 secara horizontal sebanyak 3 baris, dan kemudian menampilkan angka dari 5 hingga 1 secara horizontal di bawahnya, maka berikut code nya

*/

for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Response.Write(j);
    }
    Response.Write("<br>");
}

for (int i = 1; i <= 1; i++)
{
    for (int j = 5; j >= 1; j--)
    {
        Response.Write(j);
    }
    Response.Write("<br>");
}
