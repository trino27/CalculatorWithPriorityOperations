using System;

namespace CyberHW12_4
{
    class Presenter
    {
        Model model = null;
        Form1 view = null;

        public Presenter(Form1 form)
        {
            this.model = new Model();
            this.view = form;

            this.view.ResEvent += new EventHandler(ResEvent);
            this.view.NullEvent += new EventHandler(NullEvent);

            this.view.PlEvent += new EventHandler(PlEvent);
            this.view.MiEvent += new EventHandler(MiEvent);
            this.view.MyEvent += new EventHandler(MyEvent);
            this.view.SeEvent += new EventHandler(SeEvent);

            this.view.Num0Event += new EventHandler(Num0Event);
            this.view.Num1Event += new EventHandler(Num1Event);
            this.view.Num2Event += new EventHandler(Num2Event);
            this.view.Num3Event += new EventHandler(Num3Event);
            this.view.Num4Event += new EventHandler(Num4Event);
            this.view.Num5Event += new EventHandler(Num5Event);
            this.view.Num6Event += new EventHandler(Num6Event);
            this.view.Num7Event += new EventHandler(Num7Event);
            this.view.Num8Event += new EventHandler(Num8Event);
            this.view.Num9Event += new EventHandler(Num9Event);
        }
       
        private void NullEvent(object sender, EventArgs e)
        {
            this.view.Label = "0";
        }

        private void Num9Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "9";
            else this.view.Label += '9';
        }
        private void Num8Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "8";
            else this.view.Label += '8';
        }
        private void Num7Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "7";
            else this.view.Label += '7';
        }
        private void Num6Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "6";
            else this.view.Label += '6';
        }
        private void Num5Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "5";
            else this.view.Label += '5';
        }
        private void Num4Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "4";
            else this.view.Label += '4';
        }
        private void Num3Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "3";
            else this.view.Label += '3';
        }
        private void Num2Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "2";
            else this.view.Label += '2';
        }
        private void Num1Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label == "0") this.view.Label = "1";
            else this.view.Label += '1';
        }
        private void Num0Event(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.view.Label != "0") this.view.Label += '0';
        }


        private void SeEvent(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (!this.model.IsRepOperators(this.view.Label))
            {
                this.view.Label += '/';
            }
        }
        private void MyEvent(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (!this.model.IsRepOperators(this.view.Label))
            {
                this.view.Label += '*';
            }
        }
        private void MiEvent(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (this.model.IsDoubleMinus(this.view.Label))
            {
                this.view.Label = this.view.Label.Substring(0, this.view.Label.Length - 1);
                PlEvent(sender, e);
            }
            else if (this.model.IsPlusMinus(this.view.Label))
            {
                this.view.Label = this.view.Label.Substring(0, this.view.Label.Length - 1) + '-';
            }
            else this.view.Label += '-';
        }
        private void PlEvent(object sender, EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            if (!this.model.IsRepOperators(this.view.Label))
            {
                this.view.Label += '+';
            }
        }

        void ResEvent(object sender, System.EventArgs e)
        {
            if (model.BadValue(this.view.Label)) NullEvent(sender, e);
            this.view.Label = this.model.Culc(this.view.Label);
        }
    }
}
