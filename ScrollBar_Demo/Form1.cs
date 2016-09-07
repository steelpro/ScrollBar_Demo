using System;
using System.Windows.Forms;
/*
 * Zachary Betters
 * CIS 209
 * Scroll Bar Demo
 * 7 September, 2016
 * This program will demonstrate the scroll bar feature. 
 */ 
namespace ScrollBar_Demo {
    public partial class ScrollBar : System.Windows.Forms.Form {
        public ScrollBar() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e) {
            hScrollBar.Value = 0; //default value
            hScrollBar.Minimum = 0; //lowest value it can have
            hScrollBar.Maximum = 100; //highest value it can have
            hScrollBar.LargeChange = 1; //value is added by 1 when bar is scrolled higher
            hScrollBar.SmallChange = 1; 
            vScrollBar.Value = 0;
            vScrollBar.Minimum = 0;
            vScrollBar.Maximum = 100;
            vScrollBar.LargeChange = 1;
            vScrollBar.SmallChange = 1;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e) { }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e) {
           tbHor.Text= hScrollBar.Value.ToString(); 
           if (tbHor.Text == "50") { //when scrollbar number is set to 50
                picEric.Visible = true; }
            else {
                picEric.Visible = false; } //show the picture
        }

        private void lblValue_Click(object sender, EventArgs e) { }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e) {
        tbVert.Text = vScrollBar.Value.ToString(); 
           if (tbVert.Text == "50") {
                picEric2.Visible = true; }
            else {
                picEric2.Visible = false; } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}