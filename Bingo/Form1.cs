using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {

        Timer choosenNrTimer;
        Timer labelTimer;
        Timer bingoTimer;
        Timer fillerTimer;
        Timer randomTimer;

        
        static string greetingString;
        
        static int[] choosenNumbers;
        static int[] randomNumbers;

        static int randomRollCounter;
        static int nrPanelLoc;
        static int bingoPanelLoc;
        static int randomRolledNr = 0;
        static int generatedNr = 0;
        static int correctResults = 0;
        static int infoPanelLoc;
        static int fillerPanelLoc;
        static int letterCounter;

        static Label[] myDisplayedLabels;
        static Label[] bingoLabelArray;


        public Form1()
        {
            InitializeComponent();

            randomNumbers = new int[7];

            greetingString = "Välkommen till CyberBingo!!";
            letterCounter = greetingString.Length-1;
            choosenNumbers = new int[10];
            bingoLabelArray = new Label[7];
            bingoLabelArray[0] = bingoLabel0;
            bingoLabelArray[1] = bingoLabel1;
            bingoLabelArray[2] = bingoLabel2;
            bingoLabelArray[3] = bingoLabel3;
            bingoLabelArray[4] = bingoLabel4;
            bingoLabelArray[5] = bingoLabel5;
            bingoLabelArray[6] = bingoLabel6;

            myDisplayedLabels = new Label[10];
            myDisplayedLabels[0] = chosenLabel0;
            myDisplayedLabels[1] = chosenLabel1;
            myDisplayedLabels[2] = chosenLabel2;
            myDisplayedLabels[3] = chosenLabel3;
            myDisplayedLabels[4] = chosenLabel4;
            myDisplayedLabels[5] = chosenLabel5;
            myDisplayedLabels[6] = chosenLabel6;
            myDisplayedLabels[7] = chosenLabel7;
            myDisplayedLabels[8] = chosenLabel8;
            myDisplayedLabels[9] = chosenLabel9;
            bingoPanel.Location = new Point(12, -100);

            bingoPanelLoc = -100;
            infoPanelLoc = -100;
            nrPanelLoc = choosenNrPanel.Location.Y;
            fillerPanelLoc = fillerPanel.Location.X;

            bingoPanel.Location = new Point(12, bingoPanelLoc);
            bingoPanel.Visible = false;

            choosenNrTimer = new Timer();
            labelTimer = new Timer();
            bingoTimer = new Timer();
            fillerTimer = new Timer();
            randomTimer = new Timer();

            fillerTimer.Interval = 1;
            fillerTimer.Tick += FillerTimer_Tick;

            bingoTimer.Interval = 1;
            bingoTimer.Tick += BingoTimer_Tick;

            choosenNrTimer.Interval = 1;
            choosenNrTimer.Tick += ChoosenNrTimer_Tick;

            
            randomTimer.Interval = 50;
            randomTimer.Tick += RandomTimer_Tick;

            labelTimer.Interval = 1;
            labelTimer.Tick += MyTimer_Tick;
            labelTimer.Start();

        }

        //Aternativ till Contains
        public static bool CheckInLabelArray(string s, Label[] label)
        {
            bool inArray = false;
            for (int i =0; i<label.Length; i++)
            {
                if (label[i].Text==s)
                {
                    inArray = true;
                }
            }

            return inArray;
        } 

        private void RandomTimer_Tick(object sender, EventArgs e)
        {
            if (randomRollCounter<=20)
            {
                
                 if (randomRollCounter%2==1)
                {
                    randomPanel.BackColor = Color.White;
                    choosenNrPanel.BackColor = Color.Gray;
                    bingoPanel.BackColor = Color.LightCyan;
                }
                 else
                {
                    randomPanel.BackColor = Color.Silver;
                    choosenNrPanel.BackColor = Color.Silver;
                    bingoPanel.BackColor = Color.Silver;
                }
                
                Random myRandom = new Random();
                
                generatedNr = myRandom.Next(1, 25);
                randomLabel8.Text = randomLabel7.Text;
                randomLabel7.Text = randomLabel6.Text;
                randomLabel6.Text = randomLabel5.Text;
                randomLabel5.Text = randomLabel4.Text;
                randomLabel4.Text = randomLabel3.Text;
                randomLabel3.Text = randomLabel2.Text;
                randomLabel2.Text = randomLabel1.Text;
                randomLabel1.Text = generatedNr.ToString();
                if (!CheckInLabelArray(generatedNr.ToString(), bingoLabelArray))
                {
                    randomRollCounter++;

                }

            }
            else
            {
                bool notUsedNr = true;
                randomRolledNr = int.Parse(randomLabel1.Text);
                for (int i = 0; i < bingoLabelArray.Length; i++)
                {
                    if ((notUsedNr) && (bingoLabelArray[i].Text == ""))
                    {
                        bingoLabelArray[i].Text = generatedNr.ToString();
                        notUsedNr = false;
                    }
                }

                correctResults = 0;
                for (int i = 0; i < myDisplayedLabels.Length; i++)
                {
                    for (int ii = 0; ii < bingoLabelArray.Length; ii++)
                    {
                        if (myDisplayedLabels[i].Text == bingoLabelArray[ii].Text)
                        {
                            myDisplayedLabels[i].BackColor = Color.Blue;
                            bingoLabelArray[ii].BackColor = Color.Blue;
                            correctResults++;
                        }
                    }
                }

                if(bingoLabel6.Text!="")
                {
                    resultLabel.Text = "Du hade " + correctResults.ToString() + " rätta tal!";
                    resultPanel.Visible = true;
                }

                randomTimer.Stop();
            }
        }

        private void FillerTimer_Tick(object sender, EventArgs e)
        {
            fillerPanel.Location = new Point(fillerPanelLoc, fillerPanel.Location.Y);
            if(fillerPanelLoc<700)
            {
                fillerPanelLoc += 5;
            }
            else
            {
                choosenNrTimer.Start();
                fillerTimer.Stop();
                bingoTimer.Start();
            }
        }

        private void BingoTimer_Tick(object sender, EventArgs e)
        {
            bingoPanel.Visible = true;
            bingoPanel.Location = new Point(12, bingoPanelLoc);
            if (bingoPanel.Location.Y < 99)
            {
                bingoPanelLoc += 5;
                
            }
            else
            {
                bingoTimer.Stop();
            }

        }


        //Flyttar ner de valda numren
        private void ChoosenNrTimer_Tick(object sender, EventArgs e)
        {
            nrTextBox.Visible = false;
            nrOkButton.Visible = false;
            instructionLabel.Visible = false;

            if(choosenNrPanel.Location.Y<235)
            {
                nrPanelLoc+=5;
                choosenNrPanel.Location = new Point(12, nrPanelLoc);
            }
            else
            {
                choosenNrTimer.Stop();
                bingoTimer.Start();
            }

        }

        //Flyttar ner presentationen
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            infoPanel.Location = new Point(12, infoPanelLoc);
            if (infoPanel.Location.Y <12)
            {
                infoPanelLoc+=5;
                
            }
            else
            {
                if(letterCounter>=0)
                {
                    string labelText = greetingString[letterCounter] + infoPanelLabel.Text;
                    infoPanelLabel.Text = labelText;
                    letterCounter--;
                }
                else
                {
                    choosenNrPanel.Visible = true;
                    labelTimer.Stop();
                }

            }

        }

        private void nrOkButton_Click(object sender, EventArgs e)
        {
            //Använder den här för att bara köra programmet om användaren matar in rätt.
            bool correctInput = true;
            int choosenNr = 0;
            if(nrTextBox.Text.Length>0)//Kontrollerar så att någonting faktiskt har matats in.
            {
                try
                {
                    choosenNr = int.Parse(nrTextBox.Text);
                }
                catch
                {
                    nrTextBox.Text = "";
                    correctInput = false;
                }
            }

            if((choosenNr>0)&&(choosenNr<=25)&&(!CheckInLabelArray(choosenNr.ToString(), myDisplayedLabels)) &&(correctInput))
            {
                nrTextBox.Text = "";
                bool notUsedNr = true;
                for(int i = 0; i<choosenNumbers.Length; i++)
                {
                    if((myDisplayedLabels[i].Text=="")&&(notUsedNr))//ser så inte något redan tar upp platsen i vektorn
                    {
                        choosenNumbers[i] = choosenNr;
                        myDisplayedLabels[i].Text = choosenNr.ToString();
                        notUsedNr = false;
                    }
                }
            }
            else
            {
                nrTextBox.Text = "";
            }
            if(chosenLabel9.Text!="")
            {
                fillerTimer.Start();
                
            }

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (bingoLabel6.Text == "")
            {
                randomRollCounter = 0;
                randomTimer.Start();
            }
        }
    }
}
