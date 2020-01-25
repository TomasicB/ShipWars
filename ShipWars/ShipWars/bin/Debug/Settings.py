import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
from System.Windows.Forms import *
from System.Drawing import Point,Font

form=Form(Text="Settings", Height =200, Width=320)
lblName = Label(Text="Player: ", Location= Point(30,30), Height =20, Width=120)
tbName = TextBox(Location= Point(150,30), Height =20, Width=130)
btnStart = Button(Text="Start", Location=Point(180,120), Height =30, Width=100)
lblTime = Label(Text="Duration of the round: ", Location= Point(30,63), Height =20, Width=120)
lblDef = Label(Text="(Default time is 10min)", Location= Point(30,83), Height =20, Width=120)
rbT5 = RadioButton(Text="5min", Location=Point(150,60), Height =20, Width=70)
rbT10 = RadioButton(Text="10min", Location=Point(230,60), Height =20, Width=70)
rbT15 = RadioButton(Text="15min", Location=Point(150,90), Height =20, Width=70)
rbT20 = RadioButton(Text="20min", Location=Point(230,90), Height =20, Width=70)

def start(sender, args):
    form.Close()

def buttonclick(frm):
    form.Controls.Add(lblName)
    form.Controls.Add(tbName)
    form.Controls.Add(btnStart)
    form.Controls.Add(lblTime)
    form.Controls.Add(lblDef)
    form.Controls.Add(rbT5)
    form.Controls.Add(rbT10)
    form.Controls.Add(rbT15)
    form.Controls.Add(rbT20)
    btnStart.Click += start
    if rbT5.Checked:
        frm.time=3000
    elif rbT10.Checked:
        frm.time=6000
    elif rbT15.Checked:
        frm.time=9000
    elif rbT20.Checked:
        frm.time=12000
    else:
        frm.time=6000
    frm.Player1=tbName.Text
    form.ShowDialog()
    