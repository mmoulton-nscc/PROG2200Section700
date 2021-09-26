using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Registrar
    {
        new List<IGraduate> grads = new List<IGraduate>();
        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }

        public void graduateAll()
        {
            foreach (var grad in grads)
            {
                grad.graduate();
            }
        }
    }
}
