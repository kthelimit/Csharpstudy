# 240117
* 이번 시간에는 ArrayList와 List를 활용해 각 VO클래스를 관리하기 위한 리스트를 만드는 법에 대해서 배웠다.
* ArrayListTest에서는 ArrayList에 대해서 학습했다.
* ScoreList2에서는 ArrayList에 대해 배운 것을 기반으로 List<ScoreVo>를 사용해 ScoreVo 객체들을 관리하는 코드를 작성했다.
* MemoTest에서는 ScoreList2에서 배운 내용에서 더 나아가 메모를 작성하고, 비밀번호를 입력해 글을 삭제하는 부분까지 구현했다.

## ArrayListTest
### 컬렉션 : 객체를 그룹화할때 쓰는 방법 중 하나. 
* 배열과 달리 개체 그룹이 동적으로 확장되거나 축소될 수 있다.
* 일부 컬렉션의 경우, 키를 사용하여 객체를 신속하게 검색 가능.
### 컬렉션의 종류
* System.Collections 클래스나 Systen.Collections.Generic 클래스가 필요함
* 구체적 형식의 개체가 아닌 Object 형식의 개체로 요소에 저장.
* ArrayList / HashTable / Queue / Stack 이 있음
* ArrayList : 필요에 따라 동적으로 크기가 증가하는 배열
'''
ArrayList list = new ArrayList();
'''
* ArrayList에는 온갖 것들을 넣을 수 있다.
* List는 선언시 특정한 자료형을 명시하고 그 자료형만 넣을 수 있다.
## ScoreList2
* 처음에는 ArrayList를 사용해서 ScoreVo 객체들을 관리하려고 하였으나 ArrayList에는 여러 종류의 자료형을 넣을 수 있다보니 ScoreVo클래스에 설정해둔 메서드에 접근하기 어려웠다.
  * List<ScoreVo>를 활용하는 것으로 문제가 해결되었다.
## MemoTest
* List를 이용해 메모를 작성하고 그것을 읽어오거나 수정하고 삭제하는 스크립트를 작성하는 것이 목표로 현재 비밀번호를 입력받아 삭제하는 것까지 구현에 성공했다.(수정에 대한 부분은 다음 시간에 마저 진행할 예정이다)
  * 삭제하고자 하는 글 번호를 입력하고 비밀번호를 입력받아 비밀번호가 일치하면 글을 삭제한다.
  * 처음에는 메모를 삭제해도 글 번호가 바뀌지않게 할 계획이었으나 리스트 내의 아이템이 하나 삭제되면 리스트의 사이즈가 조정되면서 인덱스 번호가 바뀌어버리기 때문에 부득이하게 삭제할 때마다 글 번호를 전부 다시 붙이도록 바꾸었다.
