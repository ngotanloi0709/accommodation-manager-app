using System.Windows.Forms;

namespace AccommodationManagerApp.Forms
{
    public partial class ClientForm
    {
        private int reqId;
        private void ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                reqId = int.Parse(e.Item.SubItems[0].Text);
                return;
            }
            reqId = 0;
        }
        private void resetReq()
        {
            reqId = 0;
            readReq();
        }
    }
}
