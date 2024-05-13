using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__5
{
    public class Producto
    {
        private int _code;
        private string _name;
        private string _description;
        private string _category;
        private double _sellPrice;
        private double _buyPrice;
 


        public Producto(int code, string name, string description, string category, double sellPrice, double buyPrice) 
        {
            this._code = code;
            this._name = name;
            this._description = description;
            this._category = category;
            this._sellPrice = sellPrice;
            this._buyPrice = buyPrice;
        }

        public bool thereIsSellPrice()
        {
            return this._sellPrice > 0;
            
        }

    }
}
