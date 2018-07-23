package com.greenfoxacademy.services;

import com.greenfoxacademy.repositories.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class RedditServiceImpl implements RedditService {

    @Autowired
    private PostRepository postRepo;
}
