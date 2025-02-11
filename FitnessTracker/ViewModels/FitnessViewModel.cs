﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FitnessTracker.Models;

namespace FitnessTracker
{
    public class FitnessViewModel : INotifyPropertyChanged
    {

        #region Dummy chart data
        ObservableCollection<FitnessData>? _fitnessData;
        ObservableCollection<TrendData>? _cyclingData;
        ObservableCollection<TrendData>? _sleepingData;
        ObservableCollection<TrendData>? _weightData;
        ObservableCollection<TrendData>? _caloriesData;
        ObservableCollection<WalkingData>? _walkingData;
        ObservableCollection<WalkingData>? _walkingChartData;

        public ObservableCollection<FitnessData>? FitnessData
        {
            get => _fitnessData;
            set
            {
                _fitnessData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TrendData>? CyclingData
        {
            get => _cyclingData;
            set
            {
                _cyclingData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TrendData>? SleepingData
        {
            get => _sleepingData;
            set
            {
                _sleepingData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TrendData>? WeightData
        {
            get => _weightData;
            set
            {
                _weightData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TrendData>? CaloriesData
        {
            get => _caloriesData;
            set
            {
                _caloriesData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<WalkingData>? WalkingData
        {
            get => _walkingData;
            set
            {
                _walkingData = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<WalkingData>? WalkingChartData
        {
            get => _walkingChartData;
            set
            {
                _walkingChartData = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Brush
        public ObservableCollection<Brush>? CyclingColor { get; set; }
        public ObservableCollection<Brush>? SleepingColor { get; set; }
        public ObservableCollection<Brush>? WeightColor { get; set; }
        public ObservableCollection<Brush>? CaloriesColor { get; set; }
        public ObservableCollection<Brush>? WalkingColor { get; set; }
        #endregion

        public FitnessViewModel()
        {
            LoadData();
        }

        void LoadData()
        {
            #region Brush collections

            CyclingColor = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#0086E5")),
                new SolidColorBrush(Color.FromArgb("#0086E5")),
                new SolidColorBrush(Color.FromArgb("#0086E5")),
                new SolidColorBrush(Color.FromArgb("#0086E5")),
                new SolidColorBrush(Color.FromArgb("#0086E5"))
            };

            SleepingColor = new ObservableCollection<Brush>()
            {
                new LinearGradientBrush
                {
                    GradientStops = new GradientStopCollection
                    {
                        new GradientStop { Color = Color.FromArgb("#8618FC").WithAlpha(0.5f), Offset = 0.0f }, // Top color
                        new GradientStop { Color = Color.FromArgb("#8618FC").WithAlpha(0.0f), Offset = 1.0f } // Faded bottom
                    },
                    StartPoint = new Point(0, 0), // Start at the top
                    EndPoint = new Point(0, 1)   // End at the bottom
                }
            };

            WeightColor = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#E23739")),
                new SolidColorBrush(Color.FromArgb("#E23739")),
                new SolidColorBrush(Color.FromArgb("#E23739")),
                new SolidColorBrush(Color.FromArgb("#E23739")),
                new SolidColorBrush(Color.FromArgb("#E23739"))
            };

            CaloriesColor = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#736BEA")),
                new SolidColorBrush(Color.FromArgb("#736BEA")),
                new SolidColorBrush(Color.FromArgb("#736BEA")),
                new SolidColorBrush(Color.FromArgb("#736BEA")),
                new SolidColorBrush(Color.FromArgb("#736BEA"))
            };

            WalkingColor = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#116DF9")),
                new SolidColorBrush(Color.FromArgb("#116DF9")),
                new SolidColorBrush(Color.FromArgb("#116DF9")),
                new SolidColorBrush(Color.FromArgb("#116DF9")),
                new SolidColorBrush(Color.FromArgb("#116DF9"))
            };

            #endregion

            #region Dummay chart data

            CyclingData = new ObservableCollection<TrendData>()
            {
                // Cycling Trend
                new TrendData
                {
                    Name = "Cycling",
                    DataPoints = new List<DataPoint>
                    {
                        new DataPoint { Label = "Sun", Value = 2.0 },
                        new DataPoint { Label = "Mon", Value = 3.5 },
                        new DataPoint { Label = "Tue", Value = 2.8 },
                        new DataPoint { Label = "Wed", Value = 4.0 },
                        new DataPoint { Label = "Thu", Value = 3.0 },
                        new DataPoint { Label = "Fri", Value = 2.5 },
                        new DataPoint { Label = "Sat", Value = 3.8 }
                    }
                }
            };

            SleepingData = new ObservableCollection<TrendData>()
            {
                // Sleeping Trend (Last 7 Days)
                new TrendData
                {
                    Name = "Sleeping",
                    DataPoints = new List<DataPoint>
                    {
                        new DataPoint { Label = "Sun", Value = 7.0 },
                        new DataPoint { Label = "Mon", Value = 6.5 },
                        new DataPoint { Label = "Tue", Value = 7.2 },
                        new DataPoint { Label = "Wed", Value = 7.0 },
                        new DataPoint { Label = "Thu", Value = 6.8 },
                        new DataPoint { Label = "Fri", Value = 7.5 },
                        new DataPoint { Label = "Sat", Value = 7.0 }
                    }
                }
            };

            WeightData = new ObservableCollection<TrendData>()
            {
                // Weight Trend (Last 6 Months)
                new TrendData
                {
                    Name = "Weight",
                    DataPoints = new List<DataPoint>
                    {
                        new DataPoint { Label = "Aug", Value = 61.5 },
                        new DataPoint { Label = "Sep", Value = 62.5 },
                        new DataPoint { Label = "Oct", Value = 67.8 },
                        new DataPoint { Label = "Nov", Value = 67.8 },
                        new DataPoint { Label = "Dec", Value = 57.7 },
                        new DataPoint { Label = "Jan", Value = 67.9 }
                    }
                }
            };

            CaloriesData = new ObservableCollection<TrendData>()
            {
                // Calories Burned Trend (Last 7 Days)
                new TrendData
                {
                    Name = "Calories Burned",
                    DataPoints = new List<DataPoint>
                    {
                        new DataPoint { Label = "Sun", Value = 1000 },
                        new DataPoint { Label = "Mon", Value = 1100 },
                        new DataPoint { Label = "Tue", Value = 1050 },
                        new DataPoint { Label = "Wed", Value = 1150 },
                        new DataPoint { Label = "Thu", Value = 1075 },
                        new DataPoint { Label = "Fri", Value = 1125 },
                        new DataPoint { Label = "Sat", Value = 1200 }
                    }
                }
            };

            FitnessData = new ObservableCollection<FitnessData>
            {
                new FitnessData {
                Steps = new StepsData { Count = 6500, DistanceKm = 5.07, Calories = 213, MoveMinutes = 61 },
                HeartRate = new HeartRateData { BPM = 80 },
                Sleep = new SleepData { Hours = 7.5 },
                Calories = new CaloriesData { TotalCalories = 2150, ActiveCalories = 850, RestingCalories = 1300 },
                Trends = new List<TrendData>
        {
            // Cycling Trend
            new TrendData
            {
                Name = "Cycling",
                DataPoints = new List<DataPoint>
                {
                    new DataPoint { Label = "Sun", Value = 2.0 },
                    new DataPoint { Label = "Mon", Value = 3.5 },
                    new DataPoint { Label = "Tue", Value = 2.8 },
                    new DataPoint { Label = "Wed", Value = 4.0 },
                    new DataPoint { Label = "Thu", Value = 3.0 },
                    new DataPoint { Label = "Fri", Value = 2.5 },
                    new DataPoint { Label = "Sat", Value = 3.8 }
                }
            },

            // Sleeping Trend (Last 7 Days)
            new TrendData
            {
                Name = "Sleeping",
                DataPoints = new List<DataPoint>
                {
                    new DataPoint { Label = "Sun", Value = 7.0 },
                    new DataPoint { Label = "Mon", Value = 6.5 },
                    new DataPoint { Label = "Tue", Value = 7.2 },
                    new DataPoint { Label = "Wed", Value = 7.0 },
                    new DataPoint { Label = "Thu", Value = 6.8 },
                    new DataPoint { Label = "Fri", Value = 7.5 },
                    new DataPoint { Label = "Sat", Value = 7.0 }
                }
            },

            // Weight Trend (Last 6 Months)
            new TrendData
            {
                Name = "Weight",
                DataPoints = new List<DataPoint>
                {
                    new DataPoint { Label = "Aug", Value = 61.5 },
                    new DataPoint { Label = "Sep", Value = 62.0 },
                    new DataPoint { Label = "Oct", Value = 61.8 },
                    new DataPoint { Label = "Nov", Value = 62.5 },
                    new DataPoint { Label = "Dec", Value = 61.7 },
                    new DataPoint { Label = "Jan", Value = 62.5 }
                }
            },

            // Calories Burned Trend (Last 7 Days)
            new TrendData
            {
                Name = "Calories Burned",
                DataPoints = new List<DataPoint>
                {
                    new DataPoint { Label = "Sun", Value = 1000 },
                    new DataPoint { Label = "Mon", Value = 1100 },
                    new DataPoint { Label = "Tue", Value = 1050 },
                    new DataPoint { Label = "Wed", Value = 1150 },
                    new DataPoint { Label = "Thu", Value = 1075 },
                    new DataPoint { Label = "Fri", Value = 1125 },
                    new DataPoint { Label = "Sat", Value = 1200 }
                }
            }
        }
            }
            };

            LoadWalkingData();

            #endregion
        }

        void LoadWalkingData()
        {
            var rawData = new List<WalkingData>
            {
                new WalkingData { Date = new DateTime(2025, 2, 1), Steps = 1200, Duration = "50m 10s" }, // Sat
                new WalkingData { Date = new DateTime(2025, 1, 31), Steps = 1800, Duration = "1h 02m" }, // Fri
                new WalkingData { Date = new DateTime(2025, 1, 30), Steps = 1512, Duration = "1h 08m" }, // Thu
                new WalkingData { Date = new DateTime(2025, 1, 29), Steps = 336, Duration = "26m 09s" }, // Wed
                new WalkingData { Date = new DateTime(2025, 1, 28), Steps = 258, Duration = "22m 42s" }, // Tue
                new WalkingData { Date = new DateTime(2025, 1, 27), Steps = 353, Duration = "30m 22s" }, // Mon
                new WalkingData { Date = new DateTime(2025, 1, 26), Steps = 3126, Duration = "2h 02m" }  // Sun
            };

            WalkingData = new ObservableCollection<WalkingData>(
                rawData.OrderByDescending(a => a.Year)
                .ThenByDescending(a => a.WeekNumber)
                .ThenByDescending(a => a.Date.DayOfWeek)
            );

            WalkingChartData = new ObservableCollection<WalkingData>(
                rawData.OrderBy(d => (int)d.Date.DayOfWeek) // Sort from Sunday (0) to Saturday (6)
            );
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
