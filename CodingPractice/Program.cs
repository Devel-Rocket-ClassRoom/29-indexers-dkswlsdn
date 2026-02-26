using System;
using System.Collections;


Console.WriteLine("\n=============================");

Catalog catalog = new Catalog();

Console.WriteLine(catalog[0]);
Console.WriteLine(catalog[1]);
Console.WriteLine(catalog[2]);


Console.WriteLine("\n=============================");

Car car = new Car(3);

car[0] = "CLA";
car[1] = "CLS";
car[2] = "AMG";

for (int i = 0; i < car.Length; i++)
{
    Console.WriteLine(car[i]);
}


Console.WriteLine("\n=============================");

Week week = new Week(3);

week[0] = "일요일";
week[1] = "월요일";
week[2] = "화요일";

for (int i = 0;i < week.Length; i++)
{
    Console.WriteLine(week[i]);
}


Console.WriteLine("\n=============================");

NickName nickName = new NickName();

nickName["홍길동"] = "RedPlus";
nickName["김철수"] = "BlusStar";

Console.WriteLine($"{nickName["홍길동"]}, {nickName["김철수"]}");


Console.WriteLine("\n=============================");

MultiIndexer multiIndexer = new MultiIndexer();

multiIndexer[0] = "첫 번째 값";
multiIndexer["name"] = "홍길동";
multiIndexer["city"] = "서울";

Console.WriteLine($"multi[0] = {multiIndexer[0]}");
Console.WriteLine($"multi[\"name\"] = {multiIndexer["name"]}");
Console.WriteLine($"multi[\"city\"] = {multiIndexer["city"]}");


Console.WriteLine("\n=============================");

Example example = new Example();

example.Name = "홍길동";
Console.WriteLine(example.Name);

example[0] = "첫 번째";
example[1] = "두 번째";
Console.WriteLine($"{example[0]}, {example[1]}");