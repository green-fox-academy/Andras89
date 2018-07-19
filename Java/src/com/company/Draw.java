package com.company;


import javax.swing.*;
import java.awt.*;

public class Draw extends JPanel
{
    public void paintComponent(Graphics graphics)
    {
        graphics.fillRect(200,200,200,200);
        graphics.setColor(new Color(200,200,0,150));
        graphics.fillRect(210,210,200,200);

    }
}
