using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias{

    class Program{

        static void Main(string[] args){
            StormExample st = new StormExample();

            st.SPConsultar();
        }
    }
}
