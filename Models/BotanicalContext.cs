using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace BotanicalAdventure.Models
{
  public class BotanicalAdventureContext : DbContext
  {
    public BotanicalAdventureContext(DbContextOptions<BotanicalAdventureContext> options)
      : base(options)
      {

      }
      public DbSet<Item> Items { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Item>()
          .HasData(
              //Mushroom
              new Item { ItemId = 1, Category = "Forest", Type = "Mushroom",
              Name = "Cauliflower Mushroom", Latin = "Sparassis Crispa", Description = "These illusive mushrooms range from light brown-yellow to creamy-white and resemble a sea sponge or head of cauliflower. They are round and range from 10 cm to 50cm in diameter. They are considered parasites or 'saprobes' as they derive their nutrients from trees.", Habitat = "Found at the base of hardwood trees such as: fir, pine, oak and spruce.",
              Smell = "Earthy and Musky", Taste = "Nutty, Earthy and Savory. Notes of fennel and almond.", Edible = true,
              EdibleDesc = "Brittle, semi-firm and chewy consistency. Very similar to egg noodles which makes them great for soups! Medicinally, the dry weight of the fruiting body was found to contain up to 43.6% beta-glucan which is approved for treatment of cancer. Sparassis also has strong anti-inflammatory, anti-tumor, anti-diabetic, and neuro/cardio protection properties.", Symbolism = "", History = "In Japan, Cauliflower mushrooms are known as Hanabiratake and have been utilized for both edible and medicinal purposes since ancient times.",
              Score = 100, Hint = "Look at the base of hardwoods where the sun can reach the forest floor but is partially shaded.", Difficulty = "3",
              Found = false, Picture = "../assets/img/forest_mushroom_3_cauliflower.jpg"},
              
              // Flower
              new Item { ItemId = 1, Category = "Coast", Type = "Flower",
              Name = "Common yarrow", Latin = "Achillea millefolium", Description = "This is an herbaceous, perennial plant that produces one to several stems 8-40 inches in height. The leaves are cauline, and more or les clasping.", Habitat = "It can grow from sea level to 3,500 m in elevation. It is frequently found in the mildly disturbed soil grasslands and open forests.",
              Smell = "Has a sweet scent similar to that of mums, so powerful that it may be irritating to some.", Taste = "Both its leaves and flowers are bitter and astringent.", Edible = true,
              EdibleDesc = "The entire plant is reportedly edible and nutritious.", Symbolism = "The name Achillea is derived from mythical Greek character Achilles, who reportedly carried it with his army to treat battle wounds.", History = "In antiquity, the plant was known as 'herba militaris' for its use in stanching the flow of blood from wounds. Other names implying its historical use in healing—particularly in the military—include bloodwort, knight's milfoil, staunchweed, and, from its use in the US Civil War, soldier's woundwort.",
              Score = 10, Hint = "Look for well-drained soil, and open spaces where the flower can have full sun.", Difficulty = "Easy",
              Found = false, Picture = "../assets/img/coast_flower_1_common-yarrow.jpg"},

              new Item { ItemId = 1, Category = "Coast", Type = "Flower",
              Name = "Pearly everlasting", Latin = "Anaphalis margaritacea", Description = "1-2 foot perennial that quickly spreads by underground roots. The wooly flowers are actually flower heads of tiny disc flowers subtended by papery white bracts.", Habitat = "Typically grows on dry, sandy or gravelly sites.",
              Smell = "", Taste = "", Edible = true,
              EdibleDesc = "The leaves and young plants are edible when cooked.", Symbolism = "", History = "The plant is dioecious, meaning the pollen-producing (male) and seed-producing (female) flowers are borne on separate plants.",
              Score = 30, Hint = "", Difficulty = "Medium",
              Found = false, Picture = "../assets/img/coast_flower_2_pearly-everlasting.jpg"},

              new Item { ItemId = 1, Category = "Coast", Type = "Flower",
              Name = "Foxglove", Latin = "Digitalis purpurea", Description = "It is a poisonous species of flowering plant in the plantain family Plantaginaceae", Habitat = "Grows in acidic soils, in partial sunlight to deep shade.",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "Don't eat it, it is poisonous.", Symbolism = "", History = "Due to the presence of the cardiac glycoside digitoxin, the leaves, flowers and seeds of this plant are all poisonous to humans and some animals and can be fatal if ingested.",
              Score = 60, Hint = "Look for them in moorland and heath margins, sea-cliffs, rocky mountain slopes and hedge banks.", Difficulty = "Medium",
              Found = false, Picture = "../assets/img/coast_flower_3_foxglove.jpg"},
              
              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Goldfields", Latin = "Crocidium multicaule", Description = "You’ll find these dime-sized flowers carpeting sagebrush flats. In particularly good wildflower seasons, that's no exaggeration--they truly carpet the ground.", Habitat = "Meadow, Shrub-Steppe, Coastal",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 15, Hint = "It grows from a small patch of somewhat fleshy leaves at the ground", Difficulty = "easy",
              Found = false, Picture = "../assets/img/Desert_flower_1_Goldfields.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Prairie Star", Latin = "Lithophragma parviflorum", Description = "Reminding us that nature is fragile, this early bloomer has a delicate, white to lavender-pink, irregular flower atop a slender red stem.", Habitat = "grasslands, sagebrush plains, dry open areas, at low to high elevations",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 20, Hint = "It has a somewhat sticky stem and each stem bears up to 14 flowers", Difficulty = "easy",
              Found = false, Picture = "../assets/img/desert_flower_1_prairiestar.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Spreading Phlox", Latin = "Phlox diffusa", Description = "This low-growing flower prefers rocky crevices and exposed locations. These beauties always astound with their pop of color--flowers have 5 pink-purple-white petals. Adapted to extreme environments, cushion-like plants like phlox often have taproots 8-15’ deep!", Habitat = "grasslands, sagebrush plains, dry open areas, at low to high elevations",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 25, Hint = "The blossoms are so profuse that they literally cover the evergreen foliage of narrow, needle-like, bright green leaves.", Difficulty = "easy",
              Found = false, Picture = "../assets/img/desert_flower_1_spreadingphlox.jpg"},
              
              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Sand Lily", Latin = "Leucocrinum monatanum", Description = "Sand lilies can often look like bunches of tissue paper dotting your view. It grows in rosette-like bunches with 4-8 white flowers per bunch.", Habitat = "sandy or rocky areas",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 50, Hint = "Blooms & leaves might be nipped off, as it is a favorite snack of rabbits and deers!", Difficulty = "medium",
              Found = false, Picture = "../assets/img/desert_flower_2_sandlily.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Spotted Fritillary", Latin = "Fritillaria atropurpurea", Description = "Perhaps one of our most unusual lilies, the spotted fritillary is brown to greenish in color with yellow, red, or white markings. They can be hard to spot because of their subdued color!", Habitat = "grasslands or Cascade foothill forests",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 65, Hint = "Flowers hang downward or facing outward and 1-3 blooms can be found per stalk.", Difficulty = "medium",
              Found = false, Picture = "../assets/img/desert_flower_2_spottedfritillary.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Brown’s peony", Latin = "Paeonia brownii", Description = "This bloom is easy to miss with its nodding, muted flowerheads. This generalist wildflower that attracts all sorts of flies, wasps, and other insects for pollination has an interesting feature that might not be seen at first glance.", Habitat = " It thrives in fir and aspen woods, but can also be found in Central Oregon’s ponderosa pine forests and dry sagebrush deserts.",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "Unusual for peonies, Brown’s peony has floral nectar, which is a critical food source for native pollinators in early spring when there aren’t many food options.",
              Score = 75, Hint = "Leaves are divided with rounded tips. Flower is clustered at the stem top and hangs down.", Difficulty = "medium",
              Found = false, Picture = "../assets/img/desert_flower_2_brownspeony.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Bradshaw's desert parsley", Latin = "Lomatium bradshawii", Description = "Bradshaw's desert parsley is a low, more or less erect perennial species that grows from a long slender taproot.", Habitat = "wet prairie habitats in clay soils or substrates having a dense clay layer below the surface",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "It was thought to be extinct until 1979, when it was rediscovered by a University of Oregon graduate. This herb was common in the Willamette Valley before agricultural development and fire prevention which has allowed shrubs and weeds to invade. In 2021, it was taken off the endangered species list.",
              Score = 100, Hint = "Species is flowering from mid April through May.", Difficulty = "hard",
              Found = false, Picture = "../assets/img/desert_flower_3_bradshawsdesertparsley.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Prairie smoke", Latin = "Geum triflorum", Description = "The flower looks like a bulbous lantern. These flowers are usually in groups of three on nodding stems. The sepals of the plant (the part that supports the petals in bloom and is often green) are fused together to form a cup (or bulbous lantern!) with tips curving outwards.", Habitat = "dry meadows, pine forests, and sagebrush desert",
              Smell = "", Taste = "", Edible = true,
              EdibleDesc = "Native Americans used this plant for medicinal purposes", Symbolism = "Prairie smoke is an essence for softening excessive personal boundaries. It finds and brings forth softness, a yielding quality, and a feeling of acceptance of however small or fragile we may feel we are.", History = "It was thought to be extinct until 1979, when it was rediscovered by a University of Oregon graduate. This herb was common in the Willamette Valley before agricultural development and fire prevention which has allowed shrubs and weeds to invade. In 2021, it was taken off the endangered species list.",
              Score = 85, Hint = "After pollination the stems slowly turn upright, so that by the time the tufted fruit appear the feathery heads look like smoke wafting away from the plant – or something like the little “troll” dolls that once were so popular", Difficulty = "hard",
              Found = false, Picture = "../assets/img/desert_flower_3_prairiesmoke.jpg"},

              new Item { ItemId = 1, Category = "Desert", Type = "Flower",
              Name = "Ragged robin", Latin = "Clarkia pulchella", Description = "What an unusual flower shape! I’m guessing that when you were a child and drew a flower, the petals did not look like this (or maybe you were a terrible artist like me and they DID look like a ragged robin!)", Habitat = "rocky, sandy locations",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "It was described by Meriwether Lewis close to Kamiah, Idaho during the Lewis and Clark Expedition and it was subsequently brought back as a botanical specimen. The discovery was first described on May 28, 1806, by William Clark and subsequently by Lewis on June 1 of that year.",
              Score = 85, Hint = "Ragged robin has pink petals that are divided into three lobes with the central lobe wider than the other two.", Difficulty = "hard",
              Found = false, Picture = "../assets/img/desert_flower_3_raggedrobin.jpg"}
        

              //Plant
              
              //Tree

               );
    }
  }
}