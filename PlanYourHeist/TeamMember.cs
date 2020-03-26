﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlanYourHeist
{
    class TeamMember
    {
        private int _skillLevel;
        private decimal _courageFactor;

        public string Name { get; set; }
        public int SkillLevel {
            get
            {
                return _skillLevel;
            } 
            set
            {
                if (value > 0 && value < 51)
                {
                    _skillLevel = value;
                }
            }
        }
        public decimal CourageFactor { 
            get
            {
                return _courageFactor;
            }
            set
            {
                if (value >= 0.0m && value <= 2.0m)
                {
                    _courageFactor = value;
                }
            }
        }

    }
}
