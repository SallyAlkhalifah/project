namespace BlazorApp4.Pages
{
    public partial class Massage
    {
        private string msg = "hello";
        private bool isChanged = false;
        private void ChangeMasseage()
        {
            msg = isChanged ? "opening massage" : "Massage has changed successfully";
            isChanged = !isChanged;
        }
    }
}
