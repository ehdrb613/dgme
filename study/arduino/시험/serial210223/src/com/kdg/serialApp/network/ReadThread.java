package com.kdg.serialApp.network;

import jssc.SerialPort;
import jssc.SerialPortException;

public class ReadThread extends Thread{
	
		SerialPort serial;

		public ReadThread(SerialPort serial) {
			this.serial = serial;
		}

		// 재정의(상속)
		public void run() {
			while (true) {
				try {
					byte[] read = serial.readBytes();
					if (read != null && read.length > 0) {
						System.out.print(new String(read));
					}
				} catch (SerialPortException e) {

					e.printStackTrace();
				}

			}
		}

	}

