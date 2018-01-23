using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1TemperatureConvertASP
{
    //**************************************************************
    //**************************************************************

    //TEMPERATURE CONVERTER (Lab1)(ASP.NET)
    //Dean Jones
    //Jan.12, 2017

    //**************************************************************
    //**************************************************************

    //TO DO...
    //**************************************************************
    //C = ( F - 32) / 1.8
    //C = K - 273.15
    //F = C × 1.8 + 32
    //F = K × 1.8 - 459.67
    //K = C  + 273.15
    //K = ( F + 459.67) / 1.8


    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //default (celsius to farenheit)
                cboTempFrom.SelectedIndex = 0;
                cboTempTo.SelectedIndex = 1;
            }

            //comment out, now that ASPNET.SCRIPTMANAGER.JQUERY installed
            //uses JQuery validation now...
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        //CALCULATE FARENHEIT TO CELSIUS
        public double CalcFtoC(double f)
        {
            double c;

            //calc
            c = (f - 32) / 1.8;
            return c;
        }

        //CALCULATE KELVIN TO CELSIUS
        public double CalcKtoC(double k)
        {
            double c;

            //calc
            c = k - 273.15;
            return c;
        }

        //CALCULATE CELSIUS TO FARENHEIT
        public double CalcCtoF(double c)
        {
            double f;

            //calc
            f = c * 1.8 + 32;
            return f;
        }

        //CALCULATE KELVIN TO FARENHEIT
        public double CalcKtoF(double k)
        {
            double f;

            //calc
            f = k * 1.8 - 459.67;
            return f;
        }

        //CALCULATE CELSIUS TO KELVIN
        public double CalcCtoK(double c)
        {
            double k;

            //calc
            k = c + 273.15;
            return k;
        }

        //CALCULATE FARENHEIT TO KELVIN
        public double CalcFtoK(double f)
        {
            double k;

            //calc
            k = (f + 459.67) / 1.8;
            return k;
        }

        //BUTTON CONVERT (does temperature calculation)
        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtTempFrom.Text == "")
            {
                //???
            }
            else
            {
                double d_from = Convert.ToDouble(txtTempFrom.Text);

                //C to F
                if (cboTempFrom.SelectedIndex == 0 && cboTempTo.SelectedIndex == 1)
                {
                    //txtTempTo.Text = CalcCtoF(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcCtoF(d_from).ToString("#.##");
                }
                //C to K
                else if (cboTempFrom.SelectedIndex == 0 && cboTempTo.SelectedIndex == 2)
                {
                    //txtTempTo.Text = CalcCtoK(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcCtoK(d_from).ToString("#.##");
                }
                //F to C
                else if (cboTempFrom.SelectedIndex == 1 && cboTempTo.SelectedIndex == 0)
                {
                    //txtTempTo.Text = CalcFtoC(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcFtoC(d_from).ToString("#.##");
                }
                //F to K
                else if (cboTempFrom.SelectedIndex == 1 && cboTempTo.SelectedIndex == 2)
                {
                    //txtTempTo.Text = CalcFtoK(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcFtoK(d_from).ToString("#.##");
                }
                //K to C
                else if (cboTempFrom.SelectedIndex == 2 && cboTempTo.SelectedIndex == 0)
                {
                    //txtTempTo.Text = CalcKtoC(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcKtoC(d_from).ToString("#.##");
                }
                //K to F
                else if (cboTempFrom.SelectedIndex == 2 && cboTempTo.SelectedIndex == 1)
                {
                    //txtTempTo.Text = CalcKtoF(Convert.ToDouble(txtTempFrom.Text)).ToString();
                    txtTempTo.Text = CalcKtoF(d_from).ToString("#.##");
                }

                //COMBOBOX ARE SAME
                //C to C
                else if (cboTempFrom.SelectedIndex == 0 && cboTempTo.SelectedIndex == 0)
                {
                    txtTempTo.Text = txtTempFrom.Text;
                }
                //F to F
                else if (cboTempFrom.SelectedIndex == 1 && cboTempTo.SelectedIndex == 1)
                {
                    txtTempTo.Text = txtTempFrom.Text;
                }
                //K to K
                else if (cboTempFrom.SelectedIndex == 2 && cboTempTo.SelectedIndex == 2)
                {
                    txtTempTo.Text = txtTempFrom.Text;
                }
            }
            
        }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message + ": " + ex.GetType());
            //}
            //catch (Exception ex2)
            //{
            //    Console.WriteLine("Error: " + ex2.Message + ": " + ex2.GetType());
            //}

        

        //METHOD CLEAR TEXTBOXES
        protected void ClearInputs()
        {
            txtTempFrom.Text = "";
            txtTempTo.Text = "";
            txtTempFrom.Focus();
        }

        //CLEAR INPUT (textboxes)
        protected void btnClear_Click(object sender, EventArgs e)
        {
            //ClearInputs();
            txtTempFrom.Text = "";
            txtTempTo.Text = "";
            txtTempFrom.Focus();
        }

        //EVENT (combobox changed)
        protected void cboTempTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearInputs();
            txtTempFrom.Text = "";
            txtTempTo.Text = "";
            txtTempFrom.Focus();
        }
        //EVENT (combobox changed)
        protected void cboTempFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClearInputs();
            txtTempFrom.Text = "";
            txtTempTo.Text = "";
            txtTempFrom.Focus();
        }

        //CLEAR TEXT IF CHANGED
        protected void txtTempFrom_TextChanged(object sender, EventArgs e)
        {
            txtTempTo.Text = "";
        }
    }
}