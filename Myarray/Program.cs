// See https://aka.ms/new-console-template for more information
using OppConcepts.Logic;

try
{
	Console.WriteLine("Hello, World!");
	var mymatrix = new MyMatrix();
	mymatrix.Fill();
	var mainDiagnol = mymatrix.GetMainDiagnol();
    Console.WriteLine("**Matrix***");
    Console.WriteLine(mymatrix);
    Console.WriteLine("**MainDiagnol***");
    Console.WriteLine(mainDiagnol);
    var SecondaryDiagnol = mymatrix.GetSecondaryDiagnol();
    Console.WriteLine("**SecondaryDiagnol***");
    Console.WriteLine(SecondaryDiagnol);
    var UpperDiagnol = mymatrix.GetUpperDiagnol();
    Console.WriteLine("**Upper Diagnol***");
    Console.WriteLine(UpperDiagnol);
    var LowerDiagnol = mymatrix.GetLowerDiagnol();
    Console.WriteLine("**Lower Diagnol***");
    Console.WriteLine(LowerDiagnol);
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}