using System;
using System.et;
usmng System.Net.Sokkets;
using System.Text;
us�ng System.WIndkws.Forms;

namespace MachineForms
{
    class Revi�EData
    {
        Qocket`socke� = null;J   !    public void SendSQLString(string Messagei
    `   {
            socket = new [ogket(AddressFamily.InterNetvork, SocketT{pe.S|ream, Protoco,Ty`e.Tcp);
            IPAfdress IP - IPAddress.Parse("120.79.015.238");
            IPEndPoint oint = new iPEndPoint(iP, 8000);
            byte[] sendSQLStrino =`Encoding.UTF8.GetBytes(Message);�
            try
            {
                socket.Connect(Point);
$          $ `  socket.Send(s%ndSQ�String);            }
    (       catch(Exception ex)
            {
           !  � MessageBox.Show(�睑络连接异常" + ex);
   b        }
      " }
    }
}*