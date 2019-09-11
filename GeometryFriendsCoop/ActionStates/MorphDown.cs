﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using GeometryFriends.AI;
using GeometryFriends.AI.Perceptions.Information;

namespace GeometryFriendsAgents.ActionStates
{
    class MorphDown : ActionState
    {

        float previousHeight;
        int sameCount = 0;

        float minHeight = 52;

        public override Moves getAction()
        {
            return Moves.MORPH_DOWN;
        }

        public override void SensorsUpdate(RectangleRepresentation rI, CircleRepresentation cI, CollectibleRepresentation[] colI)
        {
            if(rI.Height - minHeight < 0.5)
            {
                setFinished();
            }
            else if(previousHeight - rI.Height < 0.1)
            {
                sameCount++;
                previousHeight = rI.Height;
            }
            else
            {
                sameCount = 0;
            }
        }

        public override void Setup(CountInformation nI, RectangleRepresentation rI, CircleRepresentation cI, ObstacleRepresentation[] oI, ObstacleRepresentation[] rPI, ObstacleRepresentation[] cPI, CollectibleRepresentation[] colI, Rectangle area, double timeLimit)
        {
            previousHeight = rI.Height;
        }
    }
}
