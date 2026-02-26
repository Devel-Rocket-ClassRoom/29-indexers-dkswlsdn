using System;


ScoreBoard scoreBoards = new ScoreBoard(5);

scoreBoards.Register("김민수", 85);
scoreBoards.Register("이지영", 92);
scoreBoards.Register("박서준", 78);

Console.WriteLine($"등록된 학생 수: {scoreBoards.Count}명\n");

Console.WriteLine($"1번: {scoreBoards[0]}");
Console.WriteLine($"2번: {scoreBoards[1]}");
Console.WriteLine($"3번: {scoreBoards[2]}");

Console.WriteLine();

Console.WriteLine($"김민수 점수: {scoreBoards["김민수"]}점");
Console.WriteLine($"이지영 점수: {scoreBoards["이지영"]}점");
Console.WriteLine($"홍길동 점수: {scoreBoards["홍길동"]}점");

Console.WriteLine();

scoreBoards["김민수"] = 95;

Console.WriteLine($"김민수 수정된 점수: {scoreBoards["김민수"]}점");