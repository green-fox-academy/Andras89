from tkinter import *

canvas = Canvas(width=500, height=500)
canvas.pack()

floor = PhotoImage(file='src/floor.gif')

for i in range(10):
    for j in range(10):
        canvas.create_image(50 * (j+1), 50 * (i+1), image=floor, anchor=NW)

mainloop()
