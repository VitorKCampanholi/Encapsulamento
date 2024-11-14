using Encapsulamento;
using System;
using System.Globalization;

Produto p = new Produto("TV", 500.00, 10);

p.SetNome("T");

Console.WriteLine(p.GetNome());
Console.WriteLine(p.GetPreco());
 