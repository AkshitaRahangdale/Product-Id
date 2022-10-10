using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Product_Id
{
    public class Product
    {
        private int id,price;
        private string name;

        public void Add()
        {
            id = 123;
            name = "Joe";
            price = 80;
        }

           public string Print()
            {
                return $"product:{id}/{name}/{price}";
            }

            
    }
 }
    
        
    

