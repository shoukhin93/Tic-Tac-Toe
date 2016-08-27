using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private bool pc_win()
        {
            if(button1.Text == "O")
            {
                if (win_condition(1))
                    return true;
            }

            if(button2.Text == "O")
            {
                if (win_condition(2))
                    return true;
            }

            if (button3.Text == "O")
            {
                if (win_condition(3))
                    return true;
            }

            if (button4.Text == "O")
            {
                if (win_condition(4))
                    return true;
            }

            if (button5.Text == "O")
            {
                if (win_condition(5))
                    return true;
            }

            if (button6.Text == "O")
            {
                if (win_condition(6))
                    return true;
            }

            if (button7.Text == "O")
            {
                if (win_condition(7))
                    return true;
            }

            if (button8.Text == "O")
            {
                if (win_condition(8))
                    return true;
            }

            if (button9.Text == "O")
            {
                if (win_condition(9))
                    return true;
            }

            return false;
        }

        private bool win_condition(int p)
        {
            

            if(p == 1)
            {
                if (button2.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button4.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button5.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button2.Text != "*")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button9.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 2)
            {
                if (button1.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button5.Text == "O" && button8.Text != "*")
                {
                    button8.Text = "O";
                    return true;
                }

                else if(button8.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }


            else if (p == 3)
            {
                if (button2.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button6.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button5.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button1.Text == "O" && button2.Text != "*")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button7.Text == "O" && button5.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 4)
            {
                if (button5.Text == "O" && button6.Text != "*")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button1.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button7.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button6.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 5)
            {
                if (button1.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button9.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button7.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button4.Text == "O" && button5.Text != "*")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button6.Text == "O" && button4.Text != "*")
                {
                    button4.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 6)
            {
                if (button5.Text == "O" && button4.Text != "*")
                {
                    button4.Text = "O";
                    return true;
                }

                else if (button9.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button4.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 7)
            {
                if (button4.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button5.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button8.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button1.Text == "O" && button4.Text != "*")
                {
                    button4.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                else if (button9.Text == "O" && button8.Text != "*")
                {
                    button8.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 8)
            {
                if (button5.Text == "O" && button2.Text != "*")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button7.Text == "O" && button9.Text != "*")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button9.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button2.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 9)
            {
                if (button5.Text == "O" && button1.Text != "*")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button8.Text == "O" && button7.Text != "*")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button6.Text == "O" && button3.Text != "*")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "O" && button6.Text != "*")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button1.Text == "O" && button5.Text != "*")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }
            return false;
        }

        private bool stop_human_win()
        {
            if(button1.Text == "*")
            {
                if (stop_human_win_codition(1))
                {
                    return true;
                }
            }

            if (button2.Text == "*")
            {
                if (stop_human_win_codition(2))
                {
                    return true;
                }
            }

            if (button3.Text == "*")
            {
                if (stop_human_win_codition(3))
                {
                    return true;
                }
            }

            if (button4.Text == "*")
            {
                if (stop_human_win_codition(4))
                {
                    return true;
                }
            }

            if (button5.Text == "*")
            {
                if (stop_human_win_codition(5))
                {
                    return true;
                }
            }


            if (button6.Text == "*")
            {
                if (stop_human_win_codition(6))
                {
                    return true;
                }
            }

            if (button7.Text == "*")
            {
                if (stop_human_win_codition(7))
                {
                    return true;
                }
            }

            if (button8.Text == "*")
            {
                if (stop_human_win_codition(8))
                {
                    return true;
                }
            }

            if (button9.Text == "*")
            {
                if (stop_human_win_codition(9))
                {
                    return true;
                }
            }

            return false;
        }

        private bool stop_human_win_codition(int p)
        {
            if (p == 1)
            {
                if (button2.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button4.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button5.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button2.Text != "O")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button9.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 2)
            {
                if (button1.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button5.Text == "*" && button8.Text != "O")
                {
                    button8.Text = "O";
                    return true;
                }

                else if (button8.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }


            else if (p == 3)
            {
                if (button2.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button6.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button5.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button1.Text == "*" && button2.Text != "O")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button7.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 4)
            {
                if (button5.Text == "*" && button6.Text != "O")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button1.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button7.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button6.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 5)
            {
                if (button1.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button9.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button7.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button4.Text == "*" && button5.Text != "O")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button6.Text == "*" && button4.Text != "O")
                {
                    button4.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 6)
            {
                if (button5.Text == "*" && button4.Text != "O")
                {
                    button4.Text = "O";
                    return true;
                }

                else if (button9.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button4.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 7)
            {
                if (button4.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button5.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button8.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button1.Text == "*" && button4.Text != "O")
                {
                    button4.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 8)
            {
                if (button5.Text == "*" && button2.Text != "O")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button7.Text == "*" && button9.Text != "O")
                {
                    button9.Text = "O";
                    return true;
                }

                else if (button9.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button2.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            else if (p == 9)
            {
                if (button5.Text == "*" && button1.Text != "O")
                {
                    button1.Text = "O";
                    return true;
                }

                else if (button8.Text == "*" && button7.Text != "O")
                {
                    button7.Text = "O";
                    return true;
                }

                else if (button6.Text == "*" && button3.Text != "O")
                {
                    button3.Text = "O";
                    return true;
                }

                else if (button3.Text == "*" && button6.Text != "O")
                {
                    button6.Text = "O";
                    return true;
                }

                else if (button1.Text == "*" && button5.Text != "O")
                {
                    button5.Text = "O";
                    return true;
                }

                return false;
            }

            return false;
        }

        private bool possible_move_one()
        {
            if(possible(1))
            {
                return true;
            }

            if (possible(2))
            {
                return true;
            }

            if (possible(3))
            {
                return true;
            }

            if (possible(4))
            {
                return true;
            }

            if (possible(5))
            {
                return true;
            }

            if (possible(6))
            {
                return true;
            }

            if (possible(7))
            {
                return true;
            }


            if (possible(8))
            {
                return true;
            }


            if (possible(9))
            {
                return true;
            }

            return false;
        }
                private bool possible(int p)
        {
                    if(p == 1)
                    {
                        if (button1.Text == "O" && button2.Text == "" && button3.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                        else if(button1.Text == "O" && button4.Text == "" && button7.Text == "" )
                        {
                            button7.Text = "O";

                            return true;
                        }


                        else if (button1.Text == "O" && button5.Text == "" && button9.Text == "")
                        {
                            button9.Text = "O";

                            return true;
                        }

                        
                    }

                    if (p == 2)
                    {
                        if (button2.Text == "O" && button1.Text == "" && button3.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                        else if (button2.Text == "O" && button5.Text == "" && button8.Text == "")
                        {
                            button8.Text = "O";

                            return true;
                        }


                    }

                    if (p == 3)
                    {
                        if (button3.Text == "O" && button1.Text == "" && button2.Text == "")
                        {
                            button1.Text = "O";

                            return true;
                        }

                        else if (button3.Text == "O" && button6.Text == "" && button9.Text == "")
                        {
                            button9.Text = "O";

                            return true;
                        }

                        else if (button3.Text == "O" && button5.Text == "" && button7.Text == "")
                        {
                            button7.Text = "O";

                            return true;
                        }

                    }

                    if (p == 4)
                    {
                        if (button4.Text == "O" && button1.Text == "" && button7.Text == "")
                        {
                            button7.Text = "O";

                            return true;
                        }

                        else if (button4.Text == "O" && button5.Text == "" && button6.Text == "")
                        {
                            button5.Text = "O";

                            return true;
                        }

                    }

                    if (p == 5)
                    {
                        if (button5.Text == "O" && button1.Text == "" && button9.Text == "")
                        {
                            button1.Text = "O";

                            return true;
                        }

                        else if (button5.Text == "O" && button3.Text == "" && button7.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                        else if (button5.Text == "O" && button2.Text == "" && button8.Text == "")
                        {
                            button2.Text = "O";

                            return true;
                        }

                        else if (button5.Text == "O" && button4.Text == "" && button6.Text == "")
                        {
                            button4.Text = "O";

                            return true;
                        }

                    }

                    if (p == 6)
                    {
                        if (button6.Text == "O" && button5.Text == "" && button4.Text == "")
                        {
                            button4.Text = "O";

                            return true;
                        }

                        else if (button6.Text == "O" && button3.Text == "" && button9.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                    }

                    if (p == 7)
                    {
                        if (button7.Text == "O" && button1.Text == "" && button4.Text == "")
                        {
                            button1.Text = "O";

                            return true;
                        }

                        else if (button7.Text == "O" && button5.Text == "" && button3.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                        else if (button7.Text == "O" && button8.Text == "" && button9.Text == "")
                        {
                            button9.Text = "O";

                            return true;
                        }

                    }

                    if (p == 8)
                    {
                        if (button8.Text == "O" && button9.Text == "" && button7.Text == "")
                        {
                            button7.Text = "O";

                            return true;
                        }

                        else if (button8.Text == "O" && button5.Text == "" && button2.Text == "")
                        {
                            button2.Text = "O";

                            return true;
                        }

                    }

                    if (p == 9)
                    {
                        if (button9.Text == "O" && button5.Text == "" && button1.Text == "")
                        {
                            button1.Text = "O";

                            return true;
                        }

                        else if (button9.Text == "O" && button3.Text == "" && button6.Text == "")
                        {
                            button3.Text = "O";

                            return true;
                        }

                        else if (button9.Text == "O" && button8.Text == "" && button7.Text == "")
                        {
                            button7.Text = "O";

                            return true;
                        }

                    }

            return false;
        }

        private bool possible_move_two()
        {
            if(possible_two(1))
            {
                
                return true;
            }

            else if (possible_two(2))
            {
               
                return true;
            }


            else if (possible_two(3))
            {
                return true;
            }

            else if (possible_two(4))
            {
                return true;
            }

            else if (possible_two(5))
            {
                return true;
            }

            else if (possible_two(6))
            {
                return true;
            }

            else if (possible_two(7))
            {
                return true;
            }

            else if (possible_two(8))
            {
                return true;
            }

            else if (possible_two(9))
            {
                return true;
            }

            return false;
        }
        private bool possible_two(int p)
        {
            if(p == 1)
            {
                if(button1.Text == "" && button2.Text == "" && button3.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button1.Text == "" && button4.Text == "" && button7.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button1.Text == "" && button5.Text == "" && button9.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                return false;
                
            }

            if (p == 2)
            {
                if (button2.Text == "" && button1.Text == "" && button3.Text == "")
                {
                    button2.Text = "O";
                    return true;
                }

                else if (button2.Text == "" && button5.Text == "" && button8.Text == "")
                {
                    button2.Text = "O";

                    return true;
                }

                return false;

            }

            if (p == 3)
            {
                if (button3.Text == "" && button2.Text == "" && button1.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

                else if (button3.Text == "" && button6.Text == "" && button9.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

            }

            if (p == 4)
            {
                if (button4.Text == "" && button1.Text == "" && button7.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button4.Text == "" && button5.Text == "" && button6.Text == "")
                {
                    button4.Text = "O";

                    return true;
                }

            }

            if (p == 5)
            {
                if (button5.Text == "" && button1.Text == "" && button9.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button5.Text == "" && button3.Text == "" && button7.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

                else if (button5.Text == "" && button2.Text == "" && button8.Text == "")
                {
                    button2.Text = "O";

                    return true;
                }

                else if (button5.Text == "" && button4.Text == "" && button6.Text == "")
                {
                    button4.Text = "O";

                    return true;
                }

            }

            if (p == 6)
            {
                if (button6.Text == "" && button5.Text == "" && button4.Text == "")
                {
                    button4.Text = "O";

                    return true;
                }

                else if (button6.Text == "" && button3.Text == "" && button9.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

            }

            if (p == 7)
            {
                if (button7.Text == "" && button4.Text == "" && button1.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button7.Text == "" && button5.Text == "" && button3.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

                else if (button7.Text == "" && button8.Text == "" && button9.Text == "")
                {
                    button7.Text = "O";

                    return true;
                }

            }

            if (p == 8)
            {
                if (button8.Text == "" && button7.Text == "" && button9.Text == "")
                {
                    button7.Text = "O";

                    return true;
                }

                else if (button8.Text == "" && button5.Text == "" && button2.Text == "")
                {
                    button2.Text = "O";

                    return true;
                }

            }

            if (p == 9)
            {
                if (button9.Text == "" && button5.Text == "" && button1.Text == "")
                {
                    button1.Text = "O";

                    return true;
                }

                else if (button9.Text == "" && button6.Text == "" && button3.Text == "")
                {
                    button3.Text = "O";

                    return true;
                }

                else if (button9.Text == "" && button8.Text == "" && button7.Text == "")
                {
                    button7.Text = "O";

                    return true;
                }

            }

            return false;
        }

        private bool possible_move_three()
        {
            if(button1.Text == "")
            {
                button1.Text = "O";

                return true;
            }

            else if (button2.Text == "")
            {
                button2.Text = "O";
                return true;
            }

            else if (button3.Text == "")
            {
                button3.Text = "O";
                return true;
            }

            else if (button4.Text == "")
            {
                button4.Text = "O";
                return true;
            }

            else if (button5.Text == "")
            {
                button5.Text = "O";
                return true;
            }

            else if (button6.Text == "")
            {
                button6.Text = "O";
                return true;
            }

            else if (button7.Text == "")
            {
                button7.Text = "O";
                return true;
            }

            else if (button8.Text == "")
            {
                button8.Text = "O";
                return true;
            }

            else if (button9.Text == "")
            {
                button9.Text = "O";
                return true;
            }

            return false;
        }

        private void pc_move()
        {

            if (pc_win())
                return;

            else if (stop_human_win())
                return;

            else if (possible_move_one())
                return;

            else if (possible_move_two())
                return;

            else if (possible_move_three())
                return;
        }

        private bool win_check()
        {
            if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button1.Text == "*" && button2.Text == "*" && button3.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button1.Text == "*" && button4.Text == "*" && button7.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button1.Text == "*" && button5.Text == "*" && button9.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button2.Text == "*" && button5.Text == "*" && button8.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button3.Text == "*" && button6.Text == "*" && button9.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button3.Text == "*" && button6.Text == "*" && button9.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button4.Text == "*" && button5.Text == "*" && button6.Text == "*")
            {
                label1.Text = "Playerr Wins!";
                return true;
            }

            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label1.Text = "Computer Wins!";
                return true;
            }

            else if (button7.Text == "*" && button8.Text == "*" && button9.Text == "*")
            {
                label1.Text = "Player Wins!";
                return true;
            }

            else if(button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && 
                button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                label1.Text = "Draw!";
                return true;
            }

            return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = "*";

                if (!win_check())
                    pc_move();

                if(win_check())
                    button10.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "")
            {
                button2.Text = "*";

                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
                   
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "")
            {
                button3.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "")
            {
                button4.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(button5.Text == "")
            {
                button5.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(button6.Text == "")
            {

                button6.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(button7.Text == "")
            {
                button7.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(button8.Text == "")
            {

                button8.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(button9.Text == "")
            {
                button9.Text = "*";
                if (!win_check())
                    pc_move();

                if (win_check())
                    button10.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button10.Visible = false;
        }
    }
}
