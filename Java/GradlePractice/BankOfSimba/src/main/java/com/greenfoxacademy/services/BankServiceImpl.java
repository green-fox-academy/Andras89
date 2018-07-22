package com.greenfoxacademy.services;

import com.greenfoxacademy.models.AllBankAccounts;
import com.greenfoxacademy.models.BankAccount;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class BankServiceImpl implements BankService {

    public BankAccount getGenerateAccount(String name, double balance, String animalType, boolean isKing) {
        return new BankAccount(name, balance, animalType, isKing);
    }

    public String getHtmlContent() {
        return "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
    }

    public List<BankAccount> getAccounts() {
        return new AllBankAccounts().bankAccounts;
    }
}
