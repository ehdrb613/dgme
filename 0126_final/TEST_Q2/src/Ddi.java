import java.util.Scanner;

public class Ddi {

	public static void main(String[] args) {
		
		Scanner s = new Scanner(System.in);
		System.out.print("년도 입력 : ");
		int input = s.nextInt();
		
		int ddi = input%12;//12지신
		
		if(ddi == 1)
			System.out.println("닭");
		else if(ddi == 2)
			System.out.println("개");
		else if(ddi == 3)
			System.out.println("돼지");
		else if(ddi == 4)
			System.out.println("쥐");
		else if(ddi == 5)
			System.out.println("소");
		else if(ddi == 6)
			System.out.println("호랑이");
		else if(ddi == 7)
			System.out.println("토끼");
		else if(ddi == 8)
			System.out.println("용");
		else if(ddi == 9)
			System.out.println("뱀");
		else if(ddi == 10)
			System.out.println("말");
		else if(ddi == 11)
			System.out.println("양");
		else if(ddi == 0)
			System.out.println("원숭이");
	}

}
