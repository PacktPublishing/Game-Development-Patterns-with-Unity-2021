﻿using UnityEngine;

namespace Pattern.Visitor
{
    public class BikeWeapon : MonoBehaviour, IBikeElement
    {
        public int range = 5; // Units
        public float strength = 25; // Percentage 

        public void Fire()
        {
            Debug.Log("Weapon fired!");
        }
    
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            
            Debug.Log("New Weapon Range: " + range);
            Debug.Log("New Weapon Strength: " + strength);
        }
    }
}