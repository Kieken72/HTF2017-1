﻿using System;

namespace HTF2017.DataTransferObjects
{
    public class DeployAndroidDto
    {
        public String Password { get; set; }

        public AutoPilotDto AutoPilot { get; set; }

        public SensorAccuracyDto LocationSensorAccuracy { get; set; }

        public SensorAccuracyDto CrowdSensorAccuracy { get; set; }

        public SensorAccuracyDto MoodSensorAccuracy { get; set; }

        public SensorAccuracyDto RelationshipSensorAccuracy { get; set; }
    }
}