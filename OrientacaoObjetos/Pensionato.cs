﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrientacaoObjetos {
    class Pensionato {
        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome
                + ", "
                + Email;
        }
    }
}
