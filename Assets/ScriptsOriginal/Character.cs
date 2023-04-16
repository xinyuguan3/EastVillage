using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Character:MonoBehaviour {
    //通识 人性 技能 哲学 审美
    // Attributes
    public float willpower;
    public float emotionalThreshold;
    public float concentration;
    public float observation;
    public float energy;
    public float emotionalIntelligence;
    public MBTIType mbtiType;
    public float pleasure;
    public float arousal;
    public float dominance;
    
    // Constructor
    public Character(float wp, float et, float con, float obs, float en, float ei, MBTIType mbti) {
        willpower = wp;
        emotionalThreshold = et;

        concentration = con;

        //画像
        observation = obs;

        //健身
        energy = en;
        
        //
        emotionalIntelligence = ei;
        mbtiType = mbti;
        pleasure = 0.5f;
        arousal = 0.5f;
        dominance = 0.5f;
    }
    
    // Methods
    public void GiveGift() {
        // Code for giving a gift
    }
    
    public void Observe() {
        // Code for observing
    }
    
    public void LearnSkill() {
        // Code for learning a skill
    }
    
    public void Flatter() {
        // Code for flattering
    }
    
    public void Insult() {
        // Code for insulting
    }
    
    public void Steal() {
        // Code for stealing
    }
}

