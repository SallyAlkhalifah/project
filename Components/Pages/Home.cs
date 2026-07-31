namespace BlazorApp4.Pages
{
    public partial class Home
    {
        private int number = 0;
        private void ChangeNumber()
        {
            number = new Random().Next(1, 100);
        }

    }
}
