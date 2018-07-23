package com.greenfoxacademy.services;

import com.greenfoxacademy.models.Post;
import com.greenfoxacademy.repositories.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class RedditServiceImpl implements RedditService {

    @Autowired
    private PostRepository postRepo;

    public void addNewPostToDb(Post post) {
        postRepo.save(post);
    }

    public List<Post> getAllPostFromDb() {
        List<Post> posts = new ArrayList<>();
        postRepo.findAll().forEach(posts::add);
        return posts;
    }

    public void increaseSelectedPostVote(Integer id) {
        Post selected = postRepo.findById(id).get();
        selected.setVotes(selected.getVotes() + 1);
        postRepo.save(selected);
    }
}
