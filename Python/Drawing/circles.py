from turtle import *
import tkinter

draw = Pen()
draw.pensize(1)
draw.pencolor("blue")
draw.speed(0)

outer = 4
pos = 8
cicle = 16


def starting():
    draw.penup()
    draw.forward(60)
    draw.pendown()


def ending(amount):
    draw.penup()
    draw.backward(60)
    draw.pendown()
    draw.left(360 / amount)


for u in range(outer):
    starting()

    for j in range(pos):
        starting()

        for i in range(cicle):
            draw.circle(120)
            draw.right(360 / cicle)

        ending(pos)

    ending(outer)

tkinter.mainloop()
