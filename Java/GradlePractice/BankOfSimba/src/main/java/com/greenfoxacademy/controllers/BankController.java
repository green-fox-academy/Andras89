package com.greenfoxacademy.controllers;

import com.greenfoxacademy.services.BankService;
import com.greenfoxacademy.services.BankServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;

@Controller
public class BankController {

    private BankService bankAccService;

    @Autowired
    public BankController(BankServiceImpl bankAccService) {
        this.bankAccService = bankAccService;
    }
}
