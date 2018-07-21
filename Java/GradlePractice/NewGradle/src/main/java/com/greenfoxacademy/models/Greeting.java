package com.greenfoxacademy.models;

public class Greeting {

    private static long adder = 0;
    private long id;
    private String content;

    public Greeting(String content) {
        adder++;
        this.id = adder;
        this.content = content;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }
}
