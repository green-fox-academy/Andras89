package com.greenfoxacademy.models;

public class MultiLang {

    private String[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
            "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
            "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
            "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

    public String getHello(){
        int chosenIndex = (int) (Math.random() * hellos.length);
        return hellos[chosenIndex];
    }

    public int getRed(){
        return (int) (Math.random() * 256);
    }

    public int getGreen(){
        return (int) (Math.random() * 256);
    }

    public int getBlue(){
        return (int) (Math.random() * 256);
    }

    public int getFont(){
        return (int) (Math.random() * 60 + 8);
    }
}
