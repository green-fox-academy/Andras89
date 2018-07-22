package com.greenfoxacademy.models;

import java.util.ArrayList;
import java.util.List;

public class AllBankAccounts {
    public List<BankAccount> bankAccounts;

    public AllBankAccounts(){
        bankAccounts = new ArrayList<BankAccount>();
        preFillWithAccounts();
    }

    private void preFillWithAccounts() {
        bankAccounts.add(new BankAccount("Simba", 5000, "Lion", true));
        bankAccounts.add(new BankAccount("Mufasa", 9000, "Lion", true));
        bankAccounts.add(new BankAccount("Zazu", 500, "Hornbill", false));
        bankAccounts.add(new BankAccount("Timon", 50, "Meerkat", false));
        bankAccounts.add(new BankAccount("Pumbaa", 0, "Warthog", false));
        bankAccounts.add(new BankAccount("Scar", 56000, "Lion", true));
    }
}
