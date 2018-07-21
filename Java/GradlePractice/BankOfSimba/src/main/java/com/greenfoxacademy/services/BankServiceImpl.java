package com.greenfoxacademy.services;

import com.greenfoxacademy.models.BankAccount;
import org.springframework.stereotype.Service;

@Service
public class BankServiceImpl implements BankService {

    public BankAccount getGenerateAccount(String name, double balance, String animalType) {
        return new BankAccount(name, balance, animalType);
    }
}
