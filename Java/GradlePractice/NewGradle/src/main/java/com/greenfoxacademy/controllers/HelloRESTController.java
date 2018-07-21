package com.greenfoxacademy.controllers;

import com.greenfoxacademy.models.Greeting;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloRESTController {

    @RequestMapping
    public Greeting greeting(@RequestParam(value = "name", defaultValue = "World")String content){
        return new Greeting(1, "Hello " + content);
    }
}
