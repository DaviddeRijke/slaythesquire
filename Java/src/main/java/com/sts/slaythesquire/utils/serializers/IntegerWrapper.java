package com.sts.slaythesquire.utils.serializers;

import org.springframework.web.bind.annotation.RequestParam;

import java.io.Serializable;

public class IntegerWrapper implements Serializable {
    private int value;

    public IntegerWrapper(int value) {
        this.value = value;
    }

    public IntegerWrapper(){}

    public int getValue(){
        return value;
    }
}
