using System;
using System.Collections.Generic;

public class MenuItem
{
    public string Name {get; set;}
    public string Description {get; set;}
    public string Category {get; set;}
    public double Price {get; set;}
    public bool IsNew {get; set;}

    

    public class Menu
    {
        public List<MenuItem> Items {get; set;}
        
        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void AddItem (MenuItem item)
        {
            Items.Add(item);
        }
    
        
    
    
    }

    
}
