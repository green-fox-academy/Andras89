package com.greenfoxacademy.controllers;

import com.greenfoxacademy.services.BankService;
import com.greenfoxacademy.services.BankServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class BankController {

    private BankService bankAccService;

    @Autowired
    public BankController(BankServiceImpl bankAccService) {
        this.bankAccService = bankAccService;
    }

    @RequestMapping("/show")
    public String showSimbaAccount(Model model){
        model.addAttribute("account", bankAccService.getGenerateAccount("Simba", 2000, "lion"));

        return "show_simba";
    }

    @RequestMapping("/htmlception")
    public String htmlCeption(Model model){
        model.addAttribute("text", bankAccService.getHtmlContent());
        return "html_ception";
    }
}
