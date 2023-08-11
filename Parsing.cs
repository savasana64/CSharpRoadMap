//parse numbers out of strings

string myString = "15";
string mySecondString = "13";

//parse strings to integers

int num1 = Int32.Parse(myString);
int num2 = Int32.Parse(mySecondString);

int resultInt = num1 + num2;
Console.WriteLine(resultInt);

string stringForFloat = "0.85"; // datatype should be float
string stringForInt = "12345"; // datatype should be int

//parse strings to float

float parsedFloat = float.Parse(stringForFloat);
int parsedInt = Int32.Parse(stringForInt);

Console.WriteLine(parsedInt);
Console.WriteLine(parsedFloat);





