﻿using System;

namespace FashionWise3
{
    public class Beverly : Model
    {
        public Beverly() : base()
        {
            modelName = "Beverly";

            //set the movement value
            modelHeight = "6`0";


            //Hero name
            modelLook = @"


                ════════════════════════════════════════
                ══════════════════░░░═══════════════════
                ══════════════░▓▓███████▓▒░═══▒██░══════
                ═══════════▒██▓▒▒▒▒▒▒▒▒▒▓▓█▒▒██████═════
                ═════════███████═══░░░░░░░░▓███░═███════
                ════════▒████████▓══░░░░░░═███▒▒══███═══
                ══════░██▒═════████══░░░░░░██══▒▓░═█░═══
                ═════░█▓░░░░░░══░███══░░░░░═══▒██▓▒═════
                ════░█▓░░░░░░░░░══███═░░░░░══██████▒════
                ════█▓░═░░░░░░░░░══███═░░░░═███═▒███▒═══
                ═══▓▓░░░░░░░░░░░░░══██═░░░═▒██════██▓▒══
                ══▒█▒░░░░░░░░░░░░░░═══░░░░═██═════███▓══
                ══█▓═░░░░░░░░░░░░░░░░░░░░░═██═════░██▓▓═
                ═▒█░░░░░░░══════░░░░░░░░░═░█▓═════░██░█═
                ═█▓░░░░░░═█████▒══░░░░░░░░▒█░═███═░██░█═
                ░█▒░░░░░░═███████▓══░░░░░═▒█▓█████═██░▓█
                ▒▓░░░░░░░░═══░▓████══░░░░░░███████░██░▒█
                ▓▒░░░░░░░░░═░═══░███▒═░░░══███████▓██░▒█
                ▓▒░░░░░░░░░░░░░░══███░░░░░═█████████▒░▒▓
                █▒░░░░░░░░░░░░░░░══▒░░░░░░═░████████░▒▒▓
                ▓▒░░░░░░░░░░░░░░░░░░░░░░░░░═███████▒░▒░▓
                █▒░░░░░░░░░░░░░░░░░░░░░░░░░══▓████▒░▒▒▒▒
                █▒░▒░░░░░░░░░░░░░░░░░░░░░░░░░═░▒▒░░▒▒▒▒▓
                █▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▒▒▓
                █▒░▒░░░░░░░░██═░░░░░░░░░░░░░░░░▒░▒▒▒▒▒▒▓
                █▓░▒▒░░░░░░═██░═░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒█
                ██░▒▒▒░░░░░═██▒═░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒█
                ▓█▒░▒▒░░░░░═▒██═░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▓█
                ░█▒░▒▒░▒░░░░═██▒═░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▓█
                ═██░▒▒▒▒▒░░░═░██░═░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒█▒
                ═▓█▒░▒▒▒▒▒░░░═▓██░═░░░░▒░▒▒▒▒▒▒▒▒▒▒▒░██═
                ══██▒▒▒▒▒▒▒░▒░═███▓═░░░░▒▒▒▒▒▒░░▒▒▒░▒█▓═
                ══▒█▓▒▒▒▒▒▒▒▒▒░═▓███▓░═░░░░░░░▓█▓▒▒▒██══
                ═══██▒▒▒▒▒▒▒▒▒▒░░▒█████▓▓▒▓▓█████░▒▓█░══
                ════██▒▒▒▒▒▒▒▒▒▒▒░░▒███████████▓░▒▓█▒═══
                ═════██▒▒▒▒▒▒▒▒▒▒▒▒░░░▓█████▓▒░░░▓█▓════
                ═════░██▓▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░▒░▒██▓═════
                ═══════███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▓██▓══════
                ════════▓███▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▒▒███░═══════
                ═════════░████▓▒▒▒▒▒▒░▒▒▒▒▓███▓═════════
                ═══════════░▓██████▓▓███████▒═══════════
                ══════════════░▓█████████▒░═════════════
                ════════════════════════════════════════ 
";



            //set the endurance
            modelAge = 45;
        }

        public override void ModelInfo()
        {
            Console.WriteLine($"{modelName} is {modelHeight} inches tall");
            //base.Move();
        }
    }

}

