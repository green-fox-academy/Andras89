package com.greenfoxacademy.models;

public class BankAccount {

    private String name;
    private double balance;
    private String animalType;
    private boolean isKing;
    private boolean alignment;

    public BankAccount(String name, double balance, String animalType, boolean isKing, boolean alignment) {
        this.name = name;
        this.balance = balance;
        this.animalType = animalType;
        this.isKing = isKing;
        this.alignment = alignment;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public String getAnimalType() {
        return animalType;
    }

    public void setAnimalType(String animalType) {
        this.animalType = animalType;
    }

    public boolean getIsKing() {
        return isKing;
    }

    public void setKing(boolean king) {
        isKing = king;
    }

    public boolean getAlignment() {
        return alignment;
    }

    public void setAlignment(boolean alignment) {
        this.alignment = alignment;
    }
}
