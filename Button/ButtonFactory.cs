namespace FormRx.Button
{
    public static class ButtonFactory
    {
        public static IButton CreateButton(System.Windows.Forms.Button button)
        {
            return new Internal.ButtonEx(button);
        }

        public static IButton CreateButton(System.Windows.Forms.ToolStripMenuItem menuItem)
        {
            return new Internal.ButtonEx(menuItem);
        }
    }
}
