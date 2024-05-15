using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10.src
{
    public class Character
    {
        private IMoveStrategy moveStrategy;

        public void Move()
        {
            moveStrategy.Move();
        }

        public void ChangeMoveStrategy(IMoveStrategy moveStrategy)
        {
            this.moveStrategy = moveStrategy;
        }
    }
}
