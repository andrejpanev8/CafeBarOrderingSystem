using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace CafeBarOrderingSystem
{
    public partial class EarningsForm : Form
    {
        public EarningsForm()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }
        public void CreateChart(List<Order> orderList)
        {
            // Calculate sales data
            Dictionary<string, int> productSales = new Dictionary<string, int>();
            Dictionary<string, double> productEarnings = new Dictionary<string, double>();

            foreach (Order order in orderList)
            {
                foreach (ProductRow productRow in order.productRow)
                {
                    string productName = productRow.product.name;
                    int quantity = productRow.quantity;
                    double price = productRow.product.price;

                    if (!productSales.ContainsKey(productName))
                        productSales[productName] = 0;

                    if (!productEarnings.ContainsKey(productName))
                        productEarnings[productName] = 0;

                    productSales[productName] += quantity;
                    productEarnings[productName] += quantity * price;
                }
            }

            // Create and configure the chart
            Chart salesChart = new Chart();
            salesChart.ChartAreas.Add(new ChartArea());
            salesChart.Series.Add(new Series("Product Sales"));
            salesChart.Series.Add(new Series("Total Earnings"));

            int xAxisCounter = 0;
            foreach (string productName in productSales.Keys)
            {
                salesChart.Series["Product Sales"].Points.AddXY(productName, productSales[productName]);
                salesChart.Series["Total Earnings"].Points.AddXY(productName, productEarnings[productName]);

                xAxisCounter++;
            }

            salesChart.ChartAreas[0].AxisX.Interval = 1;
            salesChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            // Customize the chart appearance
            salesChart.Series["Product Sales"].ChartType = SeriesChartType.Column;
            salesChart.Series["Total Earnings"].ChartType = SeriesChartType.Column;
            salesChart.Series["Product Sales"].IsValueShownAsLabel = true;
            salesChart.Series["Total Earnings"].IsValueShownAsLabel = true;

            chartPanel.Width = productSales.Count() * 100;

            Label totalEarningsLabel = new Label();
            Label mostSoldProductLabel = new Label();
            Label leastSoldProductLabel = new Label();

            // Calculate total earnings, most sold product, and least sold product
            double totalEarnings = productEarnings.Values.Sum();
            string mostSoldProduct = productSales.OrderByDescending(kv => kv.Value).FirstOrDefault().Key;
            string leastSoldProduct = productSales.OrderBy(kv => kv.Value).FirstOrDefault().Key;

            // Set label text
            totalEarningsLabel.Text = $"Total Earnings: {totalEarnings} $";
            mostSoldProductLabel.Text = $"Customers favourite: {mostSoldProduct}";
            leastSoldProductLabel.Text = $"Worst performer: {leastSoldProduct}";

            // Position the labels on the bottom of the chart
            totalEarningsLabel.Dock = DockStyle.Bottom;
            mostSoldProductLabel.Dock = DockStyle.Bottom;
            leastSoldProductLabel.Dock = DockStyle.Bottom;

            //Styling the labels
            totalEarningsLabel.Font = new Font(totalEarningsLabel.Font.FontFamily, 13);
            totalEarningsLabel.Height = 25;
            mostSoldProductLabel.Font = new Font(mostSoldProductLabel.Font.FontFamily, 13);
            mostSoldProductLabel.Height = 25;
            leastSoldProductLabel.Font = new Font(leastSoldProductLabel.Font.FontFamily, 13);
            leastSoldProductLabel.Height = 25;


            // Add labels to the chartPanel
            chartPanel.Controls.Add(salesChart);
            chartPanel.Controls.Add(totalEarningsLabel);
            chartPanel.Controls.Add(mostSoldProductLabel);
            chartPanel.Controls.Add(leastSoldProductLabel);

            this.Height = chartPanel.Height + totalEarningsLabel.Height * 3 + 15;
            this.Width = Math.Min(Screen.PrimaryScreen.Bounds.Width, chartPanel.Width);

            chartPanel.AutoScroll = true;
            salesChart.Dock = DockStyle.Fill;
        }
    }
}
