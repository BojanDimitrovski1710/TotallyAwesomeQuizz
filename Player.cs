using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace test_forms_aoo
{
    public class Player
    {
        string Name;
        private int introversion;
        private int extroversion;
        private int empathy;
        private int responsibility;
        private int bravery;
        private string favSeason;
        private string favMovie;

        public Player()
        {
            this.introversion = 0;
            this.empathy = 0;
            this.extroversion = 0;
            this.responsibility = 0;
            this.bravery = 0;
            this.Name = "temp";
            this.favSeason = "";
            this.favMovie = "";
        }


        public string giveResults()
        {
            string results = "";
            results = "Hello, your name is " + this.Name + ", your favourite season is " + this.favSeason + " and your favourite movie is " + this.favMovie + ".\n You ";

            if (this.bravery > 0)
                results += "are brave,";
            else
                results += "are not very brave,";

            if(this.introversion>0 && this.extroversion > 0)
            {
                results += " both introverted and extroverted depending on the sittuation,";
            }
            else
            {
                if (this.introversion > 0)
                {
                    results += " slightly introverted,";
                }
                
                if(this.extroversion > 0)
                {
                    results += " slightly extroverted,";
                }
            }
            
            if(this.empathy > 0)
            {
                results += " tend to emphatise with people easly,";
            }
            else
            {
                results += " don't emphatise with people easly,";
            }

            if(this.responsibility > 0)
            {
                results += " and are pretty responsible!";
            }
            else
            {
                results += " but you could work on your responsibility a bit.";
            }

            return results;

        }

        public void setFavMovie(string movie)
        {
            this.favMovie = movie;
        }

        public void setFavSeason(string season)
        {
            this.favSeason = season;
        }

        public void incrementBravery(int value)
        {
            this.bravery += value;
        }

        public void incrementIntroversion(int value)
        {
            this.introversion += value;
        }

        public void incrementExtroversion(int value)
        {
            this.extroversion += value;
        }

        public void incrementEmpathy(int value)
        {
            this.empathy += value;
        }

        public void incrementResponsibility(int value)
        {
            this.responsibility += value;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
