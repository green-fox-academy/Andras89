package com.greenfoxacademy.controllers;

import com.greenfoxacademy.models.Post;
import com.greenfoxacademy.services.RedditService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class RedditController {

    @Autowired
    private RedditService service;

    @GetMapping("")
    public String mainPage(Model model){
        model.addAttribute("posts", service.getAllPostFromDb());
        return "main";
    }

    @GetMapping("/newpost")
    public String showAddPostPage(Model model){
        model.addAttribute("post", new Post());
        return "addpost";
    }

    @PostMapping("/newpost")
    public String addPostPage(@ModelAttribute Post post){
        service.addNewPostToDb(post);
        return "redirect:/";
    }

    @PostMapping("/upvote")
    public String upVotePost(@ModelAttribute(value = "id") Integer id){
        service.increaseSelectedPostVote(id);
        return "redirect:/";
    }

    @PostMapping("/downvote")
    public String downVotePost(@ModelAttribute(value = "id") Integer id){
        service.decreaseSelectedPostVote(id);
        return "redirect:/";
    }
}
