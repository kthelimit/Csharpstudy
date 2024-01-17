using System.Collections;

namespace ArrayListTest
{
    internal class ArrayListTest
    {
        static void Main(string[] args)
        {
            // 컬렉션 : 객체를 그룹화할때 쓰는 방법 중 하나
            // => 배열과 달리 개체 그룹이 동적으로 확장되거나 축소될 수 있다.
            // => 일부 컬렉션의 경우, 키를 사용하여 객체를 신속하게 검색 가능.
            // 컬렉션의 종류
            // System.Collections 클래스
            // => 구체적 형식의 개체가 아닌 Object 형식의 개체로 요소에 저장.
            // => ArrayList / HashTable / Queue / Stack 이 있음
            // ArrayList : 필요에 따라 동적으로 크기가 증가하는 배열
            // ArrayList list = new ArrayList();

            ArrayList list = new ArrayList();
            // ㄴ온갖걸 다 넣어서 연산 처리속도가 느릴 수 있음

            // Add() : 리스트 마지막에 요소 추가.
            list.Add("고길동");
            list.Add(100);
            list.Add('a');
            list.Add(true);
            list.Add(null);
            list.Add("고길동");

            // Count : ArrayList 요소의 개수
            Console.WriteLine(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("==========================");

            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            } // ArrayList에 다양한 타입의 데이터가 있으면 Object로 처리
            Console.WriteLine("==========================");

            // Contains() : 리스트에서 해당 데이터가 있는지 찾아보고 있으면 true, 없으면 false로 결과 반환

            Console.WriteLine(list.Contains('임'));
            Console.WriteLine(list.Contains('a'));
            Console.WriteLine("==========================");

            // IndexOf() : 리스트에서 해당 데이터가 있으면 요소의 인덱스를 반환.
            // => 해당 데이터가 없으면 -1을 반환한다.
            Console.WriteLine(list.IndexOf(null));
            Console.WriteLine(list.IndexOf(false));
            Console.WriteLine("==========================");

            // Remove() : 리스트에서 처음 발견되는 개체 제거
            list.Remove('a');
            list.Remove("고길동");
            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("==========================");
            // RemoveAt() : 리스트에서 지정돈 인덱스의 요소 제거
            list.RemoveAt(2);
            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("==========================");

            //Clear() : 모든 요소 제거
            list.Clear();

            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("==========================");

            list.Add("강아지");
            list.Add("고양이");
            list.Add(1);
            list.Add(false);
            list.Add(null);
            list.Add('b');
            list.Add("강아지");

            // Reverse() : 전체 요소 반전
            list.Reverse();
            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("==========================");

            // Sort() : 요소 정렬
         //   list.Remove(false);
       //     list.Sort();

            //foreach (Object obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("==========================");

            //List<int> list2 = new List<int>();
            // => List 선언시 특정한 자료형을 명시함
            //자료형이 정해져있음. 그래서 ArrayList보다 처리가 빠름


        }
    }
}
