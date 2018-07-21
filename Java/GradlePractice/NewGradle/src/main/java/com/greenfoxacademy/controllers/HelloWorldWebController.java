package com.greenfoxacademy.controllers;

import com.greenfoxacademy.models.MultiLang;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;

@Controller
public class HelloWorldWebController {

    @RequestMapping("/web/multigreet")
    public String multiLangGreeting(Model model){
        MultiLang multi = new MultiLang();

        model.addAttribute("hello", multi.getHello());
        model.addAttribute("red", multi.getRed());
        model.addAttribute("green", multi.getGreen());
        model.addAttribute("blue", multi.getBlue());
        model.addAttribute("font", multi.getFont());

        return "multigreet";
    }
}
