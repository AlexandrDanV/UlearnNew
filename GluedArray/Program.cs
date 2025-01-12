// See https://aka.ms/new-console-template for more information
using static GluedArray.Inheritance;

var ints = new[] { 1, 2 };
var intT = new[] { 3, 4 };
var strings = new[] { "A", "B" };

GluinArray.Print(GluinArray.Combine(ints, intT));
GluinArray.Print(GluinArray.Combine(ints, ints, ints));
GluinArray.Print(GluinArray.Combine(ints));
GluinArray.Print(GluinArray.Combine());
GluinArray.Print(GluinArray.Combine(strings, strings));
GluinArray.Print(GluinArray.Combine(ints, strings));
