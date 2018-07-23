from turtle import *
import tkinter

draw = Pen()
draw.pensize(10)
draw.pencolor("red")
draw.speed(0)

for i in range(12):
    draw.begin_fill()
    draw.right(90)
    draw.forward(200)
    draw.left(120)
    draw.forward(200)
    draw.left(120)
    draw.forward(200)
    draw.end_fill()
    draw.forward(200)


tkinter.mainloop()
