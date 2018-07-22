package com.greenfoxacademy.services;

import com.greenfoxacademy.models.BankAccount;

import java.util.List;

public interface BankService {
    BankAccount getGenerateAccount(String name, double balance, String animalType, boolean isKing, boolean alignment);
    String getHtmlContent();
    List<BankAccount> getAccounts();
}
