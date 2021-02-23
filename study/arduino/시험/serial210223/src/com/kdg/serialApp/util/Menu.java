package com.kdg.serialApp.util;

import java.util.Scanner;

public class Menu {
	
	public static final int TV_ON = 1;
	public static final  int TV_OFF = 2;
	public static final int HOTTER_ON = 3;
	public static final int CLEANER_ON = 4;
	public static final int PROGRAM_EXIT = 5;
	public static final int LOGOUT = 6;
	public static final int SERIAL_STOP = 7;
	public static final int SERIAL_START = 8;

	public static final int CMD_TV_ON = '1';
	public static final int CMD_TV_OFF = '2';
	public static final int CMD_HOTTER_ON = '3';
	public static final int CMD_CLEANER_ON = '4';


	public static final String ADMIN_ID = "admin";
	public static final String ADMIN_PW = "1234";
	public static final String GUEST_ID = "guest";
	public static final String GUEST_PW = "1234";
	
	
	public String login() {
		System.out.println("----------------");
		System.out.println("스마트홈 제어 로그인");
		System.out.println("----------------");
		Scanner a = new Scanner(System.in);
		System.out.print("아이디 입력:");
		String id = a.next();
		System.out.print("비밀번호 입력:");
		String pw = a.next();
		String flag = "";

		if (id.equals(ADMIN_ID) && pw.equals(ADMIN_PW)) {
			System.out.println("관리자 모드");
			flag = ADMIN_ID;
			
			return flag;
		}

		else if (id.equals(GUEST_ID) && pw.equals(GUEST_PW)) {
			System.out.println("사용자 모드");
			flag = GUEST_ID;
			return flag;
		}

		System.out.println("잘못 입력하였습니다.");
		return login();

	}
	
	
	public int GuestMenu(Scanner a) {

		System.out.println("------------------------------");
		System.out.println("스마트 홈 제어 v1.0");
		System.out.println("------------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.종료");
		System.out.println("6.로그아웃");
		System.out.println("------------------------------");

//		int menu = s.nextInt();
//		return menu;
		
		return a.nextInt();
	}
	
	
	public int AdminMenu(Scanner a) {

		System.out.println("------------------------------");
		System.out.println("스마트 홈 제어 v1.0");
		System.out.println("------------------------------");
		System.out.println("1.TV 켜기");
		System.out.println("2.TV 끄기");
		System.out.println("3.보일러 동작");
		System.out.println("4.세탁기 동작");
		System.out.println("5.종료");
		System.out.println("6.로그아웃");
		System.out.println("7.시리얼 포트 연결해제");
		System.out.println("8.시리얼 포트 연결");
		System.out.println("------------------------------");

//		int menu = s.nextInt();
//		return menu;
		return a.nextInt();
	}
	
}
