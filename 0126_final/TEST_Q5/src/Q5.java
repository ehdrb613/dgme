import java.util.Scanner;

public class Q5 {

	public static void main(String[] args) {
		char[] a = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
		Scanner s = new Scanner(System.in);
		System.out.print("입력: ");
		String input = s.next();
		
		int countarray[] = new int[a.length];
		
		for (int i = 0; i < input.length(); i++) {
			
			for (int j = 0; j < a.length; j++) {
				if(input.charAt(i)==a[j]) {
					countarray[j] += 1;
				}
			}
				
		}
		
		for(int i = 0; i< a.length;i++) {
			if(countarray[i] != 0) {
				System.out.printf("%c 는 %d 글자 입니다.\n",a[i],countarray[i]);
			}
		}
	}
	

}
