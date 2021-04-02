import pyautogui
import time

# pyautogui.click(123,11,duration=2)

time.sleep(3)
pyautogui.mouseDown(100,200)
pyautogui.move(100,100,duration=1)
pyautogui.mouseUp()