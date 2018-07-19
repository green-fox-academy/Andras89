package com.company;

import javax.swing.*;
import java.awt.*;

public class CheckerBoard extends JPanel
{
    int panelSize;

    public CheckerBoard(int panelSize)
    {
        this.panelSize = panelSize;
    }

    public void paintComponent(Graphics graphics)
    {
        graphics.setColor(new Color(0));

        for (int i = 0; i < panelSize / 10; i++)
        {
            for (int j = 0; j < panelSize / 10; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    graphics.fillRect(j * 20, i * 20, 20, 20);
                }
            }
        }
    }
}
