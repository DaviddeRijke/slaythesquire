package com.sts.slaythesquire.models;

import javax.persistence.*;
import java.util.Collection;
import java.util.List;

@Entity
public class Card {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    private String name;
    private String description;
    private int cost;

    @ManyToMany(cascade=CascadeType.ALL)
    @JoinTable(name="card_tag", joinColumns = @JoinColumn(name="card_id"))
    private List<Tag> tags;

    @ManyToMany(cascade=CascadeType.ALL)
    @JoinTable(name="card_effect", joinColumns = @JoinColumn(name="card_id"))
    private List<Effect> effects;

    @ManyToOne(cascade = CascadeType.ALL)
    private EndTurnAction endTurnAction;

    public int getId(){
        return id;
    }

    public void setName(final String name){this.name = name;}
    public String getName(){
        return name;
    }

    public void setDescription(final String description){this.description = description;}
    public String getDescription(){ return description; }

    public void setCost(final int cost){this.cost = cost;}
    public int getCost(){ return cost;}

    public void setTags(final List<Tag> tags){ this.tags = tags; }
    public Collection<Tag> getTags(){return tags;}

    public void addTag(Tag tag){if(!tags.contains(tag)) tags.add(tag);}
    public void removeTag(Tag tag){ tags.remove(tag);}

    public void setEffects(final List<Effect> effects){ this.effects = effects; }
    public Collection<Effect> getEffects(){return effects;}

    public void addEffect(Effect effect){if(!effects.contains(effect)) effects.add(effect);}
    public void removeEffect(Effect effect){ effects.remove(effect);}

    public void setEndTurnAction(EndTurnAction endTurnAction){this.endTurnAction = endTurnAction;}
    public EndTurnAction getEndTurnAction(){return endTurnAction;}
}
