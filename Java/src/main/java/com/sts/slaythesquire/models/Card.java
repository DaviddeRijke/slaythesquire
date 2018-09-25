package com.sts.slaythesquire.models;

import javax.persistence.*;
import java.util.Collection;

@Entity
public class Card {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int id;
    private String name;

    @ManyToMany(cascade=CascadeType.ALL)
    @JoinTable(name="card_tag", joinColumns = @JoinColumn(name="card_id"), inverseJoinColumns = @JoinColumn(name="tag_id"))
    private Collection<Tag> tags;

    @ManyToMany(cascade=CascadeType.ALL)
    @JoinTable(name="card_tag", joinColumns = @JoinColumn(name="card_id"), inverseJoinColumns = @JoinColumn(name="effect_id"))
    private Collection<Effect> effects;
    private EndTurnAction endTurnAction;

    public void setId(final int id){
        this.id = id;
    }
    public int getId(){
        return id;
    }

    public void setName(final String name){this.name = name;}
    public String getName(){
        return name;
    }

    public void setTags(final Collection<Tag> tags){ this.tags = tags; }
    public Collection<Tag> getTags(){return tags;}

    public void addTag(Tag tag){if(!tags.contains(tag)) tags.add(tag);}
    public void removeTag(Tag tag){ tags.remove(tag);}

    public void setEffects(final Collection<Effect> effects){ this.effects = effects; }
    public Collection<Effect> getEffects(){return effects;}

    public void addEffect(Effect effect){if(!effects.contains(effect)) effects.add(effect);}
    public void removeEffect(Effect effect){ effects.remove(effect);}

    public void setEndTurnAction(EndTurnAction endTurnAction){this.endTurnAction = endTurnAction;}
    public EndTurnAction getEndTurnAction(){return endTurnAction;}
}
