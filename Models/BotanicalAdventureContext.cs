using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Proxies;
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
              Found = false, Picture = "https://drive.google.com/file/d/1OO4mIo_OmwYNJzcwYTcYcYjHetI_yVBP/preview"},
              

              new Item { ItemId = 2, Category = "Forest", Type = "Mushroom",
              Name = "Fly Amanita", Latin = "Amanita Muscaria", Description = "These iconic mushrooms are large, white-gilled and red-capped with bumpy white spots.", Habitat = "Forms symbiotic relationships with many trees including pine, oak, spruce, fir, birch, and cedar. Although they require this relationship with trees, they grow from the soil and are not always right at the base of a tree. Unlike most mushrooms, Amanita Muscaria is tolerant to colder temperatures and thrives in the boreal region.",
              Smell = "Mild Earthiness", Taste = "Nutty and Slightly Buttery", Edible = false,
              EdibleDesc = "Not suitable for consumption", Symbolism = "", History = "Although considered inedible due to a high level of toxins which cause gastrointestinal issues, they are noted for their hallucinogenic properties with the main psychoactive constituents being the neurotoxins ibotenic acid and muscimol. A local variety of the mushroom was used as an intoxicant and entheogen by the indigenous peoples of Siberia and by the Sámi, and has a religious significance in these cultures",
              Score = 25, Hint = "Check light soil terrain specifically around birch trees.", Difficulty = "1",
              Found = false, Picture = "https://drive.google.com/file/d/1A0oevkGY-IK7YuTt1bqD6Z2wet2NLD44/preview"},

              new Item { ItemId = 3, Category = "Forest", Type = "Mushroom",
              Name = "Chanterelle", Latin = "Cantharellus Cibarius", Description = "These bright mushrooms are orange or yellow, very dense and meaty. Rather than gills, they have forked folds or ridges that run down the stipe, or stem, and have a smooth cap.", Habitat = "Tend to grow in clusters in mossy coniferous forests, but are also often found in mountainous birch forests and among grasses and low-growing herbs. They love moisture, shade and an abundance of organic matter.",
              Smell = "Fruity and Apricot-like", Taste = "Mildly Peppery", Edible = true,
              EdibleDesc = "Chanterelles are very meaty and hold their structure well which means they can be prepared in many ways without losing their integrity. Although they have a bit of a perppery flavor, they will absorb whichever flavors you cook them with. Simply sauteeing in butter is a forager's favorite way to prepare these mushrooms to really experience the natural flavor.", Symbolism = "Chanterelles have been eaten as early as the 16th century and their popularity amongst the nobility as the influence of French cuisine spread meant they became a Symbol of Wealth.", History = "The name chanterelle originates from the Greek kantharos meaning tankard or cup",
              Score = 50, Hint = "Look under leaves around douglas firs in late summer or early fall.", Difficulty = "2",
              Found = false, Picture = "https://drive.google.com/file/d/1fSI1HEVfaUbpJk_z7ZJv1Qp4Df8LuF9O/preview"},

              new Item { ItemId = 4, Category = "Coast", Type = "Mushroom",
              Name = "Lobster Mushroom", Latin = "Hypomyces Lactifluorum", Description = "This 'mushroom' is bright reddish-orange and is very firm and dense, with a pimpled 'cap'. It is often twisted into odd shapes and the inside is white. Contrary to its common name it is not a mushroom, but rather a parasitic ascomycete fungus that grows on milk cap mushrooms and russula mushrooms, turning them a reddish orange color that resembles the outer shell of a cooked lobster. Most milk caps and russulas are inedible in their natural form, so this ascomycete fungus turns the inedible to edible.", Habitat = "Found in woods and forests in the coastal regions of the PNW. They are especially likely under hemlock trees, and usually appear in September or October. They may grow singly, in pairs or in clusters.",
              Smell = "Shrimpy, Nutty, Slightly Sweet", Taste = "Seafood-like", Edible = true,
              EdibleDesc = "Lobster mushrooms are incredibly dense and are best when cooked in smaller chunks. Unlike most mushrooms, lobsters have a strong, distinct seafood flavor. Because of this, they are often used in seafood dishes to enhance the flavor, rather than trying to infuse other flavor into the mushroom itself. Of course, sauteeing in butter will allow you to get the full flavor of the mushroom itself.", Symbolism = "", History = "The name hypomyces is a Greek word meaning 'mushroom underneath'.",
              Score = 50, Hint = "Don't be afraid to dig! If you see a mound of pine needles and dirt that looks out of place it's probably a lobster mushroom.", Difficulty = "medium", Found = false, Picture = "https://drive.google.com/file/d/1IOMraKq3BamHzIje9p90hXq6ndntwaU2/preview"},
              
              // Flower
              new Item { ItemId = 5, Category = "Forest", Type = "Flower", Name = "Salmon Berry", Latin ="Rubus Spectabilis", Description = "Salmon Berry is a shrub growing to 3.5 to 13 feet tall and has pink, purple, or red flowers. It is known for its fruit, which bears resemblance to a raspberry.", Habitat = "Moist spots in and around woods", Smell = "", Taste = "Bland", Edible = true, EdibleDesc = "Fruit is edible, but tastes bland", Symbolism = "Holiness", History = "The name of Salmonberry is believed to have originated from the natives' preference to eat them with salmon roe.", Score = 25, Hint = "Lighter in color than Raspberries", Difficulty = "easy", Found = false  , Picture = "https://drive.google.com/file/d/18yqjm8OtCCXzD213zck_Vzdt2HUkbEcZ/preview"},
              
              new Item { ItemId = 6, Category = "Forest", Type = "Flower", Name = "Bleeding Heart", Latin ="Dicentra Formosa", Description = "Pacific bleeding heart is a perennial plant that grows from 10 - 20 inches tall. It has attractive blue-green lacy foliage and blooms delicate pink flowers in late spring. Its heart-shaped flowers grow in clusters and if deadheaded will continue to bloom through summer.", Habitat = "damp soil with partial shade", Smell = "", Taste = "", Edible = true, EdibleDesc = "In the form of a root tincture or hot compress it can help pain relief, and can be applied externally to bruises and sprains. Internally, the tincture of bleeding heart can also help calm frazzled nerves especially after a frightening experience such as an accident or other trauma. The roots of this plant are generally gathered in summer and fall, up to the time when the leaves start to turn.", Symbolism = "Romantic love and purity", History = "", Score = 50, Hint = "Check near rivers and creeks", Difficulty = "medium", Found = false, Picture = "https://drive.google.com/file/d/1byzrsYDAPSDtoqdTYRE1Oue1XhZwnEOs/preview"},

              new Item  { ItemId = 7, Category = "Forest", Type = "Flower", Name = "Orange Honeysuckle", Latin ="Lonicera Ciliosa", Description = "Native to the forests of western North America, the orange Honeysuckle is a deciduous shrub that can shoot up to 20 fet tall and intertwine into the canopy of trees and other shrubs. ", Habitat = "Dry to moderately moist forested thickets; north-facing slopes and streambanks.", Smell = "Ravioli", Taste = "", Edible = true, EdibleDesc = "They eventually give way to translucent, orange-red berries. The fruits are edible either raw or cooked.", Symbolism = "Love, divination, luck", History = "The tubular flowers are favorites for hummingbirds, as their beaks fit perfectly inside to get the nectar.", Score = 50, Hint = "Check near rivers and creeks", Difficulty = "medium", Found = false, Picture = "https://drive.google.com/file/d/1i1eyjLjAO-rAc6oG9pKVsBiIucndYOOY/preview"},

              new Item { ItemId = 8, Category = "Forest", Type = "Flower", Name = "Calypso Orchid", Latin ="Calypso Bulbosa", Description = "1 widely oval basal leaf on short petiole. Leaf 1–2 1/2 in. across at widest point, with parallel veins, emerging in autumn, persisting through winter, withering in summer. Flower consists of 3 showy, usually rosy pink, pointed sepals and 2 usually pink petals above large, hanging, white or lighter pink slipper with rose-madder spotting. Bracts wrapping stem 2–4, top bract erect above flower. Albinos are not rare.", Habitat = "Grows in deep forests in mountains around the world, below 5500 ft.", Smell = "Ravioli", Taste = "", Edible = false, EdibleDesc = "This plant is endangered. Do not forrage. ", Symbolism = "Love, divination, luck", History = "The genus is named for the beautiful sea nymph in Homer's Odyssey.", Score = 100, Hint = "Calypso is Greek for she who conceals." , Difficulty = "hard", Found = false, Picture = "https://drive.google.com/file/d/1Ij4BIO8LeYLoZiHKxHn4PkokiISqG9Q3/preview"},

              new Item  { ItemId = 9, Category = "Forest", Type = "Flower", Name = "Columbian Monkshood", Latin ="Aconitum columbianum", Description = "Named for its hooded flowers, the columbian Mondshood's sepals resemble a monk's cowl.", Habitat = "Moist wet areas.", Smell = "Ravioli", Taste = "", Edible = false, EdibleDesc = "This plant is considered to be poisonous", Symbolism = "Beware, a deadly foe is near", History = "", Score = 25, Hint = "Blooms in summer." , Difficulty = "easy", Found = false, Picture = "https://drive.google.com/file/d/1r-LdtTz5I5Dn2dKYqS-mu07KY2sJVVk8/preview"},


              new Item { ItemId = 28, Category = "Forest", Type = "Flower", Name = "Huckle Berry", Latin ="Vaccinium Corymbosum", Description = "Huckleberry fruits are edible and resemble blueberries (Vaccinium species), to which they are closely related.", Habitat = "require acidic and moist but well-drained soil. Can only be found at elevations above 5,000 ft.", Smell = "Ravioli", Taste = "Better than blue berries", Edible = true, EdibleDesc = "Berries are edible", Symbolism = "", History = "Huckleberry plants can only grow in the wild", Score = 100, Hint = "check in high places" , Difficulty = "hard", Found = false, Picture = "https://drive.google.com/file/d/1qfygAZ0nz8UswaQW-30WXoXfbeQBFR1R/preview"},
              
              new Item { ItemId = 10, Category = "Coast", Type = "Flower",
              Name = "Common yarrow", Latin = "Achillea millefolium", Description = "This is an herbaceous, perennial plant that produces one to several stems 8-40 inches in height. The leaves are cauline, and more or les clasping.", Habitat = "It can grow from sea level to 3,500 m in elevation. It is frequently found in the mildly disturbed soil grasslands and open forests.",
              Smell = "Has a sweet scent similar to that of mums, so powerful that it may be irritating to some.", Taste = "Both its leaves and flowers are bitter and astringent.", Edible = true,
              EdibleDesc = "The entire plant is reportedly edible and nutritious.", Symbolism = "The name Achillea is derived from mythical Greek character Achilles, who reportedly carried it with his army to treat battle wounds.", History = "In antiquity, the plant was known as 'herba militaris' for its use in stanching the flow of blood from wounds. Other names implying its historical use in healing—particularly in the military—include bloodwort, knight's milfoil, staunchweed, and, from its use in the US Civil War, soldier's woundwort.",
              Score = 10, Hint = "Look for well-drained soil, and open spaces where the flower can have full sun.", Difficulty = "Easy",
              Found = false, Picture = "https://drive.google.com/file/d/1VdQdvAu2vDOnRmYKkvcw47f3yh-SZfWG/preview"},

              new Item { ItemId = 11, Category = "Coast", Type = "Flower",
              Name = "Pearly everlasting", Latin = "Anaphalis margaritacea", Description = "1-2 foot perennial that quickly spreads by underground roots. The wooly flowers are actually flower heads of tiny disc flowers subtended by papery white bracts.", Habitat = "Typically grows on dry, sandy or gravelly sites.",
              Smell = "", Taste = "", Edible = true,
              EdibleDesc = "The leaves and young plants are edible when cooked.", Symbolism = "", History = "The plant is dioecious, meaning the pollen-producing (male) and seed-producing (female) flowers are borne on separate plants.",
              Score = 30, Hint = "", Difficulty = "Medium",
              Found = false, Picture = "https://drive.google.com/file/d/12TWxGANeYY6AeRVCwOShoHX6cwuZ8cgY/preview"},

              new Item { ItemId = 12, Category = "Coast", Type = "Flower",
              Name = "Foxglove", Latin = "Digitalis purpurea", Description = "It is a poisonous species of flowering plant in the plantain family Plantaginaceae", Habitat = "Grows in acidic soils, in partial sunlight to deep shade.",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "Don't eat it, it is poisonous.", Symbolism = "", History = "Due to the presence of the cardiac glycoside digitoxin, the leaves, flowers and seeds of this plant are all poisonous to humans and some animals and can be fatal if ingested.",
              Score = 60, Hint = "Look for them in moorland and heath margins, sea-cliffs, rocky mountain slopes and hedge banks.", Difficulty = "Medium",
              Found = false, Picture = "https://drive.google.com/file/d/1sMxsSXy7rBKpLDy9VGtSJL6w04wRUm3q/preview"},
              
              new Item { ItemId = 13, Category = "Desert", Type = "Flower",
              Name = "Goldfields", Latin = "Crocidium multicaule", Description = "You’ll find these dime-sized flowers carpeting sagebrush flats. In particularly good wildflower seasons, that's no exaggeration--they truly carpet the ground.", Habitat = "Meadow, Shrub-Steppe, Coastal",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 15, Hint = "It grows from a small patch of somewhat fleshy leaves at the ground", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1aa8_ztBf1MVV7liGyCsLD3-bOXSf5EES/preview"},

              new Item { ItemId = 14, Category = "Desert", Type = "Flower",
              Name = "Prairie Star", Latin = "Lithophragma parviflorum", Description = "Reminding us that nature is fragile, this early bloomer has a delicate, white to lavender-pink, irregular flower atop a slender red stem.", Habitat = "grasslands, sagebrush plains, dry open areas, at low to high elevations",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 20, Hint = "It has a somewhat sticky stem and each stem bears up to 14 flowers", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1gxhxYjvQE9hJpjTpmVlELmqoNFTRTf7F/preview"},

              new Item { ItemId = 15, Category = "Desert", Type = "Flower",
              Name = "Spreading Phlox", Latin = "Phlox diffusa", Description = "This low-growing flower prefers rocky crevices and exposed locations. These beauties always astound with their pop of color--flowers have 5 pink-purple-white petals. Adapted to extreme environments, cushion-like plants like phlox often have taproots 8-15’ deep!", Habitat = "grasslands, sagebrush plains, dry open areas, at low to high elevations",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 25, Hint = "The blossoms are so profuse that they literally cover the evergreen foliage of narrow, needle-like, bright green leaves.", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1PT_5RCOoy7mps2HhD99oYgMjkar5BsoI/preview"},
              
              new Item { ItemId = 16, Category = "Desert", Type = "Flower",
              Name = "Sand Lily", Latin = "Leucocrinum monatanum", Description = "Sand lilies can often look like bunches of tissue paper dotting your preview. It grows in rosette-like bunches with 4-8 white flowers per bunch.", Habitat = "sandy or rocky areas",
              Smell = "fragrant", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 50, Hint = "Blooms & leaves might be nipped off, as it is a favorite snack of rabbits and deers!", Difficulty = "medium",
              Found = false, Picture = "https://drive.google.com/file/d/1rx7_fJIpsvvo2gD8RwMTa36C-w9QOe1C/preview"},

              new Item { ItemId = 17, Category = "Desert", Type = "Flower",
              Name = "Spotted Fritillary", Latin = "Fritillaria atropurpurea", Description = "Perhaps one of our most unusual lilies, the spotted fritillary is brown to greenish in color with yellow, red, or white markings. They can be hard to spot because of their subdued color!", Habitat = "grasslands or Cascade foothill forests",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "",
              Score = 65, Hint = "Flowers hang downward or facing outward and 1-3 blooms can be found per stalk.", Difficulty = "medium",
              Found = false, Picture = "https://drive.google.com/file/d/1dQFmOnA0KWRk7Rf_WnjCUL59AvAnCsO9/preview"},

              new Item { ItemId = 18, Category = "Desert", Type = "Flower",
              Name = "Brown’s peony", Latin = "Paeonia brownii", Description = "This bloom is easy to miss with its nodding, muted flowerheads. This generalist wildflower that attracts all sorts of flies, wasps, and other insects for pollination has an interesting feature that might not be seen at first glance.", Habitat = " It thrives in fir and aspen woods, but can also be found in Central Oregon’s ponderosa pine forests and dry sagebrush deserts.",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "Unusual for peonies, Brown’s peony has floral nectar, which is a critical food source for native pollinators in early spring when there aren’t many food options.",
              Score = 75, Hint = "Leaves are divided with rounded tips. Flower is clustered at the stem top and hangs down.", Difficulty = "medium",
              Found = false, Picture = "https://drive.google.com/file/d/1Pf803UlHtIhJNpndF1gp80xpC0nCQtsx/preview"},

              new Item { ItemId = 19, Category = "Desert", Type = "Flower",
              Name = "Bradshaw's desert parsley", Latin = "Lomatium bradshawii", Description = "Bradshaw's desert parsley is a low, more or less erect perennial species that grows from a long slender taproot.", Habitat = "wet prairie habitats in clay soils or substrates having a dense clay layer below the surface",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "It was thought to be extinct until 1979, when it was rediscovered by a University of Oregon graduate. This herb was common in the Willamette Valley before agricultural development and fire prevention which has allowed shrubs and weeds to invade. In 2021, it was taken off the endangered species list.",
              Score = 100, Hint = "Species is flowering from mid April through May.", Difficulty = "hard",
              Found = false, Picture = "https://drive.google.com/file/d/1bFSo52XFR5LNsziUPKDtg1QEe1wlVMFh/preview"},

              new Item { ItemId = 20, Category = "Desert", Type = "Flower",
              Name = "Prairie smoke", Latin = "Geum triflorum", Description = "The flower looks like a bulbous lantern. These flowers are usually in groups of three on nodding stems. The sepals of the plant (the part that supports the petals in bloom and is often green) are fused together to form a cup (or bulbous lantern!) with tips curving outwards.", Habitat = "dry meadows, pine forests, and sagebrush desert",
              Smell = "", Taste = "", Edible = true,
              EdibleDesc = "Native Americans used this plant for medicinal purposes", Symbolism = "Prairie smoke is an essence for softening excessive personal boundaries. It finds and brings forth softness, a yielding quality, and a feeling of acceptance of however small or fragile we may feel we are.", History = "It was thought to be extinct until 1979, when it was rediscovered by a University of Oregon graduate. This herb was common in the Willamette Valley before agricultural development and fire prevention which has allowed shrubs and weeds to invade. In 2021, it was taken off the endangered species list.",
              Score = 85, Hint = "After pollination the stems slowly turn upright, so that by the time the tufted fruit appear the feathery heads look like smoke wafting away from the plant – or something like the little “troll” dolls that once were so popular", Difficulty = "hard",
              Found = false, Picture = "https://drive.google.com/file/d/1VrIF9gpSJ2osLRB_CYlbBMzaJVsyghLT/preview"},

              new Item { ItemId = 21, Category = "Desert", Type = "Flower",
              Name = "Ragged robin", Latin = "Clarkia pulchella", Description = "What an unusual flower shape! I’m guessing that when you were a child and drew a flower, the petals did not look like this (or maybe you were a terrible artist like me and they DID look like a ragged robin!)", Habitat = "rocky, sandy locations",
              Smell = "", Taste = "", Edible = false,
              EdibleDesc = "", Symbolism = "", History = "It was described by Meriwether Lewis close to Kamiah, Idaho during the Lewis and Clark Expedition and it was subsequently brought back as a botanical specimen. The discovery was first described on May 28, 1806, by William Clark and subsequently by Lewis on June 1 of that year.",
              Score = 85, Hint = "Ragged robin has pink petals that are divided into three lobes with the central lobe wider than the other two.", Difficulty = "hard",
              Found = false, Picture = "https://drive.google.com/file/d/14LyVI8S7_N0Z9gP_nj8RduDEh-0EAyFd/preview"},
        

              //Plant
              
              //Tree
              new Item { ItemId = 22, Category = "Desert", Type = "Tree",
              Name = "Gray rabbitbrush", Latin = "Ericameria nauseosa", Description = "Rabbitbrush can grow 5-7 feet tall. It has flower heads that consist of small, yellow, tubular flowers arranged in dense clusters. Rabbitbrush's presence might help reduce the severity of weed invasions, using its deep roots and large amounts of leaf litter to outcompete invasive weeds. ", Habitat = "open lands and in east-side forests.",
              Smell = "pungent/pineapple-like flowers", Taste = "bitter", Edible = true,
              EdibleDesc = "A decoction of the twigs has been used in the treatment of toothaches, coughs and chest pains. An infusion of the flowering stems has been used in the treatment of colds and TB. An infusion of the leaves and stems has been used to treat colds, diarrhoea, stomach cramps, etc. It has also been used externally as a wash for sores and skin eruptions, especially smallpox. The plant shows slight bactericidal activity.", Symbolism = "", History = "Native Americans reportedly used rabbitbrush as a yellow dye, to make a medicinal tea, and for chewing gum. Rabbitbrush was first tested as a source of high quality rubber during World War II. In recent decades, there has been renewed interest in its potential for production of rubber, resins, and other chemicals. Compounds in rubber rabbitbrush are being evaluated for nematocides, anti-malarial properties, and insect repellents. Rubber rabbitbrush has also been identified as a potential source of biomass and biocrude fuels.",
              Score = 25, Hint = "Flowers bloom from August to October as other plants are fading, providing vivid color and a pollen source for insects late in the summer. ", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1Hp762UZlyyI5PQXXzYuqkpTt0g-L00MX/preview"},
              
              new Item { ItemId = 23, Category = "Desert", Type = "Tree",
              Name = "Big Sagebrush", Latin = "Artemisia tridentata", Description = "This shrub grows 3-6 1/2 feet tall with a thick, woody trunk. Leaves are gray-green, evergreen, and soft. They have 3 lobes on a wide tip.", Habitat = "arid and semi-arid conditions, throughout a range of cold desert, steppe, and mountain habitats.",
              Smell = " strong turpentine-like odor, especially when wet", Taste = "bitter", Edible = true,
              EdibleDesc = "Sagebrush can be used in preparing a lot of dishes. These dishes may include drinks such as those which various fruits in them. Mostly cocktails are made with the help of sage brush as a good additive in the form of a flavor booster. The Native Americans used to make flour from the seeds of sagebrush which would later on become a normal part of their day to day diet.", Symbolism = "Native Americans use Sagebrush or purification of body and soul, as a smoke during the ritual sweat lodges, and as a smudge to clear the energy of a room or environment.", History = "Native Americans used to make pastes and salves out of sage brush to treat various wounds and other injuries. Some Native American nations even used sagebrush to treat to headaches. Others would use it for getting rid of pain in various parts of the body. When a sagebrush plant is attacked by predators like insects, the plant emits volatile organic compounds that neighboring sagebrush plants can sense and react to by producing defensive chemicals that make them unattractive, or even poisonous, to the attackers.  And other plants, like wild tobacco, can eavesdrop on this and ramp up their own defenses, significantly lowering damage from feeding animals. ",
              Score = 15, Hint = "Flowers are quite small and yellow with hairy stems.", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1FY1ZEoyuauLY9rLeIlGcdkjh7f0Qe6jX/preview"},

              new Item { ItemId = 24, Category = "Desert", Type = "Tree",
              Name = "Ponderosa Pine", Latin = "Pinus ponderosa", Description = "Ponderosa pines are a very common evergreen in Central Oregon. The bark helps to distinguish it from other species. Mature to over-mature individuals have yellow to orange-red bark in broad to very broad plates with black crevices. Younger trees have blackish-brown bark, referred to as blackjacks by early loggers.", Habitat = "dry forest lands",
              Smell = "pine", Taste = "herbal, sweet, a little perfumey", Edible = true,
              EdibleDesc = "Native Americans consumed the seeds and sweet inner bark. They chewed the dried pitch, which was also used as a salve. The needles were also boiled into a solution to treat coughs and fevers.", Symbolism = "For Native Americans, they represent wisdom and longevity. To other cultures, they represent fertility and life. ", History = "Native Americans used the limbs and branches as firewood and building material, and the trunks were carved into canoes. The needles and roots were made into baskets. In the 19th and 20th centuries, old-growth trees were widely used by settlers as lumber, including for railroads.",
              Score = 15, Hint = "If you smell the deep furrows in the bark, it often smells like butterscotch or vanilla.", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1Z8Z5oLQ3cD_jojTKAGzB6dU1qPYGKM0Q/preview"},

              new Item { ItemId = 25, Category = "Desert", Type = "Tree",
              Name = "Western Junipers", Latin = "Juniperus occidentalis", Description = "Old-growth western junipers (Juniperus occidentalis) are stooped and twisted, their furrowed red bark typically blanketed in lichen. ", Habitat = "Usually found on thin rocky or sandy soils on desert foothills and lower mountains, also on windswept peaks up to elevations of 3,000 metres where they become low gnarled shrubs.",
              Smell = "", Taste = "resinous, sweet", Edible = true,
              EdibleDesc = "Fruit - raw or cooked. A thin dry flesh with a resinous flavour. The fruit is sweet and nutritious, it can also be dried or ground into a powder and mixed with cereal flours to be made into a bread.The cones are about 10mm in diameter, they take 2 years to mature.", Symbolism = "John Michael Greer in the Encyclopedia of Natural Magic suggests that Juniper is tied to the element of fire, with its astrological aspects being Mars in Aries (can’t get much more fiery than that!) ", History = "Western juniper was quite widely employed as a medicinal herb by a number of native North American tribes who used it to treat a variety of complaints, especially those related to the kidneys and the skin.",
              Score = 60, Hint = "Juniperus occidentalis is a shrub or small tree 4–15 meters (13–49 ft) tall. Exceptionally tall specimens can be found in the John Day area of Oregon in excess of 26–28 m (85–92 ft) tall.", Difficulty = "medium",
              Found = false, Picture = "https://drive.google.com/file/d/1KSjwABcihhk2rEYIPcjpEpdtIPmWUAGl/preview"},

              new Item { ItemId = 26, Category = "Desert", Type = "Tree",
              Name = "Snowbrush", Latin = "Ceanothus velutinus", Description = "A VERY fragrant shrub (your nose will alert you to its presence!). Snowbrush has stout stems that are many branched, growing 3-11 feet tall. It has 1-3 inch shiny evergreen leaves that are widely oval and finely toothed. Flowers are white in thick rounded clusters near the tops of stems.", Habitat = "Moist to dry open forests, brushy sites, rocky slopes, and recently burned or disturbed areas such as roadsides and logged areas at low to subalpine elevations.",
              Smell = "heavy, spicy-resinous fragrance", Taste = "astringent", Edible = true,
              EdibleDesc = "The dried leaves make a pleasant tasting, astringent tea that can be used as a caffeine-free black tea substitute. Kootenai tribes used the tea to treat tuberculosis.  Other native tribes used a decoction of leaves for eczema, dandruff, and arthritis.", Symbolism = "", History = "Their seeds can remain buried for over 200 years before sprouting. Snowbrush is beneficial to bees and butterflies, and is a host plant for California tortoiseshells, pale tiger swallowtails, and spring azures, among others. Saponins, foam-producing compounds, in the flowers also make it useful for soap.",
              Score = 45, Hint = "Often grows in dense patches in open areas.", Difficulty = "medium",
              Found = false, Picture = "https://drive.google.com/file/d/1_Xi_Q9kyXRUhmiJsgoKr4CfdzKzIYxwL/preview"},

              new Item { ItemId = 27, Category = "Desert", Type = "Tree",
              Name = "Grand Fir", Latin = "Abies grandis", Description = "A fir native to the Pacific Northwest and Northern California of North America, occurring at altitudes of sea level to 1,700 metres (5,600 ft). It is a major constituent of the Grand Fir/Douglas Fir Ecoregion of the Cascade Range. The tree typically grows to 40–70 m (130–230 ft) in height, and may be the tallest Abies species in the world. There are two varieties, the taller coast grand fir, found west of the Cascade Mountains, and the shorter interior grand fir, found east of the Cascades.", Habitat = "The grand fir grows along the coast from southwest British Columbia to Northern California, with the inland variety growing in eastern areas of Washington and Oregon, and the Idaho Panhandle. It can be found growing at elevations of up to 1,700 m (5,600 ft)",
              Smell = "pine scent", Taste = "Edible conifer flavours range from citrusy lemon and bitter grapefruit to herbaceous rosemary and woodsy pine", Edible = true,
              EdibleDesc = "Grand fir needles were traditionally used by West Coast First Nations as a flavour agent for food and as a medicinal herb.", Symbolism = "Fir trees symbolize determination, honesty, and the endurance that comes with hope for the future.", History = "It was first described in 1831 by David Douglas. It is closely related to white fir. The bark was historically believed to have medicinal properties, and it is popular in the United States as a Christmas tree. Its lumber is a softwood, and it is harvested as a hem fir.",
              Score = 65, Hint = "All firs are easily recognized by the smooth bark on young twigs and small, round leaf scars left by dropped needles. Grand Fir is most easily recognized by its long needles borne horizontally on opposite sides of the twigs.  The entire branch will appear flattened so that it has distinct upper and lower sides.", Difficulty = "hard",
              Found = false, Picture = "https://drive.google.com/file/d/1eWZ5ob6-TdCN8Y8mVG3iTL9GfeNSqdEH/preview"},                
              new Item { ItemId = 33, Category = "Coastal", Type = "Tree",
              Name = "Douglas Fir", Latin = "Pseudotsuga menziesii", Description = "Douglas-firs are medium-size to extremely large evergreen trees. The leaves are flat, soft, linear needles, generally resembling those of the firs, occurring singly rather than in fascicles; they completely encircle the branches, which can be useful in recognizing the species.", Habitat = "Grows in wet, coastal and inland areas",
              Smell = "Strong, sweet, clean, piney-fresh scent with citrusy notes", Taste = "Meyer lemon peel or tangerine peel. Another might taste like peach skin, and then another may be a sharp resiny green flavor", Edible = true,
              EdibleDesc = "Douglas fir spring tips are edible and are high in Vitamin C and electrolytes. You can eat them fresh, freeze them, or dry them. Both hot tea and sun tea are tasty.", Symbolism = "The symbolism of a fir tree carries the message of hope during challenges and encourages you to have patience while you wait for a better future.", History = "Native Americans used Douglas-fir wood for fuel, small utensils, and tools; they used its pitch for sealing joints and caulking canoes and water containers. They also used the tree and its parts for a variety of medicinal purposes.",
              Score = 25, Hint = "These tree's cones have 3-forked bracts sticking out from the scales. These look like the tails and hind feet of mice hiding in the cone", Difficulty = "Easy",
              Found = false, Picture = "https://drive.google.com/file/d/1w1ghq5g0uq91rFUVnH9C6Yq1UKNl0soy/preview"},
              new Item { ItemId = 29, Category = "Forest", Type = "Tree",
              Name = "Big Leaf Maple", Latin = "Acer macrophyllum", Description = "Bigleaf maple can grow up to 48 metres (158 feet) tall, but more commonly reaches 15-20 m (50-65 ft) tall. The bigleaf maple has the largest leaves of any maple,  ", Habitat = "",
              Smell = "Fragrant greenish-yellow flowers bloom in April-May", Taste = "Those gorgeous clusters are also delicious for us to eat, especially when they're young and tender.", Edible = true,
              EdibleDesc = "Big Leaf maple has the sweetest sap of all the native northwest maples, However because the sugar content is quite low, you'll need to gather a lot more to produce the same amount of sweet syrup as the sugar mapleThose gorgeous clusters are also delicious for us to eat, especially when they're young and tender.", Symbolism = "Maple is a symbol of strength and endurance", History = "Some of its leaves grow so big Native Americans used them as containers and plates. They also called the Big leaf maple the “paddle tree” because its wood makes excellent canoe paddles.",
              Score = 25, Hint = "It usually dangles unusually large, 5-lobed, palmate (palm-shaped) leaves from its branches.", Difficulty = "Easy",
              Found = false, Picture = "https://drive.google.com/file/d/1w1ghq5g0uq91rFUVnH9C6Yq1UKNl0soy/preview"},
              new Item { ItemId = 30, Category = "Coast", Type = "Tree",
              Name = "Mountain Hemlock", Latin = "Tsuga mertensiana", Description = "A subalpine tree with only a slightly drooping leader or top; rarely grows more than 30 metres tall and is often stunted at high elevations. Needles are uniform in size, glossy, and yellow-green to deep bluish-green. They cover the branches densely on all sides or may be mostly upturned.", Habitat = "Usually found on cold, snowy subalpine sites where it grows slowly, sometimes attaining more than 800 years in age.",
              Smell = "They retain an attractive scent for several years", Taste = "", Edible = true,
              EdibleDesc = "Inner bark - raw or dried, ground into a powder and then used as a thickening in soups etc or mixed with cereals when making bread. It is best used in the spring. An emergency food, it is only used when all else fails. A herbal tea is made from the young leaves and shoot tips.", Symbolism = "Their drooping boughs and fine, soft needles define them as elegant, wise elders that teach us to embrace change gracefully.", History = "Native Americans used the species less often than western hemlock, but specifically used mountain hemlock boughs as beds and bathing brushes",
              Score = 100, Hint = "far larger size with darker red and brown colors in contrast to the tiny tan cones of the Western Hemlock", Difficulty = "hard",
              Found = false, Picture = "https://drive.google.com/file/d/1w1ghq5g0uq91rFUVnH9C6Yq1UKNl0soy/preview"},

              new Item { ItemId = 31, Category = "Coast", Type = "Tree",
              Name = "Pacific Yew", Latin = "Taxus brevifolia", Description = "A small evergreen conifer (sometimes appearing as a shrub), the Pacific yew grows to 10-15 m (33-49 ft) tall, It has thin, scaly bark, red then purplish-brown,covering a thin layer of off-white sap wood with a darker heartwood that varies in color from brown to a purplish hue to deep red, or even bright orange when freshly cut.The leaves are lanceolate, flat, and dark green. ", Habitat = "Dry interior forests, the species develops best along mountain streams, and in shady canyons, ravines, and coves. Within the moist maritime climate of the Pacific Northwest, it grows most abundantly in drier, warmer environments.",
              Smell = "Odorless", Taste = "cherry jello-like taste", Edible = true,
              EdibleDesc = "While many parts of yews are poisonous and can be fatal if eaten, the juicy red cup around the seed seems to be edible as long as the seed within is not chewed or swallowed", Symbolism = "", History = "Traditionally, the resilient and rot-resistant wood was used by Native Americans to make tools, bows (backed with sinew), arrows, and canoe paddles.[4] Other purposes for yew included making harpoons, fishhooks, wedges, clubs, spoons, drums, snowshoes, and arrowheads.[4] The foliage and bark was used for medicinal purposes.",
              Score = 10, Hint = "It grows in varying types of environments; however, in drier environments it is mostly limited to stream-side habitats, whereas in moist environments it will grow up onto slopes and ridgetops", Difficulty = "easy",
              Found = false, Picture = "https://drive.google.com/file/d/1org_4v5kJo6_cJcBZHQsDitcMCedZuTL/preview"}
              );
    }

  }
}