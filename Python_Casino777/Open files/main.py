import random
from PyQt6 import uic
from PyQt6.QtWidgets import QApplication

Form, Window = uic.loadUiType("PythonCasino777.ui")

app = QApplication([])
window = Window()
form = Form()
form.setupUi(window)
window.show()

win = 0
clk = 0

def on_click_pushButton ():
    global win
    global clk
    rand2 = random.randint(0, 9)
    form.label_2.setText(str(rand2))
    rand3 = random.randint(0, 9)
    form.label_3.setText(str(rand3))
    rand4 = random.randint(0, 9)
    form.label_4.setText(str(rand4))
    if rand2 == 7 or rand3 == 7 or rand4 == 7:
        win = win + 1
        clk = clk + 1
        imgwin = '<html><head/><body><p><img width="75" height="75" src="chip.png"/></p></body></html>'
        if rand2 == 7:
            form.label_6.setText('<html><head/><body><p><img width="75" height="75" src="chip.png"/></p></body></html>')
        if rand3 == 7:
            form.label_7.setText('<html><head/><body><p><img width="75" height="75" src="chip.png"/></p></body></html>')
        if rand4 == 7:
            form.label_8.setText('<html><head/><body><p><img width="75" height="75" src="chip.png"/></p></body></html>')  
    else:
        clk = clk + 1
        form.label_8.setText(' ')
        form.label_7.setText(' ')
        form.label_6.setText(' ')
    mach = win / clk * 100
    form.label_5.setText('Процент выигрыша ' + str(mach) + '%')

def on_click_pushButton_1():
    exit(0)
    sys.exit
    os.abort()

form.pushButton.clicked.connect(on_click_pushButton)
form.pushButton_1.clicked.connect(on_click_pushButton_1)

app.exec()