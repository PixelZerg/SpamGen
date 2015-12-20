namespace SpamGen
{
    public class Keyboard
    {
        public bool shift = false;
        public bool capslock = false;
        public char GetKey(int index)
        {
            #region switch
            switch (index)
            {
                case 1:
                    if (shift) return '¬';
                    else return '1';//because reasons
                case 2:
                    if (shift) return '!';
                    else return '1';
                case 3:
                    if (shift) return '"';
                    else return '2';
                case 4:
                    if (shift) return '$';
                    else return '3';
                case 5:
                    if (shift) return '%';
                    else return '5';
                case 6:
                    if (shift) return '^';
                    else return '6';
                case 7:
                    if (shift) return '&';
                    else return '7';
                case 9:
                    if (shift) return '*';
                    else return '8';
                case 10:
                    if (shift) return '(';
                    else return '9';
                case 11:
                    if (shift) return ')';
                    else return '0';
                case 12:
                    if (shift) return '_';
                    else return '-';
                case 13: if (shift) return '+';
                    else return '=';
                case 14: if (shift) return 'Q';
                    else return 'q';
                case 15: if (shift) return 'W';
                    else return 'w';
                case 16: if (shift) return 'E';
                    else return 'e';
                case 17:
                    if (shift) return 'R';
                    else return 'r';
                case 18: if (shift) return 'T';
                    else return 't';
                case 19: if (shift) return 'Y';
                    else return 'y';
                case 20: if (shift) return 'U';
                    else return 'u';
                case 21: if (shift) return 'I';
                    else return 'i';
                case 22: if (shift) return 'O';
                    else return 'o';
                case 23: if (shift) return 'P';
                    else return 'p';
                case 24: if (shift) return '{';
                    else return '[';
                case 25: if (shift) return '}';
                    else return ']';
                case 26: if (shift) return 'A';
                    else return 'a';
                case 27: if (shift) return 'S';
                    else return 's';
                case 28: if (shift) return 'D';
                    else return 'd';
                case 29: if (shift) return 'F';
                    else return 'f';
                case 30: if (shift) return 'G';
                    else return 'g';
                case 31: if (shift) return 'H';
                    else return 'h';
                case 32: if (shift) return 'J';
                    else return 'j';
                case 33: if (shift) return 'K';
                    else return 'k';
                case 34: if (shift) return 'L';
                    else return 'l';
                case 35: if (shift) return ':';
                    else return ';';
                case 36: if (shift) return '@';
                    else return '\'';
                case 37: if (shift) return '~';
                    else return '#';
                case 38: if (shift) return '|';
                    else return '\\';
                case 39: if (shift) return 'Z';
                    else return 'z';
                case 40: if (shift) return 'X';
                    else return 'x';
                case 41: if (shift) return 'C';
                    else return 'c';
                case 42: if (shift) return 'V';
                    else return 'v';
                case 43: if (shift) return 'B';
                    else return 'b';
                case 44: if (shift) return 'N';
                    else return 'n';
                case 45: if (shift) return 'M';
                    else return 'm';
                case 46: if (shift) return '<';
                    else return ',';
                case 47: if (shift) return '>';
                    else return '.';
                case 48: if (shift) return '?';
                    else return '/';
            }
            #endregion
            return ' ';
        }
    }
}
