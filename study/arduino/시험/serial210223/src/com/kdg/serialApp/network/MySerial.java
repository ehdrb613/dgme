package com.kdg.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;
import jssc.SerialPortList;

public class MySerial {

	//시리얼 포트 연결
		public SerialPort initSerial() {

			String[] portName = SerialPortList.getPortNames();

//			for (int i = 0; i < portName.length; i++) {
//				System.out.println("사용가능 포트: " + portName[i]);
//			}

			SerialPort serialPort = new SerialPort("COM7");
			
			return serialPort;
		}
		
		
		public void openSerial(SerialPort serial) {
			
			try {
				serial.openPort();
				serial.setParams(SerialPort.BAUDRATE_9600, SerialPort.DATABITS_8, SerialPort.STOPBITS_1,
						SerialPort.PARITY_NONE);
				System.out.println("포트사용 가능!");
			} catch (SerialPortException e) {
				e.printStackTrace();
				
			}
			
		}


		
}


