using System;
using System.Collections.Generic;

public class FeatureCollection
    {
        public string Type { get; set; }
        public List<Feature> Features { get; set; }

        public void DisplayEarthquakeSummary()
        {
            if (Features != null && Features.Count > 0)
            {
                Console.WriteLine($"Number of earthquakes: {Features.Count}");

                foreach (var feature in Features)
                {
                    Console.WriteLine($"Place: {feature.Properties.Place} - Mag {feature.Properties.Mag}");
                }
            }
            else
            {
                Console.WriteLine("No earthquake data found.");
            }
        }
    }

    public class Feature
    {
        public string Type { get; set; }
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Properties
    {
        public string Place { get; set; }
        public double Mag { get; set; }
        // Other properties related to the earthquake
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
        // Other properties related to geometry
    }
