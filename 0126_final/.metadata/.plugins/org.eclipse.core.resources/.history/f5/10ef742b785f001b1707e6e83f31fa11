
public class Student {
	private String name;
	private String num;
	private String sug;
	private String[][] student;
	int a = 0;
	public Student(String name, String num, String sug) {
		super();
		
		
		if(a!=0) {
			for (int i = 0; i < student.length; i++) {
			
				if(student[i][0]==name) {
					
					student[i][0] = name;
					student[i][1] = num;
					student[i][2] = sug;
					a--;//스택 초기화
				}
				
				else {
					student[a][0] = name;
					student[a][1] = num;
					student[a][2] = sug;	
				}
				
			}
		}
		
		if(a==0) {
			System.out.println(name);
			student[a][0] = name;
			student[a][1] = num;
			student[a][2] = sug;
		}
		a++;
	}
	
	public void ShowView() {
		
		for (int i = 0; i < student.length; i++) {
			for (int j = 0; j < student[i].length; j++) {
				System.out.print(student[i][j]+"\t");
			}
			System.out.println();
		}
	}
	
	
	
	
		
	
	
	
}
