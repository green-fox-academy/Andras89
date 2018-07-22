package com.greenfoxacademy.services;

import com.greenfoxacademy.models.AllBankAccounts;
import com.greenfoxacademy.models.BankAccount;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class BankServiceImpl implements BankService {

    public BankAccount getGenerateAccount(String name, double balance, String animalType, boolean isKing, boolean alignment) {
        return new BankAccount(name, balance, animalType, isKing, alignment);
    }

    public String getHtmlContent() {
        return "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
    }

    public List<BankAccount> getAccounts(List<BankAccount> allAccounts) {
        if (allAccounts == null || allAccounts.size() < 1){
            return new AllBankAccounts().bankAccounts;
        }
        else {
            return allAccounts;
        }
    }

    public List<BankAccount> AddBalanceToAccount(List<BankAccount> allAccounts, String name) {
        for (BankAccount account: allAccounts) {
            if (account.getName().equals(name)){
                if (account.getIsKing()){
                    account.setBalance(account.getBalance() + 100);
                }
                else{
                    account.setBalance(account.getBalance() + 10);
                }
            }
        }

        return allAccounts;
    }

    public List<BankAccount> addNewAccount(List<BankAccount> allAccounts, BankAccount account) {
        allAccounts.add(account);
        return allAccounts;
    }
}
