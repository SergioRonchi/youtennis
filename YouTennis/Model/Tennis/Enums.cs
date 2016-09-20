using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTennis.Model.Tennis
{
    public enum CourtType
    {
        Clay,
        Hard,
        Grass,
        Carpet,
        
    }

    public enum HandType
    {
        RightHanded,
        LeftHanded,

    }

    public enum HandMode
    {
        SingleHanded,
        TwoHanded,

    }

    public enum Judgement
    {
        NotAble = 3,
        Bad = 4,
        NotConfortable = 5,
        Sometime = 6,
        Confortable = 7,
        Good = 8,
        VeryGood = 9,
        StrogerCard = 10,

    }

    /// <summary>
    /// Tennis Rating Program
    /// </summary>
    public enum TRPLevel
    {
        /// <summary>
        /// This player is Just starting to play tennis.
        /// </summary>
        TRP_10,
        /// <summary>
        /// Has limited experience and is still working primarily on getting the ball into play.
        /// </summary>
        TRP_15,
        /// <summary>
        /// This player needs on-court experience. This player has obvious stroke weaknesses but is familiar with basic positions for singles and doubles play.
        /// </summary>
        TRP_20,
        /// <summary>
        /// This player is learning to judge where the ball is going although court coverage is weak. This player can sustain a slow rally with other players of same ability.
        /// </summary>
        TRP_25,
        /// <summary>
        /// This player is consistent when hitting medium pace shots, but is not comfortable with all strokes and lacks control when trying for directional intent, depth, or power.
        /// </summary>
        TRP_30,
        /// <summary>
        /// This player has achieved improved stroke dependability and direction on moderate pace shots, but still lacks depth and variety. This player exhibits more aggressive net play, 
        /// has improved court coverage and is developing teamwork in doubles.
        /// </summary>
        TRP_35,
        /// <summary>
        /// This player has dependable strokes, including directional intent, on both forehand and backhand sides on moderate shots, plus the ability to use lobs, 
        /// overheads, approach shots and volleys with some success. This player occasionally forces errors when serving and teamwork in doubles is evident.
        /// </summary>
        TRP_40,
        /// <summary>
        /// This player has begun to master the use of power and spins and is beginning to handle pace, has sound footwork, can control depth of shots,
        /// and is beginning to vary tactics according to opponents. 
        /// This player can hit first serves with power and accuracy and place the second serve and is able to rush the net successfully.
        /// </summary>
        TRP_45,
        /// <summary>
        /// This player has good shot anticipation and frequently has an outstanding shot or attribute around which a game may be structured. 
        /// This player can regularly hit winners or force errors off of short balls, can put away volleys, can successfully execute lobs, drop shots, half volleys and overhead smashes, 
        /// and has good depth and spin on most second serves.
        /// </summary>
        TRP_50,
        /// <summary>
        /// This player has developed power and/or consistency as a major weapon. 
        /// This player can vary strategies and styles of play in a competitive situation and hits dependable shots in a stress situation.
        /// </summary>
        TRP_55,
        /// <summary>
        /// These players will generally not need NRTP rankings. Rankings or past rankings will speak for themselves. 
        /// The 6.0 player typically has had intensive training for national tournament competition at the junior level and collegiate levels and has obtained a sectional or national ranking.
        /// </summary>
        TRP_60,
        /// <summary>
        ///The 6.5 player has a reasonable chance of succeeding at the 7.0 level and has extensive satellite tournament experience. 
        /// </summary>
        TRP_65,
        /// <summary>
        /// The 7.0 is a world class player who is committed to tournament competition on the international level and whose major source of income is tournament prize winnings
        /// </summary>
        TRP_70,

    }

    public enum ITNCategory
    {
        /// <summary>
        /// This player has had intensive training for national tournament competition at the junior and senior levels and has extensive professional tournament experience. 
        /// Currently holds or is capable of holding an ATP / WTA ranking and their major source of income is through tournament prize money.
        /// </summary>
        INT1,
        /// <summary>
        /// This player has power and / or consistency as a major weapon. Can vary strategies and styles of play in a competitive situation. The player is usually a nationally-ranked player.
        /// </summary>
        INT2,
        /// <summary>
        /// This player has good shot anticipation and frequently has an outstanding shot or attribute around which a game may be structured. 
        /// Can regularly hit winners and force errors off short balls. Can put away volleys and smashes and has a variety of serves to rely on.
        /// </summary>
        INT3,
        /// <summary>
        /// This player can use power and spins and has begun to handle pace. Has sound footwork, can control depth of shots, and can vary game plan according to opponents. 
        /// Can hit first serves with power and can utilise spin on second serves.
        /// </summary>
        INT4,
        /// <summary>
        /// This player has dependable strokes, including directional control and depth on both groundstrokes and on moderate shots.
        /// The player has the ability to use lobs, overheads, approach shots and volleys with some success.
        /// </summary>
        INT5,
        /// <summary>
        /// This player exhibits more aggressive net play, has improved court coverage, improved shot control and is developing teamwork in doubles.
        /// </summary>
        INT6,
        /// <summary>
        /// This player is fairly consistent when hitting medium paced shots, but is not yet comfortable with all strokes. The player lacks control over depth, direction and power.
        /// </summary>
        INT7,
        /// <summary>
        /// This player is able to judge / control where the ball is going and can sustain a short rally.
        /// </summary>
        INT8,
        /// <summary>
        /// This player needs on court experience, while strokes can be completed with some success.
        /// </summary>
        INT9,
        /// <summary>
        /// This player is starting to play competitively (can serve rally and score) on a full court using a regular ITF approved Yellow ball.
        /// </summary>
        INT10,

    }



}
