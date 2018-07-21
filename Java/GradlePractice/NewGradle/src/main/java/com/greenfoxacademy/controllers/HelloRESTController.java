package com.greenfoxacademy.controllers;

import com.greenfoxacademy.models.Greeting;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloRESTController {

    Greeting greet = new Greeting(1, "Yo!");

    @RequestMapping
    public Greeting greeting(){
        return greet;
    }
}
