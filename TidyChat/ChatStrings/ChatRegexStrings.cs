﻿using System.Text.RegularExpressions;

namespace TidyChat
{
    public class ChatRegexStrings
    {
        public static Regex BetterPlayerCommendation { get; } = new Regex(@"You received \d{1} (commendation|commendations)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedGil { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} gil\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedMGP { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} MGP\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedVenture { get; } = new Regex(@"You (obtain|obtains) (a venture|2 ventures)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedAlliedSeals { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} Allied Seals\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedCenturioSeals { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} Centurio Seals\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedNuts { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} sacks of Nuts\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedSeals { get; } = new Regex(@"You (obtain|obtains) (\d{1,3},)?\d{1,3} (Flame|Storm|Serpent) Seals\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedClusters { get; } = new Regex(@"You (obtain|obtains) (a|2) (.*)cluster\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedMaterials { get; } = new Regex(@"You (obtain|obtains) (.*) materials\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedShards { get; } = new Regex(@"You (obtain|obtains) \d{1,3} .{1,3}(fire|ice|wind|earth|lightning|water) (shards|crystals|clusters)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedTribalCurrency { get; } = new Regex(@"You (obtain|obtains) (a|an|2) (Steel Amalj'ok|Steel Amalj'oks|Sylphic Goldleaf|Sylphic Goldleaves|Titan Cobaltpiece|Titan Cobaltpieces|Rainbowtide Psashp|Rainbowtide Psashps|Ixali oaknot|Ixali oaknots|Vanu Whitebone|Vanu Whitebones|Black Copper Gil|Black Copper Gils|Carved Kupo Nut|Carved Kupo Nuts|Kojin Sango|Kojin Sangos|Ananta Dreamstaves|Ananta Dreamstaffs|Namazu Koban|Namazu Kobans|Fae Fancies|Fae Fancy|Qitari Compliment|Qitari Compliments|Hammered Frogment|Hammered Frogments)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex PlayerTargetedEmote { get; } = new Regex(@"you|your",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex PlayerUsedEmote { get; } = new Regex(@"^(You|Your)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex CastLot { get; } = new Regex(@"You (cast|casts) (your|his|her) lot for (.*)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex RollsNeedOrGreed { get; } = new Regex(@"You (roll|rolls) (Need|Greed) on (.*)\. \d{1,2}\!",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex OthersCastLot { get; } = new Regex(@".* casts (his|her) lot for (.*)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex OthersRollNeedOrGreed { get; } = new Regex(@".* rolls (Need|Greed) on (.*)\. \d{1,2}\!",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex OthersObtain { get; } = new Regex(@".* obtains .+",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ItemSearchCommand { get; } = new Regex(@"(\s{1,3}>>|(No|\d{1,4}) (match|matches) found containing)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex SearchForItemResults { get; } = new Regex(@"(\d (item|items) found in glamour dresser\.)|(\d (item|items) found in the .* section of the armoire\.)|(Currently equipped to .* slot)|(Total: \d{1,9} (item|items) found)|(\d{1,9} (item|items) found in the (1st|2nd|3rd|4th) tab of (your|.+'s) inventory)|\d{1,9} (item|items) found in saddlebag",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex ObtainedTomestones { get; } = new Regex(@"You (obtain|obtains) \d{1,3} Allagan tomestones of",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex GearsetEquipped { get; } = new Regex(@"“(.*)” equipped\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        // Future proofing the materias a bit
        public static Regex MateriaRetrieved { get; } = new Regex(@"You (receive|receives) (a|an|2) .+ materia (I|II|III|IV|V|VI|VII|VIII|IX|X|XI|XII|XIII|XIV|XV|XVI|XVII|XVII|XIV|XV|XVI|XVII|XVII|XVIII|XIX)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex MateriaShatters { get; } = new Regex(@"The .+ materia (I|II|III|IV|V|VI|VII|VIII|IX|X|XI|XII|XIII|XIV|XV|XVI|XVII|XVII|XIV|XV|XVI|XVII|XVII|XVIII|XIX) shatters",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex AttachedMateria { get; } = new Regex(@"You successfully attach (a|an) .+ materia (I|II|III|IV|V|VI|VII|VIII|IX|X|XI|XII|XIII|XIV|XV|XVI|XVII|XVII|XIV|XV|XVI|XVII|XVII|XVIII|XIX) to the",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex VolumeControls { get; } = new Regex(@"volume (muted|unmuted|set to \d{1,3}\.)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex GatheringStartEnd { get; } = new Regex(@"You (begin|finish) (mining|quarrying|logging|harvesting)\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex AetherialReductionSands { get; } = new Regex(@".+handfuls of .+ .+sand are obtained\.",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public static Regex SealedOff { get; } = new Regex(@"(will be sealed off in 15 seconds|is sealed off|is no longer sealed)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
          // Name S. gains \d{1,4} (+\d{1,2}%) experience points.
        public static Regex GainExperiencePoints { get; } = new Regex(@"(.* gains .* experience points\.)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
        // <Player Name> has logged out.
        public static Regex HasLoggedOut { get; } = new Regex(@"(.* has logged out\.)",
          RegexOptions.Compiled | RegexOptions.IgnoreCase);
    }
}
