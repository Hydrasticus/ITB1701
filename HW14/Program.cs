using System;
using System.Collections.Generic;

namespace HW14 {
    internal class Program {
        public static void Main(string[] args) {
            StringManipulator strMani = new StringManipulator();
            strMani.DecodeAccount("ttu\\mari.maasikas"); // Name: Mari Maasikas, Domain: TTU
            strMani.DecodeAccount("juhan.kannu.juurikas@ttu.ee"); // Name: Juhan Kannu Juurikas, Domain: TTU
            strMani.DecodeAccount("i:0#.w|microsoft\\liina.miina"); // Name: Liina Miina, Domain: MICROSOFT
            
            strMani.EncodeAccount("ttu.ee mari maasikas"); // mari.maasikas@ttu.ee, ttu\mari.maasikas
            strMani.EncodeAccount("ttu.ee juhan kannu juurikas"); // JuhanKannu.Juurikas@ttu.ee, ttu\juhankannu.juurikas
        }
    }
}