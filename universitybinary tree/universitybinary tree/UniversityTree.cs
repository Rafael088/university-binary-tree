using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace universitybinary_tree
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, String parentPositionName){
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;
            if (Root==null) {
                Root = newNode;
                return;
            }
            if(parent==null) {
                return;
            }
            if (parent.Position.Name==parentPositionName) { 
                if(parent.Left==null) {
                    parent.Left = newNode;
                    return;
                }
                parent.Right = newNode;
                return;
            }
            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);
        }
        public void PrintTree(PositionNode from)
        {
            if(from==null) {
                return;
            }
            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}");
            PrintTree(from.Left);
            PrintTree(from.Right);
        }
        public float AddSalary(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + AddSalary(from.Left) + AddSalary(from.Right);
          
        }
    }
}
