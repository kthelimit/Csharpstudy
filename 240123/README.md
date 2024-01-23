# 240123
* 오늘은 그동안 배운 것들을 활용해서 빙고게임을 제작해보았다.
* 처음엔 main에 전부 작성해보고, 그 후에는 메서드로 따로 빼보는 작업을, 그리고 그 후에는 클래스를 분리해보는 작업을 진행했다.
* Bingo를 abstract 클래스로 하고 SelectNum()을 abstract 메서드로 선언하여 파생클래스인 User와 Com에서 각각 구현하게 했다.
* Bingo의 PrintBingoBoard()를 virtual 메서드로 선언해서 파생 클래스인 User와 Com에서 조금만 덧붙여 사용할 수 있게 했다.
