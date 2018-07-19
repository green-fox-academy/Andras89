package com.company;

import javax.swing.*;

public class Main {

    public static void main(String[] args) {

        System.out.println("Hello World!");

        JFrame frame = new JFrame("Drawing Board");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Draw drawing = new Draw();
        frame.add(drawing);
        frame.setSize(600, 600);
        frame.setVisible(true);
    }
}
