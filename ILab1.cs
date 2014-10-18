using System;

namespace OOP1Labs
{
	public interface ILab1
	{
		#region Basic Arithmetic
		/// <title>Addition</title>
		/// <signature>int Add(int x, int y);</signature>
		/// <summary>Metoden ska utföra addition av heltal.</summary>
		/// <returns>Summan av de två talen.</returns>
		int Add(int x, int y);

		/// <title>Subtraktion</title>
		/// <signature>int Subtract(int x, int y);</signature>
		/// <summary>Metoden ska utföra subtraktion av heltal.</summary>
		/// <returns>Differensen mellan de två talen.</returns>
		int Subtract(int x, int y);

		/// <title>Multiplikation</title>
		/// <signature>int Multiply(int x, int y);</signature>
		/// <summary>Metoden ska utföra multiplikation av de två talen.</summary>
		/// <returns>Produkten av de två talen.</returns>
		int Multiply(int x, int y);
		#endregion





		#region String manipulation
		/// <title>Välkomsttext</title>
		/// <signature>string Hello(string name);</signature>
		/// <summary>Metoden returnerar ett hälsningsmeddelande innehållande det inmatade namnet.</summary>
		/// <returns>En sträng på formen <code>"Hello, [name]."</code></returns>
		string Hello(string name);
		#endregion




		#region Data types and division
		/// <title>Heltalsdivision</title>
		/// <signature>int DivideIntegers(int numerator, int denominator);</signature>
		/// <summary>Metoden utför heltalsdivision. Om användaren försöker dela med 0 så ska programmet krascha.</summary>
		/// <param name="numerator">Täljaren</param>
		/// <param name="denominator">Nämnaren</param>
		/// <returns>Heltalskvoten av de två talen.</returns>
		int DivideIntegers(int numerator, int denominator);

		/// <title>Division ifrån heltal till decimaltal</title>
		/// <signature>double Divide(int numerator, int denominator);</signature>
		/// <summary>Utför division på heltal, men där resultatet ges på decimalform. Om användaren försöker dela med 0 så ska programmet krascha.</summary>
		/// <param name="numerator">Täljaren</param>
		/// <param name="denominator">Nämnaren</param>
		/// <returns>Kvoten av de två talen, inklusive decimaler.</returns>
		double Divide(int numerator, int denominator);

		/// <title>Division med decimaltal</title>
		/// <signature>double Divide(double numerator, double denominator);</signature>
		/// <summary>Utför division på heltal, men där resultatet ges på decimalform. Om användaren försöker dela med 0 så ska programmet krascha.</summary>
		/// <param name="numerator">Täljaren</param>
		/// <param name="denominator">Nämnaren</param>
		/// <returns>Kvoten av de två talen, inklusive decimaler.</returns>
		double Divide(double numerator, double denominator);

		/// <title>Division med decimaltal till heltal</title>
		/// <signature>int DivideAndTruncate(double numerator, double denominator);</signature>
		/// <summary>Utför division på decimaltal (d.v.s. ej heltalsdivision), men trunkerar sedan decimalerna och returnerar ett heltal.</summary>
		/// <param name="numerator">Täljaren</param>
		/// <param name="denominator">Nämnaren</param>
		/// <returns>Kvoten av de två talen, med trunkerade decimaler.</returns>
		int DivideAndTruncate(double numerator, double denominator);

		/// <title>Division med Rest</title>
		/// <signature>string DivideWithRemainder(int numerator, int denominator);</signature>
		/// <summary>Utför division och returnerar en sträng som förtäljer resultatet av heltalsdivisionen, samt kvarvarande rest. Om användaren försöker dela med 0 så ska programmet krascha.</summary>
		/// <param name="numerator">Täljaren</param>
		/// <param name="denominator">Nämnaren</param>
		/// <returns>En sträng på formen <code>"[numerator] dividerat med [denominator] ger [z], rest [w]."</code>. Där <code>[z]</code> motsvarar heltalskvoten, och <code>[w]</code> resten efter utförd division.</returns>
		string DivideWithRemainder(int numerator, int denominator);
		#endregion






		#region Comparison Operators (and code reuse)
		/// <title>Största av två tal</title>
		/// <signature>int Greatest(int x, int y);</signature>
		/// <summary>Hittar det största talet av två tal.</summary>
		/// <returns>Det största talet.</returns>
		int Greatest(int x, int y);

		/// <title>Störst av tre tal</title>
		/// <signature>int Greatest(int x, int y, int z);</signature>
		/// <summary>Hittar det största talet bland tre tal.</summary>
		/// <returns>Det största talet.</returns>
		int Greatest(int x, int y, int z);

		/// <title>Störst av fyra tal</title>
		/// <signature>int Greatest(int x, int y, int z, int w);</signature>
		/// <summary>Hittar det största talet bland tre tal.</summary>
		/// <returns>Det största talet.</returns>
		int Greatest(int x, int y, int z, int w);

