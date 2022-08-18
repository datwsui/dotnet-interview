using CodingExercise;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingTests
{
    [TestFixture]
    public class MovieTitlesTests
    {
        [Test]
        [TestCase("spiderman")]
        [TestCase("waterworld")]
        [TestCase("aquaman")]
        [TestCase("rummy")]
        [TestCase("wonderwoman")]
        [TestCase("ironman")]
        [TestCase("antman")]
        [TestCase("nightout")]
        [TestCase("and")]
        [TestCase("harry potter")]
        public void GetTitlesTest(string author)
        {
            List<string> actual = MovieTitles.GetTitles(author);

            Assert.AreEqual(_testResults[author], actual);
        }

        Dictionary<string, List<string>> _testResults = new Dictionary<string, List<string>>()
        {
            {
                "spiderman",
                new List<string>()
                {
                    "Fighting, Flying and Driving: The Stunts of Spiderman 3",
                    "Italian Spiderman",
                    "Spiderman",
                    "Spiderman 5",
                    "Spiderman in Cannes",
                    "Superman, Spiderman or Batman"
                }
            },
            {
                "waterworld",
                new List<string>()
                {
                    "The Making of 'Waterworld'",
                    "Waterworld",
                    "Waterworld",
                    "Waterworld",
                    "Waterworld 4: History of the Islands"
                }
            },
            {
                "aquaman",
                new List<string>()
                {
                    "Aquaman",
                    "Aquaman",
                    "Aquaman",
                    "Aquaman",
                    "Aquaman",
                    "Aquaman Fan Film",
                    "Aquaman: The Teen Drama",
                    "The Superman/Aquaman Hour of Adventure"
                }
            },
            {
                "rummy",
                new List<string>()
                {
                    "Rummy"
                }
            },
            {
                "wonderwoman",
                new List<string>()
            },
            {
                "ironman",
                new List<string>()
                {
                    "Road to Ironman"
                }
            },
            {
                "antman",
                new List<string>()
                {
                    "The Antman"
                }
            },
            {
                "nightout",
                new List<string>()
            },
            {
                "and",
                new List<string>()
                {
                    "A Man and His Sin",
                    "A Walk Into the Sea: Danny Williams and the Warhol Factory",
                    "A Walk Through the Holy Land",
                    "A Walk to Remember: A Day on the Set with Mandy Moore",
                    "A Walk with Love and Death",
                    "A Writer and Three Script Editors Walk Into a Bar",
                    "Actor's and Sin",
                    "Aimless Walk - Alexander Hammid",
                    "An Exclusive Inside Look at 'Harry Potter and the Order of the Phoenix'",
                    "Candamo, la ultima selva sin hombres",
                    "Comedy Central presenta: Stand Up Sin Fronteras",
                    "Crazy Stupid Love: Steve and Ryan Walk Into a Bar",
                    "Creating the World of Harry Potter, Part 4: Sound and Music",
                    "Days of Sin and Nights of Nymphomania",
                    "Dumb and Dumberer: When Harry Met Lloyd",
                    "Fighting, Flying and Driving: The Stunts of Spiderman 3",
                    "Handsome Harry",
                    "Harry Anderson's Hello Sucker",
                    "Harry Anderson: The Tricks of His Trade",
                    "Harry Black and the Tiger",
                    "Harry Connick Jr.: The New York Big Band Concert",
                    "Harry Enfield Presents Wayne and Waynetta's Guide to Wedded Bliss",
                    "Harry Enfield and Chums",
                    "Harry Green and Eugene",
                    "Harry Knuckles and the Pearl Necklace",
                    "Harry Knuckles and the Treasure of the Aztec Mummy",
                    "Harry Owens and His Royal Hawaiians",
                    "Harry Potter and the Chamber of Secrets",
                    "Harry Potter and the Chamber of Secrets",
                    "Harry Potter and the Deathly Hallows T4 Premiere Special",
                    "Harry Potter and the Deathly Hallows: Part 1",
                    "Harry Potter and the Deathly Hallows: Part 2",
                    "Harry Potter and the Deathly Hallows: Part I",
                    "Harry Potter and the Deathly Hallows: Part II",
                    "Harry Potter and the Escape from Gringotts",
                    "Harry Potter and the Forbidden Journey",
                    "Harry Potter and the Goblet of Fire",
                    "Harry Potter and the Goblet of Fire",
                    "Harry Potter and the Half-Blood Prince",
                    "Harry Potter and the Half-Blood Prince",
                    "Harry Potter and the Music Video Parody (About Hermione!)",
                    "Harry Potter and the Order of the Phoenix",
                    "Harry Potter and the Order of the Phoenix",
                    "Harry Potter and the Order of the Phoenix: T4 Movie Special",
                    "Harry Potter and the Prisoner of Azkaban",
                    "Harry Potter and the Prisoner of Azkaban",
                    "Harry Potter and the Sorcerer's Stone",
                    "Harry Potter and the Sorcerer's Stone",
                    "Harry Potter and the Ten Years Later",
                    "Harry Putter and the Chamber Pot of Secrets",
                    "Harry and Cosh",
                    "Harry and Harriet",
                    "Harry and His Bucket Full of Dinosaurs",
                    "Harry and His Geisha Girls",
                    "Harry and Maggie",
                    "Harry and Ringo's Night Out Promo Reel",
                    "Harry and Tonto",
                    "Harry and Walter Go to New York",
                    "Harry and the Butler",
                    "Harry and the Hendersons",
                    "Harry and the Hendersons",
                    "Harry and the Wrinklies",
                    "Harry, Henry and the Prostitute",
                    "Here's to Harry's Grandfather",
                    "I Close My Eyes and Walk Away",
                    "Inside 'Harry Potter and the Goblet of Fire'",
                    "It's Hot on Sin Island",
                    "James Potter and the Hall of Elders Crossing",
                    "Julia Bradbury's Iceland Walk",
                    "Lego Creator: Harry Potter and the Chamber of Secrets",
                    "Love Under Fire: The Story of Bertha and Potter Palmer",
                    "Man, Woman and Sin",
                    "Mandela: Long Walk to Freedom",
                    "Olsen-banden og Dynamitt-Harry",
                    "Olsen-banden og Dynamitt-Harry går amok",
                    "Olsenbanden og Data-Harry sprenger verdensbanken",
                    "Olsenbanden og Dynamitt-Harry mot nye høyder",
                    "Olsenbanden og Dynamitt-Harry på sporet",
                    "Random Walk",
                    "Rise and Walk: The Dennis Byrd Story",
                    "Ruddy Hell! It's Harry and Paul",
                    "Scandal: Sin in the City",
                    "Sex and Lies in Sin City",
                    "Sin and Desire",
                    "Sin, Suffer and Repent",
                    "The Adventures of Spin and Marty: Back in the Saddle with Harry Carey Jr.",
                    "The Complete Walk: Romeo and Juliet",
                    "The Law and Harry McGraw",
                    "The Legend of Harry and Ambrose",
                    "The Sin of Adam and Eve",
                    "Thou Shalt Not: Sex, Sin and Censorship in Pre-Code Hollywood",
                    "Tom Dick and Harry",
                    "Tom Dick and Harry Returns",
                    "Tom, Dick, and Harry",
                    "Unwigged & Unplugged Live Concert DVD: An Evening with Christopher Guest, Michael McKean and Harry Shearer",
                    "Walk Away and I Stumble",
                    "Walk and Talk the Vote: West Wing Reunion - Bridget Mary McCormack",
                    "Walk the Proud Land",
                    "Waterworld 4: History of the Islands",
                    "When Harry Met Sally 2 with Billy Crystal and Helen Mirren",
                    "Who Is Harry Kellerman and Why Is He Saying Those Terrible Things About Me?",
                    "Who Is Harry Nilsson (And Why Is Everybody Talkin' About Him?)"
                }
            },
            {
                "harry potter",
                new List<string>()
                {
                    "'Harry Potter': Behind the Magic",
                    "50 Greatest Harry Potter Moments",
                    "An Exclusive Inside Look at 'Harry Potter and the Order of the Phoenix'",
                    "Big Movie Premiere: Harry Potter & the Deathly Hallows Pt. 1",
                    "Creating the World of Harry Potter, Part 1: The Magic Begins",
                    "Creating the World of Harry Potter, Part 2: Characters",
                    "Creating the World of Harry Potter, Part 3: Creatures",
                    "Creating the World of Harry Potter, Part 4: Sound and Music",
                    "Creating the World of Harry Potter, Part 5: Evolution",
                    "Creating the World of Harry Potter, Part 6: Magical Effects",
                    "Creating the World of Harry Potter, Part 7: Story",
                    "Creating the World of Harry Potter, Part 8: Growing Up",
                    "Daniel Radcliffe: Being Harry Potter",
                    "Discovering the Real World of Harry Potter",
                    "Harry Potter Parent Teacher Conference",
                    "Harry Potter and the Chamber of Secrets",
                    "Harry Potter and the Chamber of Secrets",
                    "Harry Potter and the Deathly Hallows T4 Premiere Special",
                    "Harry Potter and the Deathly Hallows: Part 1",
                    "Harry Potter and the Deathly Hallows: Part 2",
                    "Harry Potter and the Deathly Hallows: Part I",
                    "Harry Potter and the Deathly Hallows: Part II",
                    "Harry Potter and the Escape from Gringotts",
                    "Harry Potter and the Forbidden Journey",
                    "Harry Potter and the Goblet of Fire",
                    "Harry Potter and the Goblet of Fire",
                    "Harry Potter and the Half-Blood Prince",
                    "Harry Potter and the Half-Blood Prince",
                    "Harry Potter and the Music Video Parody (About Hermione!)",
                    "Harry Potter and the Order of the Phoenix",
                    "Harry Potter and the Order of the Phoenix",
                    "Harry Potter and the Order of the Phoenix: T4 Movie Special",
                    "Harry Potter and the Prisoner of Azkaban",
                    "Harry Potter and the Prisoner of Azkaban",
                    "Harry Potter and the Sorcerer's Stone",
                    "Harry Potter and the Sorcerer's Stone",
                    "Harry Potter and the Ten Years Later",
                    "Harry Potter at the Castle: Magic at Midnight",
                    "Harry Potter for Kinect",
                    "Harry Potter v. Voldemort",
                    "Harry Potter és a bölcsek köve",
                    "Harry Potter: Hogwarts Challenge",
                    "Harry Potter: Quidditch World Cup",
                    "Harry Potter: The Making of Diagon Alley",
                    "Harry Potter: Wizarding World",
                    "I Am Harry Potter",
                    "Inside 'Harry Potter and the Goblet of Fire'",
                    "Lego Creator: Harry Potter",
                    "Lego Creator: Harry Potter and the Chamber of Secrets",
                    "Lego Harry Potter: Years 1-4",
                    "Lego Harry Potter: Years 5-7",
                    "Life After Hogwarts: Episode 1 - Harry Potter Goes to Therapy",
                    "R-Rated Harry Potter",
                    "The Hidden Secrets of Harry Potter",
                    "The Magical World of Harry Potter: The Unauthorized Story of J.K. Rowling"
                }
            }
        };
    }
}
