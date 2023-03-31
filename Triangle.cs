/* Given code :

for (int i=1; i<=5; i++) {
	for (int j=4; j>=i; j--) {
		Response.write("  ");
	}for (int k=1; k<=i; k++) {
 		Response.write "*";
	}
	Response.writeline "<br>";
}

Berikut ini adalah penjelasan dan perbaikannya:
1. Kesalahan sintaks pada pemanggilan method Response.writeline, seharusnya adalah Response.WriteLine() dengan tanda kurung setelah nama method.
2. Kesalahan sintaks pada pemanggilan method Response.write, seharusnya adalah Response.Write() dengan tanda kurung setelah nama method.
3. Kesalahan pada baris ke-5, seharusnya ada spasi sebelum karakter "*" pada parameter method Response.Write().
4. Kesalahan pada baris ke-7, seharusnya nama method Response.WriteLine() ditulis dengan huruf "L" besar di awal kata "Line".

*/

for (int i = 1; i <= 5; i++) {
    for (int j = 4; j >= i; j--) {
        Response.Write("  ");
    }
    for (int k = 1; k <= i; k++) {
        Response.Write(" *");
    }
    Response.WriteLine("<br>");
}
