int temperature = -5;
string stateOfMatter;

stateOfMatter = temperature < 0 ? "solid" : "liquid";

Console.WriteLine(stateOfMatter);

temperature += 30;

//here a nested if in ternary

stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";

//note: the expression a ? b : c ? d: e is evaluated as:
//a ? b : (c ? d: e)

Console.WriteLine(stateOfMatter);