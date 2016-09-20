using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTennis.Model.Common;
using YouTennis.Model.Enums;

namespace YouTennis.Model.Tennis
{
    public class TennisPlayerProfile:PlayerProfile
    {
        public class Strokes
        {
            public Judgement Backhand { get; set; }
            public Judgement Forehand { get; set; }
            public Judgement Volley { get; set; }
            public Judgement FlatFirstService { get; set; }
            public Judgement SliceFirstService { get; set; }
            public Judgement SecondService { get; set; }
            public Judgement ServeAndVolley { get; set; }
            public Judgement Return { get; set; }
            public Judgement Dropshot { get; set; }
            public Judgement ForehandTopspin { get; set; }
            public Judgement BackhandTopspin { get; set; }
            public Judgement ForehandBackspin { get; set; }
            public Judgement BackhandBackspin { get; set; }
            public Judgement Smasch { get; set; }
            public Judgement Lob { get; set; }
            public Judgement Passingshot { get; set; }
            public Judgement LongRallySuccess { get; set; }
            public Judgement PlayingStrategies { get; set; }
            public Judgement Regularity { get; set; }

            public int CalculateOverAllIndex()
            {
                double sum = (int)Backhand * 1.1 + (int)Forehand * 1 + (int)Volley * 1.2 + (int)FlatFirstService * 1.2 + (int)SliceFirstService * 1.3 +
                            (int)SecondService * 1.5 + (int)ServeAndVolley * 0.8 + (int)Return * 1.2 + (int)Dropshot * 0.5 + (int)ForehandTopspin * 1.3 +
                            (int)BackhandTopspin * 1.5 + (int)ForehandBackspin * 0.8 + (int)BackhandBackspin * 1.2 + (int)Smasch * 0.7 + (int)Lob * 0.7 +
                            (int)Passingshot * 0.5 + (int)LongRallySuccess * 1.8 + (int)PlayingStrategies * 1.2 + (int)Regularity * 1.8;
                double pounds = 1.1 + 1 + 1.2 + 1.2 + 1.3 +
                              1.5 + 0.8 + 1.2 + 0.5 + 1.3 +
                              1.5 + 0.8 + 1.2 + 0.7 + 0.7 +
                              0.5 + 1.8 + 1.2 + 1.8;

                return (int)Math.Round(sum *10/ pounds);
            }
        

        }

        public string Racket { get; set; }

        public HandType Hand { get; set; }
        public HandMode Forehand { get; set; }
        public HandMode Backhand { get; set; }

        public ITNCategory Category { get; set; }

        public Strokes SelfJudgment { get; set; }
    }
}
