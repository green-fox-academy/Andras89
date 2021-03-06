package com.greenfoxacademy.services;

import com.greenfoxacademy.models.Post;
import java.util.List;

public interface RedditService {
    void addNewPostToDb(Post post);
    List<Post> getAllPostFromDb();
    void increaseSelectedPostVote(Integer id);
    void decreaseSelectedPostVote(Integer id);
}
