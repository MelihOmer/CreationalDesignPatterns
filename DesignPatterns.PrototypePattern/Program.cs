// See https://aka.ms/new-console-template for more information


using DesignPatterns.PrototypePattern.Models;

Savasci savasciCan = new Savasci(saglik: 500, 150, "Savaşçı Birlik", "Dev");

Savasci savasciGuc = (Savasci)savasciCan.Clone();
savasciGuc.Saglik = 300;
savasciGuc.Guc = 400;
savasciGuc.Turu = "Barbar";

Console.WriteLine($"SavasciCan Özellikleri\nsağlık : {savasciCan.Saglik}\nGüç : {savasciCan.Guc}\nBirliği : {savasciCan.Adı}\nTürü : {savasciCan.Turu}");

Console.WriteLine("------------------------------------------------------------------------");

Console.WriteLine($"SavasciGüç Özellikleri\nsağlık : {savasciGuc.Saglik}\nGüç : {savasciGuc.Guc}\nBirliği : {savasciGuc.Adı}\nTürü : {savasciGuc.Turu}\n");
Console.WriteLine("Nesneler BirBirlerine Eşitmi ?");
if (savasciCan.Equals(savasciGuc))
    Console.WriteLine("SavasciCan = SavasciGuc");
else Console.WriteLine("SavasciCan != SavasciGüc");