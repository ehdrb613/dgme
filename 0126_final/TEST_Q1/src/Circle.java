
public class Circle {
	double rad = 0;
	final double PI = 3.14;
	
	public Circle(double r) 
	{
		rad=r;
		if(r>0)
		System.out.println("원넓이 : "+getArea());
		else
		System.out.println("음수입니다.");
	}
	
	public double getArea() {return(rad*rad)*PI;}
}
