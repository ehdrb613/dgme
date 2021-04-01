import java.util.Scanner;

public class Text {

	public static void main(String[] args) {
		char[] a = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x'};
		char[] han = {'ㄱ','ㄴ','ㄷ','ㄹ','ㅁ','ㅂ','ㅅ','ㅇ','ㅈ','ㅊ','ㅋ','ㅌ','ㅍ','ㅎ','ㅏ','ㅑ','ㅓ','ㅕ','ㅗ','ㅛ','ㅜ','ㅠ','ㅡ','ㅣ'}; 
		
		Scanner s = new Scanner(System.in);
		String input = s.next();
		
		//입력받은 길이 만큼 돌림
		for (int i = 0; i < input.length(); i++) {
			
			for (int j = 0; j < a.length; j++) {
				
				//입력받은 영문 확인 하고 한글로 변환
				if(a[j] == input.charAt(i)) {
					System.out.print(han[j]);
				}
			}	
		}
		
	}

}
