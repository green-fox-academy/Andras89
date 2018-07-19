package com.company;

public class People
{
    public String firstName;
    public String lastName;
    public int age;

    public People(String firstName, String lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    @Override
    public String toString(){
        return String.format("%s %s is %d year old", firstName, lastName, age);
    }
}
