package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args)
    {
        List<People> peoples = Arrays.asList
                (
                        new People("Tim","Something",34),
                        new People("John","Doe",21),
                        new People("Kate", "Williams", 45)
                );

        peoples.stream().filter(p -> p.age > 30).forEach(p -> System.out.println(p));

        var result = peoples.stream().collect(Collectors.groupingBy(p -> p.age > 35));
        System.out.println(result);

        peoples = new ArrayList();
        peoples.add(new People("Tim","Something",34));
        peoples.add(new People("James","Cambers",12));
        peoples.add(new People("Allen","Ripley",76));
        peoples.add(new People("Katrine","Cook",24));

        peoples.stream().map(p -> p.age > 40).forEach(k -> System.out.println(k));
        peoples.stream().map(p -> p.firstName).forEach(k -> System.out.println(k));
    }
}
