package com.kdg.serialApp;

import java.io.IOException;
import java.util.Scanner;

import com.kdg.serialApp.handler.SerialCtrl;
import com.kdg.serialApp.network.*;
import com.kdg.serialApp.util.Menu;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class SerialMain {

	

	
	//main
	public static void main(String[] args) throws InterruptedException, SerialPortException {
		MySerial ms = new MySerial(); //myserial 객체 생성
		Menu menu = new Menu();	//menu 객체 생성
		SerialCtrl sc = new SerialCtrl();
		Scanner s = new Scanner(System.in);
		
		SerialPort serial = ms.initSerial();
		
		ms.openSerial(serial);
		
		// 읽기 쓰레드 시작
		if(serial.isOpened()) {
		ReadThread rt = new ReadThread(serial); //readthread 객체 생성
		rt.start();
		
		
		boolean f=true;
		
		do{
			String flag = menu.login();
			if (flag.equals(Menu.GUEST_ID)) {
				f=sc.guestControl(s, serial);
				
			} else if (flag.equals(Menu.ADMIN_ID)) {
				f=sc.adminControl(s, serial, rt);
			}
			
		}while(f==false);
		
		}
		System.out.println("프로그램 종료");
		
	}
	
	
	

} //  종료



