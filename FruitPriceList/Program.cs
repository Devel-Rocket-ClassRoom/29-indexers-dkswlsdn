using System;

FruitPriceList fruitPriceList = new FruitPriceList(5);

fruitPriceList.Add("사과", 1500);
fruitPriceList.Add("바나나", 3000);
fruitPriceList.Add("딸기", 8000);

Console.WriteLine($"등록된 과일 수: {fruitPriceList.Count}개\n");

Console.WriteLine($"사과 가격: {fruitPriceList["사과"]}원");
Console.WriteLine($"바나나 가격: {fruitPriceList["바나나"]}원");
Console.WriteLine($"포도 가격: {fruitPriceList["포도"]}원");

Console.WriteLine();

Console.WriteLine($"0번: {fruitPriceList[0]}");
Console.WriteLine($"1번: {fruitPriceList[1]}");
Console.WriteLine($"2번: {fruitPriceList[2]}");