using System;
using System.IO;
using UnityEngine;

namespace YARG.Util {
	public static class Utils {
		/// <returns>
		/// A unique hash for <paramref name="a"/>.
		/// </returns>
		public static string Hash(string a) {
			return Hash128.Compute(a).ToString();
		}

		/// <returns>
		/// The converted short name (gh1) into the game name (Guitar Hero 1).
		/// </returns>
		public static string SourceToGameName(string source) {
#pragma warning disable format
			return source switch {
				"gh1" or "gh"         => "Guitar Hero",
				"gh2"                 => "Guitar Hero II",
				"gh2dlc"              => "Guitar Hero II DLC",
				"gh80s"               => "Guitar Hero Encore: Rocks the 80s",
				"gh3"                 => "Guitar Hero III: Legends of Rock",
				"ghot"                => "Guitar Hero: On Tour",
				"gha"                 => "Guitar Hero: Aerosmith",
				"ghwt"                => "Guitar Hero: World Tour",
				"ghm"                 => "Guitar Hero: Metallica",
				"ghwor"               => "Guitar Hero: Warriors of Rock",
				"ghvh"                => "Guitar Hero: Van Halen",
				"gh2dx"               => "Guitar Hero II Deluxe",
				"gh2dxdlc"            => "Guitar Hero Rocks the 360",
				"gh80sdx"             => "Guitar Hero Encore Deluxe",
				"gh3dlc"              => "Guitar Hero III DLC",
				"ghwtdlc"             => "Guitar Hero: World Tour DLC",
				"ghmdlc"              => "Death Magnetic DLC",
				"djhero"              => "DJ Hero",
				"ghsh"                => "Guitar Hero: Smash Hits",
				"ghwordlc"            => "Guitar Hero: Warriors of Rock DLC",
				"gh5"                 => "Guitar Hero 5",
				"gh5dlc"              => "Guitar Hero 5 DLC",
				"ghotd"               => "Guitar Hero On Tour: Decades",
				"ghotmh"              => "Guitar Hero On Tour: Modern Hits",
				"bandhero" or "bh"    => "Band Hero",
				"bhds"                => "Band Hero DS",
				"ghl"                 => "Guitar Hero Live",
				"ghtv"                => "Guitar Hero TV",

				"rb1"                 => "Rock Band 1",
				"rb2"                 => "Rock Band 2",
				"rb3"                 => "Rock Band 3",
				"rb4"                 => "Rock Band 4",
				"tbrb" or "beatles"   => "The Beatles Rock Band",
				"tbrbdlc"             => "The Beatles: Rock Band DLC",
				"tbrbcdlc"            => "The Beatles: Rock Band Custom DLC Project",
				"rbacdc"              => "AC/DC Live: Rock Band Track Pack",
				"gdrb"                => "Green Day Rock Band",
				"lrb"                 => "Lego Rock Band",
				"rbn"                 => "Rock Band Network",
				"ugc"                 => "Rock Band Network 1.0",
				"ugc_plus"            => "Rock Band Network 2.0",
				"ugc1"                => "Rock Band Network 1.0",
				"ugc2"                => "Rock Band Network 2.0",
				"ugc_lost"            => "Lost Rock Band Network",
				"rb1dlc"              => "Rock Band 1 DLC",
				"rb2dlc"              => "Rock Band 2 DLC",
				"rb3dlc"              => "Rock Band 3 DLC",
				"rb4dlc" or "rb4_dlc" => "Rock Band 4 DLC",
				"rb4_rivals"          => "Rock Band Rivals",
				"rbtp_acdc"           => "Rock Band Track Pack: AC/DC Live",
				"rbtp_classic_rock"   => "Rock Band Track Pack: Classic Rock",
				"rbtp_country_1"      => "Rock Band Track Pack: Country 1",
				"rbtp_country_2"      => "Rock Band Track Pack: Country 2",
				"rbtp_metal"          => "Rock Band Track Pack: Metal",
				"rbtp_vol_1"          => "Rock Band Track Pack: Volume 1",
				"rbtp_vol_2"          => "Rock Band Track Pack: Volume 2",
				"rb_blitz"            => "Rock Band Blitz",
				"pearljam"            => "Pearl Jam: Rock Band",
				"greenday" or "gdrb"  => "Green Day: Rock Band",
				"rbvr"                => "Rock Band VR",
		
		        "311hero"             => "311 Hero",
				"a2z"                 => "A-Z Pack",
				"ah1"                 => "Angevil Hero",
				"ah2"                 => "Angevil Hero 2",
				"ah3"                 => "Angevil Hero 3",
				"ah4"                 => "Angevil Hero 4",
				"antihero"            => "Anti Hero",
				"ahbe"                => "Anti Hero - Beach Episode",
				"antihero2"           => "Anti Hero 2",
				"a7xmegapack"         => "Avenged Sevenfold Mega Pack",
				"bitcrusher"          => "BITCRUSHER",
				"bitcrusherdlc"       => "BITCRUSHER DLC",
				"blackhole"           => "Black Hole",
				"bs"                  => "Blanket Statement",
				"bleepbloops"         => "Bleep Bloops",
				"bleepbloopuc"        => "Bleep Bloop Undercharts",
				"ugc_c3"              => "C3 Customs",
				"c3customs"           => "C3 Customs",
				"c3legacy"            => "C3 Legacy",
				"cth1"                => "Carpal Tunnel Hero",
				"cth1r"               => "Carpal Tunnel Hero 1: Remastered",
				"cth2"                => "Carpal Tunnel Hero 2",
				"cth3"                => "Carpal Tunnel Hero 3",
				"cth3dlc"             => "Carpal Tunnel Hero 3 DLC",
				"charts"              => "CHARTS",
				"charts2"             => "CHARTS 2",
				"chelhero"            => "Chel Hero",
				"cb"                  => "Circuit Breaker",
				"ch"                  => "Clone Hero",
				"codered"             => "Code Red",
				"comtpi"              => "Community Track Pack I",
				"comtpii"             => "Community Track Pack II",
				"comtpiii"            => "Community Track Pack III",
				"comtpiv"             => "Community Track Pack IV",
				"comtp45"             => "Community Track Pack 4.5",
				"comtpv"              => "Community Track Pack V",
				"cowhero"             => "Cow Hero",
				"cowherodlc1"         => "Cow Hero DLC 1 - Bull Conqueror",
				"cowherodlc2"         => "Cow Hero DLC 2 - Bovine Champion",
				"cowherodlc3"         => "Cow Hero DLC 3 - Cattle Guardian",
				"creativech"          => "Creative Commons Hero",
				"csc"                 => "Custom Songs Central",
				"customs"             => "Custom Songs",
				"digi"                => "Digitizer",
				"dissonancehero"      => "Dissonance Hero",
				"djenthero"           => "Djent Hero",
				"dhc"                 => "Djent Hero Collection",
				"djentherodlc"        => "Djent Hero DLC",
				"facelift"            => "Facelift",
				"tfoth"               => "The Fall of Troy Hero",
				"fp"                  => "Focal Point",
				"fp2"                 => "Focal Point 2",
				"fp3"                 => "Focal Point 3",
				"fof"                 => "Frets on Fire",
				"fuse"                => "Fuse Box",
				"gd"                  => "GITADORA",
				"gf1"                 => "GuitarFreaks",
				"gf2dm1"              => "GuitarFreaks 2ndMIX & DrumMania",
				"addygh"              => "Guitar Hero II: Addy's Disc",
				"ghxsetlist"          => "Guitar Hero X",
				"ghx2setlist"         => "Guitar Hero X-II",
				"praise"              => "Guitar Praise",
				"praisedlc"	          => "Guitar Praise: Expansion Pack 1",
				"stryper"	          => "Guitar Praise: Stryper",
				"guitarzero2"         => "Guitar Zero 2",
				"guitarherodlc"       => "Guitar Zero 2 DLC",
				"harmonyhero"         => "Harmony Hero",
				"imetal"              => "Instru-Metal",
				"kh"                  => "Koreaboo Hero",
				"kh2"                 => "Koreaboo Hero 2",
				"marathon"            => "Marathon Hero",
				"marathonhero2"       => "Marathon Hero 2",
				"ma"                  => "Max Altitude",
				"meme"                => "Meme Songs",
				"milohax"             => "MiloHax Customs",
				"miscellaneous"       => "Miscellaneous Packs",
				"paradigm"            => "Paradigm",
				"paramoremegapack"    => "Paramore Mega Pack",
				"phaseshift"          => "Phase Shift",
				"psgp4"               => "Phase Shift Guitar Project 4",
				"psh"                 => "Plastic Shred Hero: Legends of Apahetic Charting",
				"psh2"                => "Plastic Shred Hero 2",
				"pg"                  => "PowerGig: Rise of the SixString",
				"pgdlc"	              => "PowerGig: Rise of the SixString DLC",
				"ph1"                 => "Puppetz Hero I",
				"ph2"                 => "Puppetz Hero II",
				"ph3"                 => "Puppetz Hero III",
				"ph4"                 => "Puppetz Hero IV",
				"ragequit"            => "Rage Quit",
				"ra"                  => "Redemption Arc",
				"revolved"	      => "REVOLVED",
				"rr"                  => "Rock Revolution",
				"rrdlc"               => "Rock Revolution DLC",
				"scorespy"            => "ScoreSpy",
				"s_hero"              => "S Hero",
				"solomedley"          => "Solo Medleys",
				"finnish"             => "Suomibiisit",
				"se"                  => "Symphonic Effect",
				"sxdisc"              => "Symphony X Discography Setlist",
				"synergy"             => "Synergy",
				"vortex_hero"         => "Vortex Hero",
				"wcc"                 => "World Charts Community",
				"zancharted"          => "Zancharted",
				"zerogravity"         => "Zero Gravity",
				"zgsb"                => "Zero Gravity - Space Battle",

				_                     => "Unknown Source"
			};
#pragma warning restore format
		}

