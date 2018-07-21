package com.greenfoxacademy.services;

import com.greenfoxacademy.models.BankAccount;

public interface BankService {
    BankAccount getGenerateAccount(String name, double balance, String animalType);
    String getHtmlContent();
}
