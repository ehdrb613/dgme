import pyautogui
import time
import pyperclip



time.sleep(1)
pyautogui.hotkey('win','r')
pyautogui.write('notepad')
pyautogui.hotkey('enter')

time.sleep(1)
pyautogui.write('12345')
pyautogui.write('abcdefghijkml',interval=0.25)

pyperclip.copy('나도 코딩해야지?')
pyautogui.hotkey('ctrl','v')

# moveTo mouseDown mouseUp locateOnScreen click

'''
    pyautogui 클릭.. 마우스 조작 키보드 조작 라이브러리
    pillow 이미지 사용 라이브러리
    matplotlb 그래프 그리는 라이브러리
    numpy 데이터 사용 라이브러리
'''