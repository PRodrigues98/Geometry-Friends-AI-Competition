﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryFriends.AI.Perceptions.Information;

namespace GeometryFriendsAgents
{
    public class StateMP
    {
        private float positionX;
        private float positionY;
        private float velocityX;
        private float velocityY;
        private float positionXPartner;
        private float positionYPartner;
        private float velocityXPartner;
        private float velocityYPartner;
        private float height;
        private float circleVelocityRadius;
        private List<CollectibleRepresentation> caughtCollectibles;
        private List<CollectibleRepresentation> uncaughtCollectibles;

        public StateMP(float cPosX, float cPosY, float cVelX, float cVelY, float cH, float cVelRad, float pPosX, float pPosY, float pVelX, float pVelY, List<CollectibleRepresentation> cC, List<CollectibleRepresentation> uC)
        {
            positionX = cPosX;
            positionY = cPosY;
            velocityX = cVelX;
            velocityY = cVelY;
            height = cH;
            circleVelocityRadius = cVelRad;
            positionXPartner = pPosX;
            positionYPartner = pPosY;
            velocityXPartner = pVelX;
            velocityYPartner = pVelY;
            caughtCollectibles = cC;
            uncaughtCollectibles = uC;
        }

        public float getPosX()
        {
            return positionX;
        }

        public float getPosY()
        {
            return positionY;
        }

        public float getVelX()
        {
            return velocityX;
        }

        public float getVelY()
        {
            return velocityY;
        }

        public float getHeight()
        {
            return height;
        }

        public float getPartnerX()
        {
            return positionXPartner;
        }

        public float getPartnerY()
        {
            return positionYPartner;
        }

        public float getPartnerVelX()
        {
            return velocityXPartner;
        }

        public float getPartnerVelY()
        {
            return velocityYPartner;
        }

        public int getNumberCaughtCollectibles()
        {
            return caughtCollectibles.Count;
        }

        public int getNumberUncaughtCollectibles()
        {
            return uncaughtCollectibles.Count;
        }

        public List<CollectibleRepresentation> getCaughtCollectibles()
        {
            return caughtCollectibles;
        }

        public List<CollectibleRepresentation> getUncaughtCollectibles()
        {
            return uncaughtCollectibles;
        }

        public void addCaughtCollectibles(List<CollectibleRepresentation> collectibles)
        {
            //actualizes all the collectibles that were caught without duplicating
            foreach(CollectibleRepresentation collectible in collectibles)
            {
                if (!caughtCollectibles.Contains(collectible))
                {
                    caughtCollectibles.Add(collectible);
                }
            }
        }
    }
}