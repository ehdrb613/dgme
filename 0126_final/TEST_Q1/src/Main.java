import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("반지름 입력 : ");
		double rad = s.nextDouble();
		new Circle(rad);
		
	}

}
