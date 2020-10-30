using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace AutoLotDAL.Models
{
    public partial class Inventory
    {
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";

        public override string ToString()
        {
            // so the carnickname could be empty
            // ?? is like ternary but nully instead of truthy falsy
            // if left is not null use it, else use right
            return
                $"{this.PetName ?? "**No Name**"} is a {this.Color} {this.Make} with ID" +
                $"{this.Id}. Honk";
        }
    }
}
