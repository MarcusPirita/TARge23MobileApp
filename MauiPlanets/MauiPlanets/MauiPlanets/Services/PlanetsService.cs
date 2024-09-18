using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest in the Solar System. In English, it is named after the ancient Roman god Mercurius (Mercury), god of commerce and communication, and the messenger of the gods. ",
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
                Description = "Of all the planets, Venus is the one most similar to Earth. In fact, Venus is often called Earth's “sister” planet. As similar as it is in some ways, however, it is also very different in others. ",
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
                Description = "The Earth is the only planet known where life exists. Almost 1.5 million species of animals and plants have been discovered so far, and many more have yet to be found. While other planets may have small amounts of ice or steam, the Earth is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

			new()
			{
				Name = "Pluto",
				Subtitle = "The 9th planet",
				HeroImage = "pluto.png",
				Description = "Pluto is a dwarf planet in the Kuiper belt, " +
							"a ring of bodies beyond the orbit of Neptune. " +
							"It is the ninth-largest and tenth-most-massive known " +
							"object to directly orbit the Sun. " +
							"It is the largest known trans-Neptunian object by volume, " +
							"by a small margin, but is less massive than Eris. ",
				AccentColorStart = Color.FromArgb("#8c8265"),
				AccentColorEnd = Color.FromArgb("#d1c9b2"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/06/color-image-of-pluto-pia20291-1.jpg?w=2048&format=webp",
					"https://images-assets.nasa.gov/image/PIA11707/PIA11707~large.jpg?w=1920&h=960&fit=clip&crop=faces%2Cfocalpoint",
				}
			},

			new()
		    {
				Name = "Ceres",
				Subtitle = "The largest asteroid",
				HeroImage = "ceres.png",
				Description = "Ceres is a dwarf planet in the middle main asteroid belt " +
							"between the orbits of Mars and Jupiter. It was the first known asteroid, " +
							"discovered on 1 January 1801 by Giuseppe Piazzi at Palermo Astronomical " +
							"Observatory in Sicily, and announced as a new planet. ",
				AccentColorStart = Color.FromArgb("#0698c4"),
				AccentColorEnd = Color.FromArgb("#057799"),
				Images = new()
				{
					"https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg"
				}
			},

            new()
            {
                Name = "Haumea",
                Subtitle = "The space doughnut",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune's orbit. It was discovered " +
							"in 2004. Haumea's mass is about one-third that of Pluto " +
							"and 1/1400 that of Earth. Although its shape has not been directly " +
							"observed, calculations from its light curve are consistent with it " +
							"being a Jacobi ellipsoid, with its major axis twice as long as its minor. ",
                AccentColorStart = Color.FromArgb("#946d03"),
                AccentColorEnd = Color.FromArgb("#c49104"),
                Images = new()
                {
					"https://cdn.mos.cms.futurecdn.net/h5P8ZW8QJAscrMQ9r6euoc-650-80.jpg.webp",
					"https://pbs.twimg.com/media/FvoXf4JWIBY2ktX?format=jpg&name=large"
                }
            },

			new()
			{
				Name = "MakeMake",
				Subtitle = "The distant dwarf planet",
				HeroImage = "makemake.png",
				Description = "Makemake is a dwarf planet and the largest of what is known " +
							"as the classical population of Kuiper belt objects, with a diameter " +
							"approximately that of Saturn's moon Iapetus, or 60% that of Pluto. " +
							"Its extremely low average temperature, about 40 K (−230 °C), means its " +
							"surface is covered with methane, ethane, and possibly nitrogen ices.",
				AccentColorStart = Color.FromArgb("#d96302"),
				AccentColorEnd = Color.FromArgb("#7d3800"),
				Images = new()
				{
					"https://science.nasa.gov/wp-content/uploads/2023/07/Makemake_moon-1.jpeg?w=1280&format=webp",
					"https://cdn.mos.cms.futurecdn.net/8QBGiy9BhmttKdGeAAZpn8.jpg.webp",
					"https://astronz.nz/cdn/shop/articles/makemake.png?v=1682129134"
				}
			},

			new()
			{
				Name = "Eris",
				Subtitle = "The largest dwarf planet",
				HeroImage = "eris.png",
				Description = "Eris is the most massive and second-largest known dwarf planet in the Solar " +
							"System. It is a trans-Neptunian object in the scattered disk " +
							"and has a high-eccentricity orbit. Eris is the ninth-most massive known " +
							"object orbiting the Sun and the sixteenth-most massive overall in the Solar System. ",
				AccentColorStart = Color.FromArgb("#e0b989"),
				AccentColorEnd = Color.FromArgb("#63523d"),
				Images = new()
				{
					"https://images-assets.nasa.gov/image/PIA03034/PIA03034~orig.jpg?w=603&h=200&fit=clip&crop=faces%2Cfocalpoint",
					"https://science.nasa.gov/wp-content/uploads/2023/06/Artists_c_oncept_of_Eris_and_Dysnomia_far_from_the_Sun-jpeg.webp?w=1280&format=webp",
					"https://www.earth.com/assets/_next/image/?url=https%3A%2F%2Fcff2.earth.com%2Fuploads%2F2024%2F02%2F20135637%2FEris_icy-dwarf-planet_kuiper-belt_1m-1400x850.jpg&w=1200&q=75"
				}
			}
		};

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
