﻿using System;
using System.Collections.Generic;
using Luis;
using Microsoft.Bot.Builder;

namespace AutomotiveSkillTest.Flow.Fakes
{
    public class MockVehicleSettingsValueIntent : settings_valueLuis
    {
        private Intent intent;
        private double score;

        public MockVehicleSettingsValueIntent(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new ArgumentNullException(nameof(userInput));
            }

            this.Entities = new settings_valueLuis._Entities();
            this.Intents = new Dictionary<Intent, IntentScore>();

            var intentScore = new Microsoft.Bot.Builder.IntentScore();
            intentScore.Score = 0.9909704;
            intentScore.Properties = new Dictionary<string, object>();

            this.Intents.Add(settings_valueLuis.Intent.SETTING_VALUE_SELECTION, intentScore);

            switch (userInput.ToLower())
            {
                case "second one":
                    this.Entities.INDEX = new string[] { "second" };
                    break;
                case "braking and alerts":
                case "decrease":
                case "increase":
                case "steer":
                    this.Entities.VALUE = new string[] { userInput.ToLower() };
                    break;
            }

            (intent, score) = this.TopIntent();
        }
    }
}