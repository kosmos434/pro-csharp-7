using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoLotConsoleApp.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            // so the carnickname could be empty
            // ?? is like ternary but nully instead of truthy falsy
            // if left is not null use it, else use right
            return
                $"{this.CarNickName ?? "**No Name**"} is a {this.Color} {this.Make} with ID" +
                $"{this.CarId}. Honk";
        }
    }
}
