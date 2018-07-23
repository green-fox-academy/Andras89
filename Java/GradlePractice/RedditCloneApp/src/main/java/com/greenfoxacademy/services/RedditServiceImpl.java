package com.greenfoxacademy.services;

import com.greenfoxacademy.models.Post;
import com.greenfoxacademy.repositories.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class RedditServiceImpl implements RedditService {

    @Autowired
    private PostRepository postRepo;

    public void addNewPostToDb(Post post) {
        postRepo.save(post);
    }
}
