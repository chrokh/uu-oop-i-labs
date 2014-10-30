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
    /// <summary>Metoden returnerar ett hälsningsmeddelande innehållande det inmatade namnet. Om användaren skickar en tom sträng, eller <code>null</code>, (d.v.s. inget namn) så ska istället namnet <code>"Anonymous"</code> användas.</summary>
    /// <returns>En sträng på formen <code>"Hello, [name]."</code></returns>
    string Hello(string name);
    #endregion


    #region Data types and division
    /// <title>Heltalsdivision</title>
    /// <signature>int DivideIntegers(int numerator, int denominator);</signature>
    /// <summary>Metoden utför heltalsdivision.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>Heltalskvoten av de två talen.</returns>
    int DivideIntegers(int numerator, int denominator);

    /// <title>Division ifrån heltal till decimaltal</title>
    /// <signature>double Divide(int numerator, int denominator);</signature>
    /// <summary>Utför division på heltal, men där resultatet ges på decimalform.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>Kvoten av de två talen, inklusive decimaler.</returns>
    double DivideExact(int numerator, int denominator);

    /// <title>Division med decimaltal</title>
    /// <signature>double Divide(double numerator, double denominator);</signature>
    /// <summary>Utför division på heltal, men där resultatet ges på decimalform.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>Kvoten av de två talen, inklusive decimaler.</returns>
    double DivideExact(double numerator, double denominator);

    /// <title>Division med decimaltal till heltal (trunkering)</title>
    /// <signature>int DivideAndTruncate(double numerator, double denominator);</signature>
    /// <summary>Utför division på decimaltal (d.v.s. ej heltalsdivision), men trunkerar sedan decimalerna och returnerar ett heltal.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>Kvoten av de två talen, med trunkerade decimaler.</returns>
    int DivideAndTruncate(double numerator, double denominator);

    /// <title>Division med decimaltal till heltal (avrundning)</title>
    /// <signature>int DivideAndRound(double numerator, double denominator);</signature>
    /// <summary>Utför division på decimaltal (d.v.s. ej heltalsdivision), och avrundar sedan till närmaste heltal.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>Kvoten av de två talen, avrundat till närmaste heltal.</returns>
    int DivideAndRound(double numerator, double denominator);

    /// <title>Division med Rest</title>
    /// <signature>string DivideWithRemainder(int numerator, int denominator);</signature>
    /// <summary>Utför division och returnerar en sträng som förtäljer resultatet av heltalsdivisionen, samt kvarvarande rest.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>En sträng på formen <code>"[numerator] divided by [denominator] gives [z], remainder [w]."</code>. Där <code>[z]</code> motsvarar heltalskvoten, och <code>[w]</code> resten efter utförd division.</returns>
    string DivideWithRemainder(int numerator, int denominator);

    /// <title>Division med Absolut Rest</title>
    /// <signature>string DivideWithAbsoluteRemainder(int numerator, int denominator);</signature>
    /// <summary>Utför division och returnerar en sträng som förtäljer resultatet av heltalsdivisionen med absolut rest. Om det absoluta värdet av distansen emellan täljaren ("numerator") och den positiva resten är lika stor som värdet av distansen emellan täljaren ("numerator") och den negativa resten, så välj alltid den positiva resten, annars välj den minsta resten.</summary>
    /// <param name="numerator">Täljaren</param>
    /// <param name="denominator">Nämnaren</param>
    /// <returns>En sträng på formen <code>"[numerator] divided by [denominator] gives [z], remainder [w]."</code>. Där <code>[z]</code> motsvarar heltalskvoten givet absolut rest, och <code>[w]</code> den absoluta resten.</returns>
    /// <example>
    /// <code>DivideWithAbsoluteRemainder(8, 3);</code>
    /// <returns>"8 divided by 3 gives 3, remainder -1."</returns></example>
    string DivideWithAbsoluteRemainder(int numerator, int denominator);
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
    /// <signature>bool IsGreater(int x, int y);</signature>
    /// <summary>Undersöker det första talet är större än det första.</summary>
    /// <returns><code>true</code> om det första talet är större än det andra. Annars <code>false</code>.</returns>
    bool IsGreater(int x, int y);
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
    /// <returns>320</returns></example>
    int StringToInt(string number);
    #endregion


    #region Assignments
    /// <title>Karusellåkning</title>
    /// <signature>bool CanJoyride(int age, int cm, bool hasHeartCondition);</signature>
    /// <summary>Undersöker huruvida en person får åka karusell eller inte. Kraven för att få åka karusell är att vara 12 år eller över, emellan 150 och 210 cm (inklusive) lång, och att en är fri ifrån hjärtproblem. Myndiga personer får vara kortare än 150 cm, men inte kortare än 130 cm.</summary>
    /// <param name="age">Ålder i hela år</param>
    /// <param name="cm">Längd i centimeter</param>
    /// <param name="hasHeartCondition">Har personen hjärtproblem?</param>
    /// <returns><code>true</code> om personen får åka karusell och vice versa.</returns>
    bool CanJoyride(int age, int cm, bool hasHeartCondition);

    /// <title>Datumskillnader</title>
    /// <signature>string DateDistance(int y1, int m1, int d1, int y2, int m2, int d2);</signature>
    /// <summary>Räknar naivt ut skillnaden mellan de olika delarna av ett datum. Metoden ska alltid returnera skillnaden i positiva tal. Det spelar alltså ingen roll om A > B eller B > A. Metoden behöver inte ta hänsyn till att inkorrekta datum kan matas in. Metoden räknar på alla datum oavsett hur "orimliga" de är. Metoden ska alltså inte räkna ut hur mycket "större" det ena datumet är än det andra (eftersom det kräver information om dagar i månader etc.), istället ska den endast naivt visa den absoluta differensen emellan de två åren, de två månaderna och de två dagarna.</summary>
    /// <param name="y1">Första personens födelseår.</param>
    /// <param name="m1">Första personens födelsemånad.</param>
    /// <param name="d1">Första personens födelsedag.</param>
    /// <param name="y2">Andra personens födelseår.</param>
    /// <param name="m2">Andra personens födelsemånad.</param>
    /// <param name="d2">Andra personens födelsedag.</param>
    /// <returns>En sträng på formen <code>"[y] year(s), [m] month(s), and [d] day(s).</code></returns>
    string DateDistance(int y1, int m1, int d1, int y2, int m2, int d2);

    /// <title>Skottår</title>
    /// <signature>bool IsLeapYear(int year);</signature>
    /// <summary>Avgör huruvida ett år är ett skottår eller inte. Om årtalet som ges är negativt så ska metoden alltid returnera <code>false</code>.</summary>
    /// <returns><code>true</code> om året året är ett skottår och vice versa.</returns>
    bool IsLeapYear(int year);
    #endregion


    #region Selection
    /// <title>Ponny-klasser</title>
    /// <signature>string RequestPony(int age, int weight);</signature>
    /// <summary>Tar emot en ålder och en vikt, och berättar vilken ponny-klass den givna rytten tillåts rida. Om rytten är under 12 år så returneras texten <code>"Too young to compete."</code>. Om rytten väger över 65 kg returneras texten <code>"No ponies available for the given weight class."</code>. I alla andra fall så returneras en sträng på formen <code>"Class [X] pony"</code> där <code>[X]</code> motsvarar korrekt ponny-klass. För att få rida klass A måste rytten väga mindre eller lika med 30 kg. För att få rida klass B måste rytten väga mer än för att få rida klass A och mindre eller lika med 50 kg. För att få rida klass C måste rytten väga mer än för att få rida klass B och mindre eller lika med 65 kg. (PS. Notera att siffrorna är fiktiva)</summary>
    /// <param name="age">Ålder i hela år</param>
    /// <param name="weight">Vikt i hela kg</param>
    /// <returns>En sträng med information om vilken ponny rytten får rida, se beskrivning för närmare detaljer.</returns>
    string RequestPony(int age, int weight);

    /// <title>Vad serveras till lunch?</title>
    /// <signature>string WhatIsForLunch(string weekday);</signature>
    /// <summary>Returnerar en sträng som beksriver dagens lunch. Dagens lunch beror på veckodag, och gäller måndag till söndag enligt följande:
    /// <code>"Ratatouille"</code>,
    /// <code>"Pancakes and pea soup"</code>, 
    /// <code>"Winter vegetable stew"</code>, 
    /// <code>"Spinach and garlic pasta"</code>, 
    /// <code>"Sliders"</code>,
    /// <code>"Black bean quesadillas"</code>, 
    /// <code>"Raw food salad"</code>
    /// </summary>
    /// <param name="weekday">Veckodag på engelska. Anges på enligt någon av följande format: [<code>"MONDAY"</code>/<code>"Monday"</code>/<code>"monday"</code>/<code>"mon"</code>/<code>"1"</code>]</param>
    /// <returns>En sträng innehållandes dagens lunch. Vid inkorrekt input returneras strängen <code>"Incorrect input"</code></returns>
    string WhatIsForLunch(string weekday);

    /// <title>Går det att bada?</title>
    /// <signature>string IsBathReady(string containsWater, int degrees);</signature>
    /// <summary>Kajsa gillar att bada, dock tar vattnet ibland slut hemma och dessutom kan värmen variera ganska mycket. Denna metod undersöker om badet är redo. Kraven för att badet ska vara redo är att det måste finnas vatten, och att vattnet måste vara emellan 30 och 48 grader (inklusive).
    /// </summary>
    /// <param name="hasWater">Anger om badet innehåller vatten eller ej. Anges på enligt någon av följande format: [<code>"YES"</code>/<code>"Yes"</code>/<code>"yes"</code>/<code>"y"</code>/<code>"Y"</code>].</param>
    /// <param name="degrees">Hela grader i Celcius</param>
    /// <returns><code>true</code> om det är klart att bada, annars <code>false</code>.</returns>
    bool IsTheBathReady(string hasWater, int degrees);
    #endregion


    #region Iteration
    /// <title>Multiplikationstabellssumma</title>
    /// <signature>string MultiplicationTableSum(int factor, int start, int end);</signature>
    /// <summary>Denna metod skriver ut alla multiplikationer för faktorn <code>factor</code>, ifrån <code>start</code> till <code>end</code>, och summerar alla produkter.</summary>
    /// <param name="factor">Det tal vars multiplikationstabell som ska skrivas ut.</param>
    /// <param name="start">Första talet som ska multipliceras med <code>factor</code></param>
    /// <param name="end">Sista talet som ska multipliceras med <code>factor</code></param>
    /// <returns>En sträng enligt den form som anges i exemplet nedan. Om det inte finns några uträkningar att utföra så ska <code>"0"</code> returneras.</returns>
    /// <example>
    /// <code>MultiplicationTableSum(8, 3, 6);</code>
    /// <returns>"(2*3)+(2*4)+(2*5)+(2*6) = 6+8+10+12 = 36"</returns>
    /// </example>
    string MultiplicationTableSum(int factor, int start, int end);
    #endregion
  }
}
