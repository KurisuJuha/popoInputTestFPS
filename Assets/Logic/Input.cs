using System.Linq;
using JuhaKurisu.PopoTools.ByteSerializer;

namespace popoInputTestFPS.Logic
{
    public class Input
    {
        public readonly bool leftButton;
        public readonly bool rightButton;
        public readonly bool upButton;
        public readonly bool downButton;

        public Input(bool rightButton, bool leftButton, bool upButton, bool downButton)
        {
            this.rightButton = rightButton;
            this.leftButton = leftButton;
            this.upButton = upButton;
            this.downButton = downButton;
        }

        public byte[] Serialize()
        {
            DataWriter writer = new DataWriter();

            writer.Append(leftButton);
            writer.Append(rightButton);
            writer.Append(upButton);
            writer.Append(downButton);

            return writer.bytes.ToArray();
        }
    }
}