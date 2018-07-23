package com.greenfoxacademy.controllers;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class RedditController {

    @GetMapping("")
    public String MainPage(){
        return "main";
    }
}
