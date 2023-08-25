# Creating a Column Chart for Yearly Box Office Data

Column chart is used to plot discrete rectangles for the given data point values. To render a column chart, create an instance of [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

> The cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

## Spacing and Width

The [Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html#Syncfusion_Maui_Charts_ColumnSeries_Spacing) property is used to change the spacing between two segments. The default value of spacing is 0, and the value ranges from 0 to 1. Here, 1 and 0 correspond to 100% and 0% of the available space, respectively. 

The [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html#Syncfusion_Maui_Charts_ColumnSeries_Width) property is used to change the width of the rectangle. The default value of the width is 0.8, and the value ranges from 0 to 1.

Column chart is used to plot discrete rectangles for the given data point values. This sample demonstrates how to Create a Column Chart graph displaying yearly U.S. box office revenue data in .NET MAUI (SfCartesianChart).

![BoxOfficeChart](https://github.com/syncfusion-content/winui-docs/assets/105482474/1b27235d-1319-4dd8-808d-9128cfc5b570)

For a step by step procedure, refer to the [Column Chart Yearly Box Office Data blog](https://www.syncfusion.com/blogs/post/dotnet-maui-column-chart-visualize-yearly-box-office-data.aspx).
