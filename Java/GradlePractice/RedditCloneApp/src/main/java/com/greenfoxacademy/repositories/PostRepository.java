package com.greenfoxacademy.repositories;

import com.greenfoxacademy.models.Post;
import org.springframework.data.repository.CrudRepository;

public interface PostRepository extends CrudRepository<Post, Integer> {
}
