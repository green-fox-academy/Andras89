package com.greenfoxacademy.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

@Controller
public class HelloWorldWebController {

    @RequestMapping("/web/multigreet")
    public String multiLangGreeting(Model model){
        model.addAttribute("hellos", hellos);
        return "multigreet";
    }
}
