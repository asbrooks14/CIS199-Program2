// Grading ID: S7105
// Program #2
// Due date: 3/11/2021
// CIS 199-02
// This program finds the cost
// of food delivery services for
// 3 companies and suggests the
// option with the lowest cost.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Program2 : Form
    {
        public Program2()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
          
          const int compAPersonFee = 1,             // $1 per person fee for comp A
                    compAPrepDays1 = 20,            // $20 for 1 day delivery for comp A
                    compAPrepDays2 = 17,            // $17 for 2 day delivery for comp A
                    compAPrepDays3 = 15,            // $15 for 3 day delivery for comp A
                    compAPrepDays4To7 = 10,         // $10 for 4-7 day delivery for comp A
                    compAPrepDays7Plus = 7,         // $7 for 7+ day delivery for comp A


                    compBPersonFee1 = 20,           // $20 fee per person for under 10 people for comp B
                    compBPersonFee2 = 10,           // $10 fee per person for 10-50 people for comp B
                    compBPersonFee3 = 5,            // $5 fee per person for 50-100 people for comp B
                    compBPersonFee4 = 3,            // $3 fee per person for 100-200 people for comp B
                    compBPrepDays1To4 = 10,         // $10 for 1-4 delivery for comp B
                    compBPrepDays4Plus = 7;         // $7 for 4+ day delivery for comp B

            int peopleInput,                        // user input for number of people
                deliveryDaysInput,                  // user input for number of days
                compAPersonTotal,                   // total fee for number of people for comp A
                compADeliveryTotal;                 // total fee for delivery for comp A

            const double   compADistanceFee = 0.02,     // $0.02 per mile distance fee for comp A

                           compBPersonFee5 = 0.15,      // $0.15 fee per person for 200+ people for comp B
                           compBDistanceFee = 0.10,     // $0.10 per mile for comp B

                           compCPersonFee = 0.25,       // $0.25 fee per person for comp C
                           compCDistanceFee1 = 10,      // $10 fee for 0-200 miles for comp C
                           compCDistanceFee2 = 15,      // $15 fee for 200-500 miles for comp C
                           compCDistanceFee3 = 25,      // $25 fee for 500-750 miles for comp C
                           compCDistanceFee4 = 35,      // $35 fee for 750-1000 miles for comp C
                           compCDistanceFee5 = 40,      // $ 40 fee for 1000+ miles for comp C
                           compCDeliveryFee = 20;       // $20 fee for delivery for comp C

            double distanceInput,               // user input for distance

                   compADistanceTotal,          // total fee for distance for comp A
                   sumCompA,                    // sum of all costs for comp A

                   compBPersonTotal,            // total fee for number of people for comp B
                   compBDistanceTotal,          // total fee for distance for comp B
                   compBDeliveryTotal,          // total fee for delivery for comp B
                   sumCompB,                    // sum of all costs for comp B
                  
                   compCPersonTotal,            // total fee for number of people for comp C
                   compCDistanceTotal,          // total fee for distance for comp C
                   compCDeliveryTotal,          // total fee for delivery for comp C
                   sumCompC;                    // sum of all costs for comp C


            // parsing

            int.TryParse(peopleInputTextBox.Text, out peopleInput);
            int.TryParse(deliveryDaysInputTextBox.Text, out deliveryDaysInput);
            double.TryParse(distanceInputTextBox.Text, out distanceInput);

            // company A

                  sumCompA = 0;

                 // company A person fee calculations

                    if (peopleInput > 0)
                    {
                       compAPersonTotal = peopleInput * compAPersonFee;
                        Convert.ToDouble(compAPersonTotal);
                        sumCompA += compAPersonTotal;
                    }

                    else
                    {
                        MessageBox.Show("Enter a valid number of people");
                    }

                 // company A distance calculations


                    if (distanceInput >= 0)
                    {
                        compADistanceTotal = distanceInput * compADistanceFee;
                        sumCompA += compADistanceTotal;
                    }

                    else
                    {
                        MessageBox.Show("Enter a valid distance");
                    }

                 // company A delivery days calculations


                    if (deliveryDaysInput == 1)
                    {
                        compADeliveryTotal = compAPrepDays1;
                        Convert.ToDouble(compADeliveryTotal);
                        sumCompA += compADeliveryTotal;
                    }

                    else if (deliveryDaysInput == 2)
                    {
                        compADeliveryTotal = compAPrepDays2;
                        Convert.ToDouble(compADeliveryTotal);
                        sumCompA += compADeliveryTotal;
                     }

                    else if (deliveryDaysInput == 3)
                    {
                        compADeliveryTotal = compAPrepDays3;
                        Convert.ToDouble(compADeliveryTotal);
                        sumCompA += compADeliveryTotal;
                     }

                    else if (deliveryDaysInput >= 4 && deliveryDaysInput <= 7)
                    {
                        compADeliveryTotal = compAPrepDays4To7;
                        Convert.ToDouble(compADeliveryTotal);
                        sumCompA += compADeliveryTotal;
                    }

                    else if (deliveryDaysInput > 7)
                    {
                        compADeliveryTotal = compAPrepDays7Plus;
                        Convert.ToDouble(compADeliveryTotal);
                         sumCompA += compADeliveryTotal;
                    }

                    else
                    {
                        MessageBox.Show("Enter a valid number of days");
                    }

                 // company A total calculation

                    if (sumCompA > 0)
                    {
                        companyACostOutputLabel.Text = $"{sumCompA:C2}";
                    }
                    else
                    {
                        companyACostOutputLabel.Text = "Invalid Input";
                    }



            // company B

            sumCompB = 0;

                 // company B person fee calculations

                    if (peopleInput > 0 && peopleInput < 10)
                    {
                        compBPersonTotal = compBPersonFee1 * peopleInput;
                        sumCompB += compBPersonTotal;
                    }

                    else if (peopleInput >= 10 && peopleInput < 50)
                    {
                        compBPersonTotal = compBPersonFee2 * peopleInput;
                        sumCompB += compBPersonTotal;
                    }

                    else if (peopleInput >= 50 && peopleInput < 100)
                    {
                        compBPersonTotal = compBPersonFee3 * peopleInput;
                        sumCompB += compBPersonTotal;
                    }

                    else if (peopleInput >= 100 && peopleInput < 200)
                    {
                        compBPersonTotal = compBPersonFee4 * peopleInput;
                        sumCompB += compBPersonTotal;
                    }

                    else if (peopleInput >= 200)
                    {
                        compBPersonTotal = compBPersonFee5 * peopleInput;
                        sumCompB += compBPersonTotal;
                    }
                    
                 // company B distance calculations

                    if (distanceInput >= 0)
                    {
                        compBDistanceTotal = distanceInput * compBDistanceFee;
                        sumCompB += compBDistanceTotal;
                    }

                 // company B delivery days calculations

                    if (deliveryDaysInput > 0 && deliveryDaysInput <= 4)
                    {
                        compBDeliveryTotal = compBPrepDays1To4;
                        sumCompB += compBDeliveryTotal;
                    }

                    else if (deliveryDaysInput > 4)
                    {
                        compBDeliveryTotal = compBPrepDays4Plus;
                        sumCompB += compBDeliveryTotal;
                    }

                 // company B total calculation

                    if (sumCompB > 0)
                    {
                        companyBCostOutputLabel.Text = $"{sumCompB:C2}";
                    }
                    
                    else
                    {
                        companyBCostOutputLabel.Text = "Invalid Input";
                    }

            // company C

                 // company C person fee calculations
                    
                    sumCompC = 0;
                
                    if (peopleInput > 0)
                    {
                        Convert.ToDouble(peopleInput);
                        compCPersonTotal = peopleInput * compCPersonFee;
                        sumCompC += compCPersonTotal;
                    }

                // company C distance calculations

                    if (distanceInput >= 1000)
                    {
                        compCDistanceTotal = compCDistanceFee5;
                        sumCompC += compCDistanceTotal;
                    }
            
                    else if (distanceInput >= 750 && distanceInput < 1000)
                    {
                        compCDistanceTotal = compCDistanceFee4;
                        sumCompC += compCDistanceTotal;
                    }

                    else if (distanceInput >= 500 && distanceInput < 750)
                    {
                        compCDistanceTotal = compCDistanceFee3;
                        sumCompC += compCDistanceTotal;
                    }
            
                    else if (distanceInput >= 200 && distanceInput < 500)
                    {
                        compCDistanceTotal = compCDistanceFee2;
                        sumCompC += compCDistanceTotal;
                    }

                    else if (distanceInput >= 0 && distanceInput < 200)
                    {
                        compCDistanceTotal = compCDistanceFee1;
                        sumCompC += compCDistanceTotal;
                    }

                // company C delivery days calculations

                    if (deliveryDaysInput > 0)
                    {
                        compCDeliveryTotal = compCDeliveryFee;
                        sumCompC += compCDeliveryTotal;
                    }

                // company C total calculation

                    if (sumCompC > 0)
                    {
                        companyCCostOutputLabel.Text = $"{sumCompC:C2}";
                    }
                    
                    else
                    {
                        companyCCostOutputLabel.Text = "Invalid Input";
                    }

            // lowest cost reccommendation

                    if (sumCompA < sumCompB && sumCompA < sumCompC)
                    {
                        lowestCompanyCostLabel.Text = "The lowest cost is company: A";
                    }

                    else if (sumCompB < sumCompA && sumCompB < sumCompC)
                    {
                        lowestCompanyCostLabel.Text = "The lowest cost is company: B";
                    }

                    else if (sumCompC < sumCompA && sumCompC < sumCompB)
                    {
                        lowestCompanyCostLabel.Text = "The lowest cost is company: C";
                    }

        }
    }
}
