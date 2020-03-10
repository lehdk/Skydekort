using System;
using System.Collections.Generic;
using System.Text;

namespace SkydekortLibrary
{
    public class Skydekort
    {
        public string titel { get; set; }
        public DateTime date { get; set; }
        public string Description { get; set; }
        public uint ownerUID { get; set; }

        public bool isInit = false;
        /*
         * mis1  = 0
         * mis2  = 1
         * træf1 = 2
         * træf2 = 3
         * 
         * Not Set = 9
         */
        public List<int> duer { get; set; }

        public int[] targetAmounts;

        /// <summary>
        /// laver en normal 24 serie
        /// </summary>
        
        public Skydekort()
        {
        }
        
        /// <summary>
        /// Opretter en serie med den mængde duer man øsker på hver post
        /// </summary>
        /// <param name="bDuer">Mængden af bagduer</param>
        /// <param name="vDuer">Mængden af venstreduer</param>
        /// <param name="sDuer">Mængden af spidsduer</param>
        /// <param name="hDuer">Mængden af højreduer</param>
        public Skydekort(int bDuer, int vDuer, int sDuer, int hDuer)
        {
            duer = new List<int>();
            targetAmounts = new int[4];

            targetAmounts[0] = bDuer;
            targetAmounts[1] = vDuer;
            targetAmounts[2] = sDuer;
            targetAmounts[3] = hDuer;

            if (!isInit)
                fillSkydekortWithValue(9);

            isInit = true;
        }

        public void fillSkydekortWithValue(int value)
        {
            for(int i = 0; i < (targetAmounts[0] + targetAmounts[1] + targetAmounts[2] + targetAmounts[3]); i++)
            {
                duer.Add(value);
            }
        }

        public string Display
        {
            get
            {
                return string.Format("{0} - {1}", date.ToString("dd/MM/yyyy"), titel);
            }
        }

        public int[] getBDuer()
        {
           return duer.GetRange(0, targetAmounts[0]).ToArray();
        }

        public int[] getVDuer()
        {
            return duer.GetRange(targetAmounts[0], targetAmounts[1]).ToArray();
        }

        public int[] getSDuer()
        {
            return duer.GetRange(targetAmounts[1], targetAmounts[2]).ToArray();
        }

        public int[] getHDuer()
        {
            return duer.GetRange(targetAmounts[2], targetAmounts[3]).ToArray();
        }

    }
}
