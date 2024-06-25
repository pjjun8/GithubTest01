

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String start = "시작";
            String stop = "가만히";
            String end = "끝";

            Console.WriteLine($"{start}이 반이다. {stop} 있으면 반이라도 간다. = {start}하고 {stop}있으면 {end}이다.");
            //1. 변수선언 및 입력부
            Console.Write("밑변을 입력해 주세요 : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("높이를 입력해 주세요 : ");
            int height = int.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            double result = (width * height)/2.0;

            //3. 출력부
            Console.WriteLine($"넓이는 {result} 입니다.");
        }
    }
}
