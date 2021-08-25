﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgesClass
{
    public class BadgeRepo
    {
        private Dictionary<int, Badge> _badgeRepo { get; set; }
        
        public bool AddBadge(Badge badge)
        {
            int length = _badgeRepo.Count;
            _badgeRepo.Add(badge.ID, badge);
            if (_badgeRepo.Count > length)
            {
                return true;
            }
            return false;
        }
        public void UpdateDoors(int id, List<string> doors)
        {
            Badge badge = new Badge(id, doors);
            _badgeRepo[id] = badge;
        }

    }
}
