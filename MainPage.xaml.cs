using Calculator2022.Logic;
using System;

namespace Calculator2022;

public partial class MainPage : ContentPage
{
    Calculator calc = new Calculator();

    public MainPage()
    {
        InitializeComponent();
    }

    private void Clear(object sender, EventArgs e)
    {
        calc.Press("C");
        lblScreen.Text = calc.Screen;
    }
    private void Result(object sender, EventArgs e)
    {
        calc.Press("=");
        lblScreen.Text = calc.Screen;
    }
    private void Sign(object sender, EventArgs e)
    {
        calc.Press("-/+");
        lblScreen.Text = calc.Screen;
    }
    private void Plus(object sender, EventArgs e)
    {
        calc.Press("+");
        lblScreen.Text = calc.Screen;
    }
    private void Minus(object sender, EventArgs e)
    {
        calc.Press("-");
        lblScreen.Text = calc.Screen;
    }
    private void Multiply(object sender, EventArgs e)
    {
        calc.Press("*");
        lblScreen.Text = calc.Screen;
    }
    private void Divide(object sender, EventArgs e)
    {
        calc.Press("/");
        lblScreen.Text = calc.Screen;
    }
    private void Dot(object sender, EventArgs e)
    {
        calc.Press(".");
        lblScreen.Text = calc.Screen;
    }
    private void NumberOne(object sender, EventArgs e)
    {
        calc.Press("1");
        lblScreen.Text = calc.Screen;
    }
    private void NumberTwo(object sender, EventArgs e)
    {
        calc.Press("2");
        lblScreen.Text = calc.Screen;
    }
    private void NumberThree(object sender, EventArgs e)
    {
        calc.Press("3");
        lblScreen.Text = calc.Screen;
    }
    private void NumberFour(object sender, EventArgs e)
    {
        calc.Press("4");
        lblScreen.Text = calc.Screen;
    }
    private void NumberFive(object sender, EventArgs e)
    {
        calc.Press("5");
        lblScreen.Text = calc.Screen;
    }
    private void NumberSix(object sender, EventArgs e)
    {
        calc.Press("6");
        lblScreen.Text = calc.Screen;
    }
    private void NumberSeven(object sender, EventArgs e)
    {
        calc.Press("7");
        lblScreen.Text = calc.Screen;
    }
    private void NumberEight(object sender, EventArgs e)
    {
        calc.Press("8");
        lblScreen.Text = calc.Screen;
    }
    private void NumberNine(object sender, EventArgs e)
    {
        calc.Press("9");
        lblScreen.Text = calc.Screen;
    }
    private void NumberZero(object sender, EventArgs e)
    {
        calc.Press("0");
        lblScreen.Text = calc.Screen;
    }
}

