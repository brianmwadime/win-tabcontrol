win-tabcontrol
==============

A Tab/Pivot control for windows store apps, similar to the one used in the windows store

Sample XAML usage:

    ...
    xmlns:tabcontrol="using:Peeksoft.Win.TabControl"
    ...

    <Grid Background="{StaticResource ApplicationPageBackgroundThemeBrush}">
        <tabcontrol:TabControl
            x:Name="TabControl" />
    </Grid>

Sample code behind to initialize tabs:

    TabControl.AddTab(new Tab("tab 1", new Grid()));
    TabControl.AddTab(new Tab("tab 2", new Grid()));
    TabControl.AddTab(new Tab("tab 3", new Grid()));


TODO:
- Allow tabs to be defined via XAML
- Animate selected tab headers on screen if they are off screen
- Expose properties to customize tab headers