using Entities.Abstract; //işaretleme. veritabanı tablosu
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{ 
    //Çıplak class kalmasın..gruplama
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
