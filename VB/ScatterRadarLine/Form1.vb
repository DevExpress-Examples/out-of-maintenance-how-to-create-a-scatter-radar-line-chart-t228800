Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace ScatterRadarLine
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim scatterRadarLineChart As New ChartControl()

            ' Add the chart to the form.
            scatterRadarLineChart.Dock = DockStyle.Fill
            Me.Controls.Add(scatterRadarLineChart)

            ' Create a scatter radar line series.
            Dim series1 As New Series("Series 1", ViewType.ScatterRadarLine)

            ' Add points to it.        
            series1.Points.Add(New SeriesPoint(2.58308729295161, 2.92389013581495))
            series1.Points.Add(New SeriesPoint(2.72271363311115, 1.60362130049876))
            series1.Points.Add(New SeriesPoint(2.8623399732707, 0.916511826809461))
            series1.Points.Add(New SeriesPoint(3.00196631343025, 0.426951214001806))
            series1.Points.Add(New SeriesPoint(3.14159265358979, 3.67381906146713E-16))
            series1.Points.Add(New SeriesPoint(0.15707963267949, 0.479172332020966))
            series1.Points.Add(New SeriesPoint(0.36651914291880, 1.16748565197914))
            series1.Points.Add(New SeriesPoint(0.575958653158129, 1.82356171354251))
            series1.Points.Add(New SeriesPoint(0.785398163397448, 2.12132034355964))
            series1.Points.Add(New SeriesPoint(0.994837673636768, 1.82356171354251))
            series1.Points.Add(New SeriesPoint(1.20427718387609, 1.16748565197914))
            series1.Points.Add(New SeriesPoint(1.41371669411541, 0.479172332020967))
            series1.Points.Add(New SeriesPoint(4.74729556542458, 0.10483062990165))
            series1.Points.Add(New SeriesPoint(5.02654824574367, 1.06132878657975))
            series1.Points.Add(New SeriesPoint(5.23598775598299, 2.47662710943896))
            series1.Points.Add(New SeriesPoint(5.27089434102288, 2.92389013581494))

            ' Add the series to the chart.
            scatterRadarLineChart.Series.Add(series1)

            ' Flip the diagram (if necessary).
            CType(scatterRadarLineChart.Diagram, RadarDiagram).StartAngleInDegrees = 10
            CType(scatterRadarLineChart.Diagram, RadarDiagram).RotationDirection = RadarDiagramRotationDirection.Clockwise

            ' Access the view-type-specific options of the series.
            CType(series1.View, ScatterRadarLineSeriesView).LineStyle.DashStyle = DashStyle.Dot

            ' Hide the legend (if necessary).
            scatterRadarLineChart.Legend.Visibility = DefaultBoolean.False

            ' Add a title to the chart (if necessary).
            scatterRadarLineChart.Titles.Add(New ChartTitle())
            scatterRadarLineChart.Titles(0).Text = "A Scatter Radar Line Chart"
        End Sub
    End Class
End Namespace
