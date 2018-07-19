package com.company;

import javax.swing.*;
import java.awt.*;

public class Main {

    public static void main(String[] args) {

        System.out.println("Hello World!");

        JFrame frame = new JFrame("Drawing Board");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Draw drawing = new Draw();
        frame.add(drawing);
        frame.setSize(800, 800);
        frame.setVisible(true);

        JFrame purpleFrame = new JFrame("Purple steps");
        purpleFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        PurpleSteps drawSteps = new PurpleSteps();
        purpleFrame.add(drawSteps);
        purpleFrame.setSize(800, 800);
        purpleFrame.setVisible(true);
    }
}
