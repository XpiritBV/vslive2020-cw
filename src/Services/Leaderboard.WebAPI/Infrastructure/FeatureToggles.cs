﻿using FeatureToggle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leaderboard.WebAPI.Infrastructure
{
    public class AdvancedHealthFeature : SimpleFeatureToggle { }
    public class PlayerBanningFeature : AlwaysOffFeatureToggle { }
    public class ServerDetectionFeature : AlwaysOnFeatureToggle { }
}