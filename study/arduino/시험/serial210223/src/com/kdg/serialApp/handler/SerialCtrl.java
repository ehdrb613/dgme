package com.kdg.serialApp.handler;

import java.util.Scanner;

import jssc.SerialPort;
import jssc.SerialPortException;


import com.kdg.serialApp.util.*;
import com.kdg.serialApp.network.*;


public class SerialCtrl {
	
	Menu menu = new Menu();
	MySerial ms = new MySerial();
	//게스트 계정 컨트롤
	public boolean guestControl(Scanner s, SerialPort serial) throws InterruptedException, SerialPortException {

		
		
		while (true) {

			switch (menu.GuestMenu(s)) {
			case Menu.TV_ON: {
				System.out.println("TV ON");
				serial.writeInt(Menu.CMD_TV_ON);
				Thread.sleep(500);
				break;
			}
			case Menu.TV_OFF: {
				System.out.println("TV OFF");
				serial.writeInt(Menu.CMD_TV_OFF);
				Thread.sleep(500);
				break;
			}
			case Menu.HOTTER_ON: {
				System.out.println("보일러 가동");
				serial.writeInt(Menu.CMD_HOTTER_ON);
				Thread.sleep(500);
				break;
			}
			case Menu.CLEANER_ON: {
				System.out.println("세탁기 가동");
				serial.writeInt(Menu.CMD_CLEANER_ON);
				Thread.sleep(500);
				break;
			}
			case Menu.LOGOUT: {
				System.out.println("로그아웃 됩니다.");
				return false;

			}
			case Menu.PROGRAM_EXIT: {
				System.out.println("프로그램 종료");
				//System.exit(0);
				return true;
				
			}

			}

		}

	}

	// admin 계정 컨트롤
	@SuppressWarnings("deprecation")
	public boolean adminControl(Scanner s, SerialPort serial, ReadThread rt)
			throws InterruptedException, SerialPortException {

		boolean check = true;
		while (true) {

			switch (menu.AdminMenu(s)) {

			case Menu.TV_ON: {
				if (check == true) {
					System.out.println("TV ON");
					serial.writeInt(Menu.CMD_TV_ON);
					Thread.sleep(500);
				} else {
					System.out.println("시리얼 포트 종료됨,사용하려면 다시 연결");
				}
				break;
			}
			case Menu.TV_OFF: {
				if (check == true) {
					System.out.println("TV OFF");
					serial.writeInt(Menu.CMD_TV_OFF);
					Thread.sleep(500);
				} else {
					System.out.println("시리얼 포트 종료됨,사용하려면 다시 연결");
				}
				break;
			}
			case Menu.HOTTER_ON: {
				if (check == true) {
					System.out.println("보일러 가동");
					serial.writeInt(Menu.CMD_HOTTER_ON);
					Thread.sleep(500);
				} else {
					System.out.println("시리얼 포트 종료됨,사용하려면 다시 연결");
				}
				break;
			}
			case Menu.CLEANER_ON: {
				if (check == true) {
					System.out.println("세탁기 가동");
					serial.writeInt(Menu.CMD_CLEANER_ON);
					Thread.sleep(500);
				} else {
					System.out.println("시리얼 포트 종료됨,사용하려면 다시 연결");
				}
				break;
			}

			case Menu.LOGOUT: {
				System.out.println("로그아웃 됩니다.");
				return false;

			}
			case Menu.PROGRAM_EXIT: {
				System.out.println("프로그램 종료");
				//System.exit(0);
				return true;
				
			}

			case Menu.SERIAL_STOP: {
				if (serial.isOpened()) {
					System.out.println("시리얼 포트 종료");
					check = false;
					rt.stop();
					serial.closePort();
					System.out.println(serial);
				} else {
					System.out.println("이미 포트 종료된 상태입니다.");
				}
				break;
			}
			case Menu.SERIAL_START: {
				if (!serial.isOpened()) {
					ms.openSerial(serial);
					System.out.println(serial);
					check = true;
					rt = new ReadThread(serial);
					rt.start();
				}
//					if(check==false) {
//					System.out.println("시리얼 포트 시작");
//					
////					check = true;
////					serial = initSerial();
//					
////					 rt = new ReadThread(serial);
////					 rt.start();
//					}
				else {
					System.out.println("현재 포트가 열려 있습니다.");
				}
				break;
			}

			}

		}

	}
}


