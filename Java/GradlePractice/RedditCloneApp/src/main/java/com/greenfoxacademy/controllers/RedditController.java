package com.greenfoxacademy.controllers;

import com.greenfoxacademy.services.RedditService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class RedditController {

    @Autowired
    private RedditService service;

    @GetMapping("")
    public String MainPage(){
        return "main";
    }
}
