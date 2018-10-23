package com.sts.slaythesquire.utils.threading;

import java.util.concurrent.locks.Condition;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

public class ReadWriteMonitor {

    private final Lock lock = new ReentrantLock();

    private int writersActive = 0, readersActive = 0, readersWaiting = 0, writersWaiting = 0;
    private Condition okToRead = lock.newCondition(), okToWrite = lock.newCondition();

    public void enterReader() throws InterruptedException{
        lock.lock();
        try {
            while (writersActive != 0) {
                readersWaiting++;
                okToRead.await();
                readersWaiting--;
            }
            readersActive++;
        }catch (InterruptedException ex){
            readersWaiting--;
            throw ex;
        }finally {
            lock.unlock();
        }
    }

    public void exitReader() {
        lock.lock();
        try {
            readersActive--;
            if (readersActive == 0) okToWrite.signal();
        }finally {
            lock.unlock();
        }
    }

    public void enterWriter() throws InterruptedException {
        lock.lock();
        try {
            while (writersActive > 0 || readersActive > 0){
                writersWaiting++;
                okToWrite.await();
                writersWaiting--;
            }
            writersActive++;
        }catch (InterruptedException ex){
            writersWaiting--;
            throw ex;
        }finally {
            lock.unlock();
        }
    }

    public void exitWriter() {
        lock.lock();
        try {
            writersActive--;
            if(writersWaiting > 0) okToWrite.signal();
            else okToRead.signalAll();
        }finally {
            lock.unlock();
        }
    }

}
