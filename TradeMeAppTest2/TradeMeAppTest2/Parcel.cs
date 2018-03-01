using System;

public class Parcel
{
    private double weight;
    private double length;
    private double breadth;
    private double height;
    private String size;
    private double cost;
    private double smallcost = 5.00;
    private double mediumcost = 7.50;
    private double largecost = 8.50;

    public Parcel(double weight, double length, double breadth, double height)
    {
        this.weight = weight;
        this.length = length;
        this.breadth = breadth;
        this.height = height;
        setSize();
    }

    public void setLength(double length)
    {
        this.length = length;
    }

    public void setBreadth(double breadth)
    {
        this.breadth = breadth;
    }

    public void setHeight(double height)
    {
        this.height = height;
    }

    public void setWeight(double weight)
    {
        this.weight = weight;
    }

    public void setSize()
    {
        if (weight > 25)
            size = "over limit";
        else
        {
            if ((length <= 200) || (breadth <= 300) || (height <= 150))
                size = "small";
            if ((length > 200) || (breadth > 300) || (height > 150))
                size = "medium";
            if ((length > 300) || (breadth > 400) || (height > 200))
                size = "large";
            if ((length > 400) || (breadth > 600) || (height > 250))
                size = "over limit";
        }

       setCost();
    }

    public void setSizeCosts(double small, double medium, double large) {
        smallcost = small;
        mediumcost = medium;
        largecost = large;
    }

    public void setCost()
    {
        if (size.Equals("small"))
            cost = smallcost;
        else if (size.Equals("medium"))
            cost = mediumcost;
        else if (size.Equals("large"))
            cost = largecost;

    }


    public String getSize()
    {
        return size;
    }

    public double getCost()
    {
        return cost;
    }

    public double getLength()
    {
        return length;
    }

    public double getBreadth()
    {
        return breadth;
    }

    public double getHeight()
    {
        return height;
    }

    public double getWeight()
    {
        return cost;
    }
}

