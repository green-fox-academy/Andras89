from turtle import *
import tkinter

draw = Pen()
draw.pensize(1)
draw.pencolor("blue")
draw.speed(0)
cicle = 84

for i in range(cicle):
    draw.circle(120)
    draw.right(360/cicle)


tkinter.mainloop()