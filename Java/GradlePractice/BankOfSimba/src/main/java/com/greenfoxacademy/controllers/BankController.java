package com.greenfoxacademy.controllers;

import com.greenfoxacademy.models.BankAccount;
import com.greenfoxacademy.services.BankService;
import com.greenfoxacademy.services.BankServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import java.util.List;

@Controller
public class BankController {

    private BankService bankAccService;
    public static List<BankAccount> allAccounts;

    @Autowired
    public BankController(BankServiceImpl bankAccService) {
        this.bankAccService = bankAccService;
    }

    @RequestMapping("/show")
    public String showSimbaAccount(Model model){
        model.addAttribute("account", bankAccService.getGenerateAccount("Simba", 2000, "lion", true, true));

        return "show_simba";
    }

    @RequestMapping("/htmlception")
    public String htmlCeption(Model model){
        model.addAttribute("text", bankAccService.getHtmlContent());
        return "html_ception";
    }

    @GetMapping("/list")
    public String listOfBankAccounts(Model model){
        allAccounts = bankAccService.getAccounts(allAccounts);
        model.addAttribute("accounts", allAccounts);
        return "list";
    }

    @PostMapping("/addtoaccount")
    public String addToSelectedAccount(@ModelAttribute(value="name") String name){
        bankAccService.AddBalanceToAccount(allAccounts, name);
        return "redirect:/list";
    }
}
