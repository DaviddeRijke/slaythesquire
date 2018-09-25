package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Tag;
import com.sts.slaythesquire.repos.CardRepository;
import com.sts.slaythesquire.repos.TagRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.Collection;

@Controller
@RequestMapping(path= "/api/tags")
public class TagController {
    private final TagRepository tagRepository;

    @Autowired
    public TagController(TagRepository tagRepository){
        this.tagRepository = tagRepository;
    }

    @GetMapping(path= "")
    public @ResponseBody
    Collection<Tag> getTags(){
        return tagRepository.findAll();
    }
}