		/// <summary>
		/// Checks if the path <paramref name="a"/> is equal to the path <paramref name="b"/>.<br/>
		/// Platform specific case sensitivity is taken into account.
		/// </summary>
		public static bool PathsEqual(string a, string b) {
#if UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX
			
			// Linux is case sensitive
			return Path.GetFullPath(a).Equals(Path.GetFullPath(b), StringComparison.CurrentCulture);
			
#else

			// Windows and OSX are not case sensitive
			return Path.GetFullPath(a).Equals(Path.GetFullPath(b), StringComparison.CurrentCultureIgnoreCase);

#endif
		}

		/// <param name="transform">The <see cref="RectTransform"/> to convert to screen space.</param>
		/// <returns>
		/// A <see cref="Rect"/> represting the screen space of the specified <see cref="RectTransform"/>.
		/// </returns>
		public static Rect RectTransformToScreenSpace(RectTransform transform) {
			// https://answers.unity.com/questions/1013011/convert-recttransform-rect-to-screen-space.html
			Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale.Abs());
			return new Rect((Vector2) transform.position - (size * transform.pivot), size);
		}

		/// <param name="transform">The <see cref="RectTransform"/> to convert to viewport space.</param>
		/// <returns>
		/// A <see cref="Rect"/> represting the viewport space of the specified <see cref="RectTransform"/>.
		/// </returns>
		public static Rect RectTransformToViewportSpace(RectTransform transform) {
			Rect rect = RectTransformToScreenSpace(transform);
			rect.width /= Screen.width;
			rect.height /= Screen.height;
			rect.x /= Screen.width;
			rect.y /= Screen.height;

			return rect;
		}

		/// <returns>
		/// The inputed note split into a note + octave.
		/// </returns>
		public static (float note, int octave) SplitNoteToOctaveAndNote(float note) {
			float outNote = note;
			int octave = 0;

			while (outNote > 12f) {
				octave++;
				outNote -= 12f;
			}

			return (outNote, octave);
		}

		/// <param name="v">The linear volume between 0 and 1.</param>
		/// <returns>
		/// The linear volume converted to decibels.
		/// </returns>
		public static float VolumeFromLinear(float v) {
			return Mathf.Log10(Mathf.Min(v + float.Epsilon, 1f)) * 20f;
		}
	}
}
