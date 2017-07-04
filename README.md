win-tabcontrol
==============

A Tab/Pivot control for windows store apps, similar to the one used in the windows store

Link to download binary version of the control:
[DLL download](https://github.com/brianmwadime/win-tabcontrol/raw/master/Binaries/Peeksoft.Win.TabControl.dll)

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
