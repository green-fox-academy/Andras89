package com.company;

import javax.swing.*;
import java.awt.*;

public class PurpleSteps extends JPanel
{
    public void paintComponent(Graphics graphics)
    {
        for (int i = 0; i < 800; i += 25)
        {
            graphics.setColor(new Color(0));
            graphics.drawRect(i, i, 25, 25);
            graphics.setColor(new Color(0x7B005B));
            graphics.fillRect(i, i, 25,25);
        }
    }
}
