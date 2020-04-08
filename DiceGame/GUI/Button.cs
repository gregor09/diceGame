using System;
using System.Collections.Generic;
using System.Text;

namespace DiceGame.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private TextLine textLine;
        private int buttonId;

        public bool IsActive { get; private set; } = false;
        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            notActiveFrame = new Frame(x, y, width, height, '+');
            activeFrame = new Frame(x, y, width, height, '#');
            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public void SetActive()
        {
            IsActive = true;
        }

        public void Deactive()
        {
            IsActive = false;
        }

        public int ButtonId
        {
            get { return buttonId; }
            set { buttonId = value; }
        }
        public override void Render()
        {
            if (IsActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }


    }
}
