﻿string a = null;
string b = "";
string c = string.Empty;
string d = "hola\n\t\\amigo";
string e = @"hola\n\t\\amigo";
Console.WriteLine(d);
Console.WriteLine(e);
var h = e.Substring(4, 6);
Console.WriteLine(h);
var i = e.Replace(h, "*");
Console.WriteLine(i);
var j = e.IndexOf("o",2);
Console.WriteLine(j);

var f = "examen";
var g = "final";
f += g;
Console.WriteLine(f);

var n = "Carlos Perez";
var x = n.IndexOf(" ");
var nom = n.Substring(0,x);
Console.WriteLine(nom);

var y = "carlos; jose;   renzo";
var z = y.Split(";");
foreach(var tex in z) {
    Console.WriteLine(tex.Trim());
}


string aa = "paciencia y constancia";
int cc = aa.IndexOf("cia");
Console.WriteLine(cc);
string bb = aa.Substring(cc, 2);
Console.WriteLine(bb);