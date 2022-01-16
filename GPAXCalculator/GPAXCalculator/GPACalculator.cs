using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAXCalculator
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private string maxname = ""; 
        private string minname = "";
        private string alldata = "";
        private double min = 0;

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa,string name)
        {
            this.sum += gpa;
            this.n++;
            this.alldata += name + "" + gpa + "\r\n";

            if (this.max < gpa)
            {
                this.max = gpa;
                this.maxname = name;
            }
            if (this.max > gpa)
            {
                this.min = gpa;
                this.minname = name;
            }
        }
        /// <summary>
        /// Return GPAX of class
        /// </summary>
        /// <returns>GPAX</returns>
        public double getGPAX() 
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.max;
        }
        public string getMaxName()
        {
            return maxname;
        }
        public string getAlldata()
        {
            return alldata;
        }
        public double getmin()
        {
            return this.min;
        }
        public string getMinName()
        {
            return minname;
        }

    }
}