		/// <title>Större än?</title>
		/// <signature>int IsGreater(int x, int y);</signature>
		/// <summary>Undersöker det andra talet är större än det första.</summary>
		/// <returns><code>true</code> om det andra talet är större än det första. Annars <code>false</code>.</returns>
		int IsGreater(int x, int y);
		#endregion




		#region Logical Operators
		/// <title>AND</title>
		/// <signature>bool And(bool a, bool b);</signature>
		/// <summary>Utför logisk AND.</summary>
		/// <returns><code>true</code> om både <code>a</code> och <code>b</code> är <code>true</code>. Annars <code>false</code>.</returns>
		bool And(bool a, bool b);

		/// <title>OR</title>
		/// <signature>bool Or(bool a, bool b);</signature>
		/// <summary>Utför logisk OR.</summary>
		/// <returns><code>true</code> om <code>a</code> eller <code>b</code> är <code>true</code>. Annars <code>false</code>.</returns>
		bool Or(bool a, bool b);

		/// <title>XOR</title>
		/// <signature>bool Xor(bool a, bool b);</signature>
		/// <summary>Utför logisk XOR.</summary>
		/// <returns><code>true</code> om antingen <code>a</code> eller <code>b</code> är <code>true</code>, men <code>false</code> om både <code>a</code> och <code>b</code> är <code>true</code>. I alla andra fall <code>false</code>.</returns>
		bool Xor(bool a, bool b);

		/// <title>NOT</title>
		/// <signature>bool Not(bool a);</signature>
		/// <summary>Utför logisk NOT.</summary>
		/// <returns><code>true</code> om <code>a</code> är <code>false</code>, och vice versa.</returns>
		bool Not(bool a);
		#endregion







		#region Conversions
		/// <title>Konvertera Heltal till Sträng</title>
		/// <signature>string IntToString(int number);</signature>
		/// <summary>Konverterar ett numeriskt heltal till dess strängrepresentation.</summary>
		/// <returns>En sträng som innehåller det numeriska tal som gavs.</returns>
		/// <example>
		/// <code>IntToString(4030);</code>
		/// <returns>"4030"</returns></example>
		string IntToString(int number);

		/// <title>Konvertera Sträng till Heltal</title>
		/// <signature>int StringToInt(string number);</signature>
		/// <summary>Konverterar en sträng som innehåller ett numeriskt tal till numerisk heltalsform. Om användaren försöker skicka någonting som inte är en siffra så ska programmet krascha. Eventuella 0:or i början ska elimineras.</summary>
		/// <returns>Ett numeriskt tal som motsvarar den sträng som gavs.</returns>
		/// <example>
		/// <code>StringToInt("0320");</code>
		/// <returns>0320</returns></example>
		int StringToInt(string number);
		#endregion




		#region Assignments
		/// <title>Kvinna eller Man</title>
		/// <signature>string Gender(string pnr);</signature>
		/// <summary>Undersöker om de fyra sista siffrorna i ett personnummer tillhör en man eller en kvinna. Alla personnummer som ges till denna metod måste innehålla exakt fyra siffror. All annan form av input resulterar i ett felmeddelande enligt nedan. Om den näst sista siffran är jämn så tillhör personnumret en kvinna, och vice versa för en man.</summary>
		/// <returns>Strängen <code>"WOMAN"</code> om personnumret tillhör en kvinna. Strängen <code>"MAN"</code> om personnumret tillhör en man. Strängen "BAD INPUT" om personnumret inte uppfyllde kraven.</returns>
		string Gender(string pnr);

		/// <title>Karusellåkning</title>
		/// <signature>bool CanJoyride(int age, int cm, bool hasHeartCondition);</signature>
		/// <summary>Undersöker huruvida en person får åka karusell eller inte. Kraven för att få åka karusell är att vara 12 år eller över, emellan 150 och 210 cm lång, och att en är fri ifrån hjärtproblem.</summary>
		/// <param name="age">Ålder i hela år</param>
		/// <param name="cm">Längd i centimeter</param>
		/// <param name="hasHeartCondition">Har personen hjärtproblem?</param>
		/// <returns><code>true</code> om personen får åka karusell och vice versa.</returns>
		bool CanJoyride(int age, int cm, bool hasHeartCondition);

		/// <title>Skottår</title>
		/// <signature>bool IsLeapYear(int year);</signature>
		/// <summary>Avgör huruvida ett år är ett skottår eller inte. Om årtalet som ges är negativt så ska metoden alltid returnera <code>false</code>.</summary>
		/// <returns><code>true</code> om året året är ett skottår och vice versa.</returns>
		bool IsLeapYear(int year);
		#endregion
	}
}

