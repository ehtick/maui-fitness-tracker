﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    public class FitnessData
    {
        public StepsData? Steps { get; set; }
        public HeartRateData? HeartRate { get; set; }
        public SleepData? Sleep { get; set; }
        public CaloriesData? Calories { get; set; }
        public List<TrendData>? Trends { get; set; }
    }

    public class StepsData
    {
        public int Count { get; set; }
        public double DistanceKm { get; set; }
        public int Calories { get; set; }
        public int MoveMinutes { get; set; }
    }

    public class HeartRateData
    {
        public int BPM { get; set; }
    }

    public class SleepData
    {
        public double Hours { get; set; }
    }

    public class CaloriesData
    {
        public int TotalCalories { get; set; }
        public int ActiveCalories { get; set; }
        public int RestingCalories { get; set; }
    }

    public class TrendData
    {
        public string Name { get; set; } = string.Empty;
        public List<DataPoint>? DataPoints { get; set; }
    }

    public class DataPoint
    {
        public string Label { get; set; } = string.Empty;
        public double Value { get; set; }
    }

    public class WalkingData
    {
        public DateTime Date { get; set; }
        public string DayPrefix => Date.ToString("ddd");
        public int Steps { get; set; }
        public string Duration { get; set; } = string.Empty;
        public int WeekNumber => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        public int Year => Date.Year;
        public string Label { get; set; } = string.Empty;
    }
}
