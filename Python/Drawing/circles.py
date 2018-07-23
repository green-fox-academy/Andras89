from turtle import *
import tkinter

draw = Pen()
draw.pensize(1)
draw.pencolor("blue")
draw.speed(0)

outer = 4
pos = 8
cicle = 16

for u in range(outer):
    draw.penup()
    draw.forward(60)
    draw.pendown()

    for j in range(pos):
        draw.penup()
        draw.forward(60)
        draw.pendown()

        for i in range(cicle):
            draw.circle(120)
            draw.right(360/cicle)

        draw.penup()
        draw.backward(60)
        draw.pendown()
        draw.left(360/pos)

    draw.penup()
    draw.backward(60)
    draw.pendown()
    draw.left(360 / outer)

tkinter.mainloop()