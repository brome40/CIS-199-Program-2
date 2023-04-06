//Grading ID: R7828
//CIS 199-01
//Program 2
//Due 10/15/2020
//This program outputs the costs of three different shipping companies when given the package weight, distance, and travel time. It also outputs which company offers the best price. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double weight;       //the weight of the package
        double miles;        //the distance the package travels
        int days;            //the travel time of the package
        double companyaCost; //total cost using company A after calculation
        double companybCost; //total cost using company B after calculation
        double companycCost; //total cost using company C after calculation
        char lowestCompany;  //the company that offers the cheapest price

        const double APERPOUND = 1;       //1 dollar for each pound using company A
        const double APERMILE = .02;      // 2 cents for each mile traveled using company A
        const double AONEDAYD = 20;       //20 dollars for 1 day travel time using company A
        const double ATWODAYD = 17;       // 17 dollars for 2 day travel time using company A
        const double ATHREEDAYD = 15;     //15 dollars for 3 day travel time using company A
        const double AFOURSEVENDAYD = 10; //10 dollars for 4-7 day travel time using company A
        const double ASEVENPLUSDAYD = 7;  //7 dollars for greater than 7 day travel time using company A

        const double BSUBTENWT = 3;     //3 dollar fee for weight under 10 pounds using company B
        const double BSUB50WT = 5;      //5 dollar fee for weight 10-50 pounds using company B
        const double BSUB100WT = 10;    //10 dollar fee for weight 50-100 pounds using company B
        const double BSUB200WT = 20;    //20 dollar fee for weight 100-200 pounds using company B
        const double BPERPOUND = .15;   //15 cents for each pound if weight is 200 or more using company B
        const double BPERMILE = .10;    //10 cents for each mile traveled using company B
        const double BONEFOURDAYD = 10; //10 dollars for 1-4 day travel time using company B
        const double BFOURPLUSDAYD = 7; //7 dollars for greater than 4 day travel time using company B

        const double CPERPOUND = .25;     //25 cents for each pound using company C
        const double CSUB200MILES = 10;   //10 dollar fee for less than 200 miles using company C
        const double CSUB500MILES = 15;   //15 dollar fee for 200-500 miles using company C
        const double CSUB750MILES = 25;   //25 dollar fee for 500-750 miles using company C
        const double CSUB1000MILES = 35;  //35 dollar fee for 750-1000 miles using company C
        const double COVER1000MILES = 40; //40 dollar fee for 1000 or more miles using company C
        const double CFLATFEE = 20;       //20 dollar delivery fee for any time traveled using company C 

        private void calulateBtn_Click(object sender, EventArgs e) //When the button is clicked or enter pressed, the input is used to calculate and output the results
        {
            if (double.TryParse(weightInputTxt.Text, out weight) && weight > 0) 
            {
                if (double.TryParse(distanceInputTxt.Text, out miles) && miles > 0)
                {
                    if (int.TryParse(deldaysInputTxt.Text, out days) && days > 0)
                    {
                        //Here the cost for company A is calculated and displayed

                        companyaCost = (APERPOUND * weight) + (APERMILE * miles);
                        if (days == 1)
                            companyaCost += AONEDAYD;
                        else if (days == 2)
                            companyaCost += ATWODAYD;
                        else if (days == 3)
                            companyaCost += ATHREEDAYD;
                        else if (days >= 4 && days <= 7)
                            companyaCost += AFOURSEVENDAYD;
                        else
                            companyaCost += ASEVENPLUSDAYD;
                        
                        companyaOutputLbl.Text = $"{companyaCost:C}";

                        //Here the cost for company B is calculated and displayed

                        companybCost = (BPERMILE * miles);
                        if (weight < 10)
                            companybCost += BSUBTENWT;
                        else if (weight < 50)
                            companybCost += BSUB50WT;
                        else if (weight < 100)
                            companybCost += BSUB100WT;
                        else if (weight < 200)
                            companybCost += BSUB200WT;
                        else
                            companybCost += (BPERPOUND * weight);

                        if (days <= 4)
                            companybCost += BONEFOURDAYD;
                        else
                            companybCost += BFOURPLUSDAYD;

                        companybOutputLbl.Text = $"{companybCost:C}";

                        //Here the cost for company C is calculated and displayed

                        companycCost = (CPERPOUND * weight) + CFLATFEE;
                        if (miles < 200)
                            companycCost += CSUB200MILES;
                        else if (miles < 500)
                            companycCost += CSUB500MILES;
                        else if (miles < 750)
                            companycCost += CSUB750MILES;
                        else if (miles < 1000)
                            companycCost += CSUB1000MILES;
                        else
                            companycCost += COVER1000MILES;

                        companycOutputLbl.Text = $"{companycCost:C}";

                        //Here the company with the best price is declared

                        if (companyaCost < companybCost && companyaCost < companycCost)
                            lowestCompany = 'A';
                        else if (companybCost < companyaCost && companybCost < companycCost)
                            lowestCompany = 'B';
                        else
                            lowestCompany = 'C';

                        lowestCostOutputLbl.Text = $"The lowest cost company is: {lowestCompany}";
                            
                    }
                    else
                    {
                        MessageBox.Show("Invalid Delivery Days");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Distance");
                }
            }
            else 
            {
                MessageBox.Show("Invalid Weight");
            }  
        }
    }
}
