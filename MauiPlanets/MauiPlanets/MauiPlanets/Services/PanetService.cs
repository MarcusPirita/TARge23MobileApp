﻿using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Services
{
    class PanetService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
					"https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
				}
			},
			new()
			{
				Name = "Venus",
				Subtitle = "The pressure cooker",
				HeroImage = "venus.png",
				Description = "Venus is the second planet from the Sun. It is a terrestrial planet and is the closest in mass and size to its orbital neighbour Earth. Venus is notable for having the densest atmosphere of the terrestrial planets.",
				AccentColorStart = Color.FromArgb("#a6393b"),
				AccentColorEnd = Color.FromArgb("#d17f21"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
					"https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
				}
			},
			new()
			{
				Name = "Earth",
				Subtitle = "The cradle of life",
				HeroImage = "earth.png",
				Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being an ocean world, the only one in the Solar System sustaining liquid surface water.",
				AccentColorStart = Color.FromArgb("#0e3d68"),
				AccentColorEnd = Color.FromArgb("#2e97c7"),
				Images = new()
				{
					"https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
					"https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
					"https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
				}
			},
			new()
			{
				Name = "Mars",
				Subtitle = "The red beauty",
				HeroImage = "mars.png",
				Description = "Mars is the fourth planet from the Sun. The surface of Mars is orange-red because it is covered in iron(III) oxide dust, giving it the nickname \"the Red Planet\".",
				AccentColorStart = Color.FromArgb("#a23036"),
				AccentColorEnd = Color.FromArgb("#eb3333"),
				Images = new()
				{
					"https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
					"https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
					"https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
				}
			},
		};
    }
}
