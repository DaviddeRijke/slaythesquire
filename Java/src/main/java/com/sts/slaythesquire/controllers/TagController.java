package com.sts.slaythesquire.controllers;

import com.sts.slaythesquire.models.Tag;
import com.sts.slaythesquire.repos.CardRepository;
import com.sts.slaythesquire.repos.TagRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.lang.NonNull;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

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

    @RequestMapping(path = "/get", method = RequestMethod.GET, params = {"id"})
    public @ResponseBody
    Tag getTag(@NonNull Integer id){
        return tagRepository.findById(id).orElse(null);
    }

    @RequestMapping(path = "/get", method = RequestMethod.GET, params = {"name"})
    public @ResponseBody
    Tag getTag(String name){
        return tagRepository.findByName(name);
    }

    @PostMapping(path = "/add")
    public @ResponseBody
    boolean addTag(Tag tag){
        if(tagRepository.existsByName(tag.getName())) return false;
        tagRepository.save(tag);
        return tagRepository.existsByName(tag.getName());
    }
}
