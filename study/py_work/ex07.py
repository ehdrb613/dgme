import myfunc as mf
import pyautogui
import time
import pyperclip

# mf.paint('Text.PNG','참잘했어요')
start = time.time()
print('start',start)

def doA():
    for i in range(0,5):
        print(i)
    
def han_write(text):
    pyperclip.copy(text)
    pyautogui.hotkey('ctrl','v')

def find_target(file_name,timeout=10):
    while True:
        time.sleep(1)
        end=time.time()
        file_a = pyautogui.locateOnScreen(file_name)
        if file_a is not None:
            return file_a
        if(end-start) > timeout:
            break

def paint(file_name,text):
    time.sleep(1)
    pyautogui.hotkey('win','r')
    pyautogui.write('mspaint')
    pyautogui.hotkey('enter')
    
    time.sleep(2)

    window=pyautogui.getWindowsWithTitle('제목 없음 - 그림판')[0]
    window.maximize()
    
    time.sleep(1)
    pyautogui.click(find_target(file_name)) 
    pyautogui.move(0,500,duration=1)
    pyautogui.click()
    time.sleep(2)
    han_write(text)
    time.sleep(2)
    window.close()
    time.sleep(2)
    pyautogui.hotkey('n')

paint('Text.PNG','참잘했어요')